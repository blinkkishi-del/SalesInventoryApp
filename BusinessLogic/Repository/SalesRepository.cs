using Microsoft.Data.SqlClient;
using System.Data;

namespace BusinessLogic.Repository
{
    public class SalesRepository
    {
        private readonly string connectionString =
        "Server=KHARL2005\\SQLEXPRESS02;Initial Catalog=SALESINVENTORY;Trusted_Connection=True;TrustServerCertificate=True;";

        public string GetNextReceiptNo()
        {
            using var conn = new SqlConnection(connectionString);
            using var cmd = new SqlCommand(@"
                SELECT CAST(ISNULL(CAST(last_value AS BIGINT) + CAST(increment_value AS BIGINT), CAST(seed_value AS BIGINT)) AS BIGINT)
                FROM sys.identity_columns
                WHERE object_id = OBJECT_ID('dbo.tblSales');", conn);
            conn.Open();
            long next = Convert.ToInt64(cmd.ExecuteScalar() ?? 1L);
            return "INV-" + next.ToString("D6");
        }

        public DataTable GetSalesHistory(DateTime from, DateTime to, string cashier, string keyword)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT
                    s.ReceiptNo,
                    s.SalesDate,
                    s.CashierUsername AS SoldBy,
                    sd.ProductId,
                    p.ProductName,
                    sd.Quantity,
                    sd.DiscountAmount,
                    sd.TotalPrice,
                    s.OrderDiscountAmount AS OrderDiscount
                FROM tblSales s
                INNER JOIN tblSalesDetail sd ON s.SalesId = sd.SalesId
                INNER JOIN tblProduct p ON sd.ProductId = p.ProductId
                WHERE s.SalesDate BETWEEN @From AND @To
                  AND (@Cashier IS NULL OR s.CashierUsername = @Cashier)
                  AND (@Keyword = '' OR p.ProductName LIKE '%' + @Keyword + '%')
                ORDER BY s.SalesId DESC;", conn))
            {
                cmd.Parameters.AddWithValue("@From", from.Date);
                cmd.Parameters.AddWithValue("@To", to.Date);
                cmd.Parameters.AddWithValue("@Cashier", string.IsNullOrEmpty(cashier) ? DBNull.Value : cashier);
                cmd.Parameters.AddWithValue("@Keyword", keyword ?? "");
                DataTable dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);
                return dt;
            }
        }

