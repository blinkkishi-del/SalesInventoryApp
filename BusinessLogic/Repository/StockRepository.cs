using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BusinessLogic.Repository
{
    public class StockRepository
    {

     private string connectionString =
     "Server=DESKTOP-SMD1DHH;Initial Catalog=SALESINVENTORY;Trusted_Connection=True;TrustServerCertificate=True;";



        public DataTable GetTopProducts()
        {
            var dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("GetTop50Products", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    new SqlDataAdapter(cmd).Fill(dt);
                }
                catch
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT TOP 50 * FROM tblProduct ORDER BY Quantity DESC";
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }
            return dt;
        }

        public int GetTotalInventory()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT ISNULL(SUM(Quantity), 0) FROM tblProduct", conn))
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                return (result != DBNull.Value) ? Convert.ToInt32(result) : 0;
            }
        }

        public int GetLowStockCount(int threshold = 10)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tblProduct WHERE Quantity <= @Threshold", conn))
            {
                cmd.Parameters.AddWithValue("@Threshold", threshold);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        public DataTable GetStockByProductId(string productId)
        {
            var dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        p.ProductId,
                        p.ProductName,
                        p.Category,
                        ISNULL(SUM(sd.Quantity), 0) AS QuantitySold,
                        p.Quantity AS CurrentStock,
                        (p.Quantity + ISNULL(SUM(sd.Quantity), 0)) AS PreviousStock
                    FROM tblProduct p
                    LEFT JOIN tblSalesDetail sd ON p.ProductId = sd.ProductId
                    LEFT JOIN tblSales s ON sd.SalesId = s.SalesId
                    WHERE (@ProductId = '' OR p.ProductId LIKE '%' + @ProductId + '%')
                    GROUP BY p.ProductId, p.ProductName, p.Category, p.Quantity
                    ORDER BY p.ProductName;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductId", productId ?? "");
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }

            return dt;
        }
    }
}
