using Microsoft.Data.SqlClient;
using Model;
using System.Data;

namespace BusinessLogic.Repository
{
    public class StockInRepository
    {
        private readonly string connectionString =
        "Server=KHARL2005\\SQLEXPRESS02;Initial Catalog=SALESINVENTORY;Trusted_Connection=True;TrustServerCertificate=True;";

        public string SaveStockIn(string supplierId, string stockInBy, IEnumerable<StockInLineModel> lines)
        {
            var items = lines.ToList();
            using var conn = new SqlConnection(connectionString);
            conn.Open();
            using var tx = conn.BeginTransaction();
            try
            {
                string referenceNo = NextReferenceNo(conn, tx);

                foreach (var line in items)
                {
                    using (var insert = new SqlCommand(@"
                        INSERT INTO tblStockIn (ReferenceNo, ProductId, SupplierId, Quantity, StockInBy)
                        VALUES (@ReferenceNo, @ProductId, @SupplierId, @Quantity, @StockInBy);", conn, tx))
                    {
                        insert.Parameters.AddWithValue("@ReferenceNo", referenceNo);
                        insert.Parameters.AddWithValue("@ProductId", line.ProductId);
                        insert.Parameters.AddWithValue("@SupplierId", supplierId);
                        insert.Parameters.AddWithValue("@Quantity", line.Quantity);
                        insert.Parameters.AddWithValue("@StockInBy", (object)stockInBy ?? DBNull.Value);
                        insert.ExecuteNonQuery();
                    }

                    using (var stock = new SqlCommand(@"
                        UPDATE tblProduct SET Quantity = Quantity + @Quantity
                        WHERE ProductId = @ProductId AND IsActive = 1;", conn, tx))
                    {
                        stock.Parameters.AddWithValue("@Quantity", line.Quantity);
                        stock.Parameters.AddWithValue("@ProductId", line.ProductId);
                        if (stock.ExecuteNonQuery() != 1)
                            throw new InvalidOperationException($"Product {line.ProductId} no longer exists.");
                    }
                }

                tx.Commit();
                return referenceNo;
            }
            catch
            {
                tx.Rollback();
                throw;
            }
        }

        private static string NextReferenceNo(SqlConnection conn, SqlTransaction tx)
        {
            string prefix = "SI-" + DateTime.Now.ToString("yyyyMMdd") + "-";
            using var cmd = new SqlCommand(@"
                SELECT MAX(ReferenceNo) FROM tblStockIn WITH (UPDLOCK, HOLDLOCK)
                WHERE ReferenceNo LIKE @Prefix + '%';", conn, tx);
            cmd.Parameters.AddWithValue("@Prefix", prefix);
            object last = cmd.ExecuteScalar();

            int next = 1;
            if (last != null && last != DBNull.Value && int.TryParse(last.ToString()!.Substring(prefix.Length), out int n))
                next = n + 1;

            return prefix + next.ToString("D4");
        }

        public DataTable GetHistory(DateTime from, DateTime to)
        {
            var dt = new DataTable();
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(@"
                SELECT
                    si.ReferenceNo,
                    si.StockInDate,
                    si.ProductId,
                    p.ProductName,
                    p.Model,
                    si.Quantity,
                    s.SupplierName,
                    si.StockInBy
                FROM tblStockIn si
                INNER JOIN tblProduct p ON si.ProductId = p.ProductId
                INNER JOIN tblSupplier s ON si.SupplierId = s.SupplierId
                WHERE CAST(si.StockInDate AS DATE) BETWEEN @From AND @To
                ORDER BY si.StockInDate DESC;", conn))
            {
                cmd.Parameters.AddWithValue("@From", from.Date);
                cmd.Parameters.AddWithValue("@To", to.Date);
                new SqlDataAdapter(cmd).Fill(dt);
            }
            return dt;
        }
    }
}
