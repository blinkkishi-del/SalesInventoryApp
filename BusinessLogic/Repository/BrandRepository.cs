using Microsoft.Data.SqlClient;
using Model;

namespace BusinessLogic.Repository
{
    public class BrandRepository
    {
        private readonly string connectionString =
        "Server=KHARL2005\\SQLEXPRESS02;Initial Catalog=SALESINVENTORY;Trusted_Connection=True;TrustServerCertificate=True;";

        public List<BrandModel> GetAll()
        {
            var brands = new List<BrandModel>();
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(@"
                SELECT BrandId, BrandName
                FROM tblBrand
                WHERE IsActive = 1
                ORDER BY BrandName ASC;", conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        brands.Add(new BrandModel
                        {
                            BrandId = Convert.ToInt32(reader["BrandId"]),
                            BrandName = reader["BrandName"].ToString()
                        });
                    }
                }
            }
            return brands;
        }

        public void AddBrand(string brandName)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (var check = new SqlCommand(
                    "SELECT IsActive FROM tblBrand WHERE BrandName = @Name;", conn))
                {
                    check.Parameters.AddWithValue("@Name", brandName);
                    object isActive = check.ExecuteScalar();

                    if (isActive != null && Convert.ToBoolean(isActive))
                        throw new InvalidOperationException($"Brand '{brandName}' already exists.");

                    string sql = isActive != null
                        ? "UPDATE tblBrand SET IsActive = 1 WHERE BrandName = @Name;"
                        : "INSERT INTO tblBrand (BrandName) VALUES (@Name);";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", brandName);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public void UpdateBrand(int brandId, string newName)
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();
            using var tx = conn.BeginTransaction();
            try
            {
                string oldName;
                using (var get = new SqlCommand(
                    "SELECT BrandName FROM tblBrand WHERE BrandId = @Id AND IsActive = 1;", conn, tx))
                {
                    get.Parameters.AddWithValue("@Id", brandId);
                    oldName = get.ExecuteScalar()?.ToString()
                        ?? throw new InvalidOperationException("Brand not found.");
                }

                if (oldName == newName)
                {
                    tx.Commit();
                    return;
                }

                using (var dup = new SqlCommand(
                    "SELECT COUNT(*) FROM tblBrand WHERE BrandName = @Name AND BrandId <> @Id;", conn, tx))
                {
                    dup.Parameters.AddWithValue("@Name", newName);
                    dup.Parameters.AddWithValue("@Id", brandId);
                    if (Convert.ToInt32(dup.ExecuteScalar()) > 0)
                        throw new InvalidOperationException($"Brand '{newName}' already exists.");
                }

                using (var rename = new SqlCommand(
                    "UPDATE tblBrand SET BrandName = @Name WHERE BrandId = @Id;", conn, tx))
                {
                    rename.Parameters.AddWithValue("@Name", newName);
                    rename.Parameters.AddWithValue("@Id", brandId);
                    rename.ExecuteNonQuery();
                }

                using (var products = new SqlCommand(
                    "UPDATE tblProduct SET Brand = @NewName WHERE Brand = @OldName;", conn, tx))
                {
                    products.Parameters.AddWithValue("@NewName", newName);
                    products.Parameters.AddWithValue("@OldName", oldName);
                    products.ExecuteNonQuery();
                }

                tx.Commit();
            }
            catch
            {
                tx.Rollback();
                throw;
            }
        }

        public void DeleteBrand(int brandId)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (var inUse = new SqlCommand(@"
                    SELECT COUNT(*) FROM tblProduct p
                    INNER JOIN tblBrand c ON p.Brand = c.BrandName
                    WHERE c.BrandId = @Id AND p.IsActive = 1;", conn))
                {
                    inUse.Parameters.AddWithValue("@Id", brandId);
                    int count = Convert.ToInt32(inUse.ExecuteScalar());
                    if (count > 0)
                        throw new InvalidOperationException(
                            $"This brand is used by {count} product(s). Move them to another brand first.");
                }

                using (var cmd = new SqlCommand(
                    "UPDATE tblBrand SET IsActive = 0 WHERE BrandId = @Id;", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", brandId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