        public DataTable GetSoldItemsSummary(DateTime from, DateTime to)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT
                    sd.ProductId,
                    p.ProductName,
                    p.Model,
                    SUM(sd.Quantity)       AS Quantity,
                    SUM(sd.DiscountAmount) AS DiscountAmount,
                    SUM(sd.TotalPrice)     AS TotalPrice
                FROM tblSales s
                INNER JOIN tblSalesDetail sd ON s.SalesId = sd.SalesId
                INNER JOIN tblProduct p ON sd.ProductId = p.ProductId
                WHERE s.SalesDate BETWEEN @From AND @To
                GROUP BY sd.ProductId, p.ProductName, p.Model
                ORDER BY p.ProductName ASC;", conn))
            {
                cmd.Parameters.AddWithValue("@From", from.Date);
                cmd.Parameters.AddWithValue("@To", to.Date);
                DataTable dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);
                return dt;
            }
        }

        public DataTable GetTopSelling(DateTime from, DateTime to)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT TOP 10
                    ROW_NUMBER() OVER (ORDER BY SUM(sd.Quantity) DESC, SUM(sd.TotalPrice) DESC) AS [Rank],
                    sd.ProductId,
                    p.ProductName,
                    p.Model,
                    p.Brand,
                    SUM(sd.Quantity)   AS Quantity,
                    SUM(sd.TotalPrice) AS TotalPrice
                FROM tblSales s
                INNER JOIN tblSalesDetail sd ON s.SalesId = sd.SalesId
                INNER JOIN tblProduct p ON sd.ProductId = p.ProductId
                WHERE s.SalesDate BETWEEN @From AND @To
                GROUP BY sd.ProductId, p.ProductName, p.Model, p.Brand
                ORDER BY [Rank];", conn))
            {
                cmd.Parameters.AddWithValue("@From", from.Date);
                cmd.Parameters.AddWithValue("@To", to.Date);
                DataTable dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);
                return dt;
            }
        }

        public int GetSalesCountByDate(DateTime date)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tblSales WHERE SalesDate = @Date;", conn))
            {
                cmd.Parameters.AddWithValue("@Date", date.Date);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public DataTable GetRecentSales(int count)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT TOP (@Count)
                    s.ReceiptNo,
                    s.SalesDate,
                    s.CashierUsername AS SoldBy,
                    (SELECT ISNULL(SUM(sd.Quantity), 0) FROM tblSalesDetail sd WHERE sd.SalesId = s.SalesId) AS Items,
                    s.TotalAmount
                FROM tblSales s
                ORDER BY s.SalesId DESC;", conn))
            {
                cmd.Parameters.AddWithValue("@Count", count);
                DataTable dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);
                return dt;
            }
        }

        public decimal GetOrderDiscountTotal(DateTime from, DateTime to)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                "SELECT ISNULL(SUM(OrderDiscountAmount), 0) FROM tblSales WHERE SalesDate BETWEEN @From AND @To;", conn))
            {
                cmd.Parameters.AddWithValue("@From", from.Date);
                cmd.Parameters.AddWithValue("@To", to.Date);
                conn.Open();
                return Convert.ToDecimal(cmd.ExecuteScalar());
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

        public string Checkout(DateTime salesDate, IEnumerable<(string ProductId, int Quantity, decimal Price, decimal DiscountAmount)> lines,
            string cashierUsername = null, decimal orderDiscountPercent = 0)
        {
            var items = lines.ToList();
            using var conn = new SqlConnection(connectionString);
            conn.Open();
            using var tx = conn.BeginTransaction();
            try
            {
                decimal subtotal = items.Sum(l => l.Quantity * l.Price - l.DiscountAmount);
                decimal orderDiscount = Math.Round(subtotal * orderDiscountPercent / 100m, 2);
                decimal total = subtotal - orderDiscount;
                int salesId;

                using (var cmd = new SqlCommand(@"
                    INSERT INTO tblSales (SalesDate, TotalAmount, CashierUsername, OrderDiscountPercent, OrderDiscountAmount)
                    OUTPUT INSERTED.SalesId
                    VALUES (@SalesDate, @TotalAmount, @CashierUsername, @OrderDiscountPercent, @OrderDiscountAmount);", conn, tx))
                {
                    cmd.Parameters.AddWithValue("@SalesDate", salesDate);
                    cmd.Parameters.AddWithValue("@TotalAmount", total);
                    cmd.Parameters.AddWithValue("@OrderDiscountPercent", orderDiscountPercent);
                    cmd.Parameters.AddWithValue("@OrderDiscountAmount", orderDiscount);
                    cmd.Parameters.AddWithValue("@CashierUsername", (object)cashierUsername ?? DBNull.Value);
                    salesId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                string receiptNo = "INV-" + salesId.ToString("D6");
                using (var receipt = new SqlCommand(
                    "UPDATE tblSales SET ReceiptNo = @ReceiptNo WHERE SalesId = @SalesId;", conn, tx))
                {
                    receipt.Parameters.AddWithValue("@ReceiptNo", receiptNo);
                    receipt.Parameters.AddWithValue("@SalesId", salesId);
                    receipt.ExecuteNonQuery();
                }

                foreach (var (productId, quantity, price, discountAmount) in items)
                {
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
                        INSERT INTO tblSalesDetail (SalesId, ProductId, Quantity, TotalPrice, DiscountAmount)
                        VALUES (@SalesId, @ProductId, @Quantity, @TotalPrice, @DiscountAmount);", conn, tx))
                    {
                        detail.Parameters.AddWithValue("@SalesId", salesId);
                        detail.Parameters.AddWithValue("@ProductId", productId);
                        detail.Parameters.AddWithValue("@Quantity", quantity);
                        detail.Parameters.AddWithValue("@TotalPrice", quantity * price - discountAmount);
                        detail.Parameters.AddWithValue("@DiscountAmount", discountAmount);
                        detail.ExecuteNonQuery();
                    }
                }

                tx.Commit();
                return receiptNo;
            }
            catch
            {
                tx.Rollback();
                throw;
            }
        }

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
    }
}
