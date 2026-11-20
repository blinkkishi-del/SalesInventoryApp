using Microsoft.Data.SqlClient;
using System.Data;

namespace BusinessLogic.Repository
{
    public class SalesRepository
    {
        private readonly string connectionString =
            "Server=DESKTOP-SMD1DHH;Initial Catalog=SALESINVENTORY;Trusted_Connection=True;TrustServerCertificate=True;";

        public DataTable GetAllSales()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT
                        s.SalesId,
                        s.SalesDate,
                        p.ProductName,
                        sd.ProductId,
                        sd.Quantity,
                        sd.TotalPrice
                    FROM tblSales s
                    INNER JOIN tblSalesDetail sd ON s.SalesId = sd.SalesId
                    INNER JOIN tblProduct p ON sd.ProductId = p.ProductId
                    ORDER BY s.SalesDate DESC;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetSalesByDate(DateTime date)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT
                        s.SalesId,
                        s.SalesDate,
                        p.ProductName,
                        sd.ProductId,
                        sd.Quantity,
                        sd.TotalPrice
                    FROM tblSales s
                    INNER JOIN tblSalesDetail sd ON s.SalesId = sd.SalesId
                    INNER JOIN tblProduct p ON sd.ProductId = p.ProductId
                    WHERE CAST(s.SalesDate AS DATE) = @Date;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Date", date.Date);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public decimal GetTotalSalesByDate(DateTime date)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT ISNULL(SUM(TotalAmount), 0)
                    FROM tblSales
                    WHERE CAST(SalesDate AS DATE) = @Date;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Date", date.Date);
                conn.Open();
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }

        /// <summary>
        /// Atomic checkout: one sale header, all detail lines, stock decremented — all or nothing.
        /// Throws if any product's stock is insufficient (guarded UPDATE returns 0 rows).
        /// </summary>
        public void Checkout(DateTime salesDate, IEnumerable<(string ProductId, int Quantity, decimal Price)> lines)
        {
            var items = lines.ToList();
            using var conn = new SqlConnection(connectionString);
            conn.Open();
            using var tx = conn.BeginTransaction();
            try
            {
                decimal total = items.Sum(l => l.Quantity * l.Price);
                int salesId;

                using (var cmd = new SqlCommand(@"
                    INSERT INTO tblSales (SalesDate, TotalAmount)
                    OUTPUT INSERTED.SalesId
                    VALUES (@SalesDate, @TotalAmount);", conn, tx))
                {
                    cmd.Parameters.AddWithValue("@SalesDate", salesDate);
                    cmd.Parameters.AddWithValue("@TotalAmount", total);
                    salesId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                foreach (var (productId, quantity, price) in items)
                {
                    // Guard prevents overselling even under concurrent checkouts.
                    using (var stock = new SqlCommand(@"
                        UPDATE tblProduct
                        SET Quantity = Quantity - @Quantity
                        WHERE ProductId = @ProductId
                          AND IsActive = 1
                          AND Quantity >= @Quantity;", conn, tx))
                    {
                        stock.Parameters.AddWithValue("@ProductId", productId);
                        stock.Parameters.AddWithValue("@Quantity", quantity);
                        if (stock.ExecuteNonQuery() != 1)
                            throw new InvalidOperationException(
                                $"Not enough stock for product {productId}.");
                    }

                    using (var detail = new SqlCommand(@"
                        INSERT INTO tblSalesDetail (SalesId, ProductId, Quantity, TotalPrice)
                        VALUES (@SalesId, @ProductId, @Quantity, @TotalPrice);", conn, tx))
                    {
                        detail.Parameters.AddWithValue("@SalesId", salesId);
                        detail.Parameters.AddWithValue("@ProductId", productId);
                        detail.Parameters.AddWithValue("@Quantity", quantity);
                        detail.Parameters.AddWithValue("@TotalPrice", quantity * price);
                        detail.ExecuteNonQuery();
                    }
                }

                tx.Commit();
            }
            catch
            {
                tx.Rollback();
                throw;
            }
        }

        public void DeleteSale(int salesId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using var transaction = conn.BeginTransaction();
                try
                {
                    // Restore stock for every item in the deleted sale.
                    using (var restore = new SqlCommand(@"
                        UPDATE p SET p.Quantity = p.Quantity + sd.Quantity
                        FROM tblProduct p
                        INNER JOIN tblSalesDetail sd ON sd.ProductId = p.ProductId
                        WHERE sd.SalesId = @SalesId;", conn, transaction))
                    {
                        restore.Parameters.AddWithValue("@SalesId", salesId);
                        restore.ExecuteNonQuery();
                    }

                    using (var cmdDetails = new SqlCommand(
                        "DELETE FROM tblSalesDetail WHERE SalesId = @SalesId", conn, transaction))
                    {
                        cmdDetails.Parameters.AddWithValue("@SalesId", salesId);
                        cmdDetails.ExecuteNonQuery();
                    }

                    using (var cmdSale = new SqlCommand(
                        "DELETE FROM tblSales WHERE SalesId = @SalesId", conn, transaction))
                    {
                        cmdSale.Parameters.AddWithValue("@SalesId", salesId);
                        cmdSale.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        /// <summary>Returns the top 5 products by total quantity sold (all time).</summary>
        public DataTable GetTop5Sellers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT TOP 5
                        p.ProductName,
                        SUM(sd.Quantity)   AS TotalQtySold,
                        SUM(sd.TotalPrice) AS TotalRevenue
                    FROM tblSalesDetail sd
                    INNER JOIN tblProduct p ON sd.ProductId = p.ProductId
                    GROUP BY p.ProductName
                    ORDER BY TotalQtySold DESC;";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        /// <summary>Returns total sales amount for each of the last 7 days (including today).</summary>
        public DataTable GetLast7DaysSales()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT
                        CAST(d.SalesDate AS DATE)       AS SaleDay,
                        ISNULL(SUM(d.TotalAmount), 0)   AS DayTotal
                    FROM (
                        SELECT CAST(SalesDate AS DATE) AS SalesDate, TotalAmount
                        FROM tblSales
                        WHERE SalesDate >= CAST(DATEADD(DAY, -6, GETDATE()) AS DATE)
                    ) d
                    GROUP BY CAST(d.SalesDate AS DATE)
                    ORDER BY SaleDay ASC;";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable SearchSalesByProductName(string keyword)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT
                        s.SalesId,
                        s.SalesDate,
                        p.ProductName,
                        sd.ProductId,
                        sd.Quantity,
                        sd.TotalPrice
                    FROM tblSales s
                    INNER JOIN tblSalesDetail sd ON s.SalesId = sd.SalesId
                    INNER JOIN tblProduct p ON sd.ProductId = p.ProductId
                    WHERE p.ProductName LIKE @Keyword
                    ORDER BY s.SalesDate DESC;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
