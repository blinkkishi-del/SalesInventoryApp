using Microsoft.Data.SqlClient;
using System.Data;

namespace BusinessLogic.Repository
{
    public class StockAdjustmentRepository
    {
        private readonly string connectionString =
        "Server=KHARL2005\\SQLEXPRESS02;Initial Catalog=SALESINVENTORY;Trusted_Connection=True;TrustServerCertificate=True;";

        public string SaveAdjustment(string productId, string action, int quantity,
                                     string reason, string remarks, string adjustedBy)
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();
            using var tx = conn.BeginTransaction();
            try
            {
                string stockSql = action == "Remove"
                    ? "UPDATE tblProduct SET Quantity = Quantity - @Qty WHERE ProductId = @ProductId AND IsActive = 1 AND Quantity >= @Qty;"
                    : "UPDATE tblProduct SET Quantity = Quantity + @Qty WHERE ProductId = @ProductId AND IsActive = 1;";

                using (var stock = new SqlCommand(stockSql, conn, tx))
                {
                    stock.Parameters.AddWithValue("@Qty", quantity);
                    stock.Parameters.AddWithValue("@ProductId", productId);
                    if (stock.ExecuteNonQuery() != 1)
                        throw new InvalidOperationException(action == "Remove"
                            ? "Not enough stock to remove that quantity."
                            : "Product no longer exists.");
                }

                string referenceNo = NextReferenceNo(conn, tx);

                using (var insert = new SqlCommand(@"
                    INSERT INTO tblStockAdjustment (ReferenceNo, ProductId, Action, Quantity, Reason, Remarks, AdjustedBy)
                    VALUES (@ReferenceNo, @ProductId, @Action, @Qty, @Reason, @Remarks, @AdjustedBy);", conn, tx))
                {
                    insert.Parameters.AddWithValue("@ReferenceNo", referenceNo);
                    insert.Parameters.AddWithValue("@ProductId", productId);
                    insert.Parameters.AddWithValue("@Action", action);
                    insert.Parameters.AddWithValue("@Qty", quantity);
                    insert.Parameters.AddWithValue("@Reason", reason);
                    insert.Parameters.AddWithValue("@Remarks", string.IsNullOrWhiteSpace(remarks) ? DBNull.Value : remarks);
                    insert.Parameters.AddWithValue("@AdjustedBy", (object)adjustedBy ?? DBNull.Value);
                    insert.ExecuteNonQuery();
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
            string prefix = "SA-" + DateTime.Now.ToString("yyyyMMdd") + "-";
            using var cmd = new SqlCommand(@"
                SELECT MAX(ReferenceNo) FROM tblStockAdjustment WITH (UPDLOCK, HOLDLOCK)
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
                    a.ReferenceNo,
                    a.AdjustmentDate,
                    a.ProductId,
                    p.ProductName,
                    a.Action,
                    a.Quantity,
                    a.Reason,
                    a.Remarks,
                    a.AdjustedBy
                FROM tblStockAdjustment a
                INNER JOIN tblProduct p ON a.ProductId = p.ProductId
                WHERE CAST(a.AdjustmentDate AS DATE) BETWEEN @From AND @To
                ORDER BY a.AdjustmentDate DESC;", conn))
            {
                cmd.Parameters.AddWithValue("@From", from.Date);
                cmd.Parameters.AddWithValue("@To", to.Date);
                new SqlDataAdapter(cmd).Fill(dt);
            }
            return dt;
        }
    }
}
