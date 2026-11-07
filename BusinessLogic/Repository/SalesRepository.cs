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
        public int InsertSale(DateTime salesDate, decimal totalAmount)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    INSERT INTO tblSales (SalesDate, TotalAmount) 
                    OUTPUT INSERTED.SalesId 
                    VALUES (@SalesDate, @TotalAmount);";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SalesDate", salesDate);
                cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);

                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        public void InsertSaleDetail(int salesId, string productId, int quantity, decimal totalPrice)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    INSERT INTO tblSalesDetail (SalesId, ProductId, Quantity, TotalPrice)
                    VALUES (@SalesId, @ProductId, @Quantity, @TotalPrice);";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SalesId", salesId);
                cmd.Parameters.AddWithValue("@ProductId", productId);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteSale(int salesId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    SqlCommand cmdDetails = new SqlCommand(
                        "DELETE FROM tblSalesDetail WHERE SalesId = @SalesId", conn, transaction);
                    cmdDetails.Parameters.AddWithValue("@SalesId", salesId);
                    cmdDetails.ExecuteNonQuery();

                    SqlCommand cmdSale = new SqlCommand(
                        "DELETE FROM tblSales WHERE SalesId = @SalesId", conn, transaction);
                    cmdSale.Parameters.AddWithValue("@SalesId", salesId);
                    cmdSale.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
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
