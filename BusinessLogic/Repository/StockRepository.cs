using Microsoft.Data.SqlClient;
using System.Data;

namespace BusinessLogic.Repository
{
    public class StockRepository
    {
        private readonly string connectionString =

                        "Server=DESKTOP-SMD1DHH;Initial Catalog=SALESINVENTORY;Trusted_Connection=True;TrustServerCertificate=True;";

        public DataTable GetInventoryList(int lowStockThreshold, bool criticalOnly)
        {
            var dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT
                    ProductId, ProductName, Model, Brand, Category, Supplier,
                    Quantity, Amount,
                    CASE WHEN Quantity <= @LowStockThreshold THEN 'Low Stock' ELSE 'In Stock' END AS StockHealth
                FROM tblProduct
                WHERE IsActive = 1
                  AND (@CriticalOnly = 0 OR Quantity <= @LowStockThreshold)
                ORDER BY CASE WHEN @CriticalOnly = 1 THEN Quantity END ASC, ProductName ASC;", conn))
            {
                cmd.Parameters.AddWithValue("@LowStockThreshold", lowStockThreshold);
                cmd.Parameters.AddWithValue("@CriticalOnly", criticalOnly);
                new SqlDataAdapter(cmd).Fill(dt);
            }
            return dt;
        }

        public DataTable GetRecentMovements(int count)
        {
            var dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT TOP (@Count) m.[When], m.Activity, m.ReferenceNo, p.ProductName, m.Qty, m.[By]
                FROM (
                    SELECT StockInDate AS [When], 'Stock-In' AS Activity, ReferenceNo, ProductId,
                           Quantity AS Qty, StockInBy AS [By]
                    FROM tblStockIn
                    UNION ALL
                    SELECT AdjustmentDate, 'Adjustment', ReferenceNo, ProductId,
                           CASE WHEN Action = 'Remove' THEN -Quantity ELSE Quantity END, AdjustedBy
                    FROM tblStockAdjustment
                ) m
                INNER JOIN tblProduct p ON p.ProductId = m.ProductId
                ORDER BY m.[When] DESC;", conn))
            {
                cmd.Parameters.AddWithValue("@Count", count);
                new SqlDataAdapter(cmd).Fill(dt);
            }
            return dt;
        }
    }
}
