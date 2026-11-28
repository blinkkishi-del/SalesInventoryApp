using Microsoft.Data.SqlClient;
using Model;

namespace BusinessLogic.Repository
{
    public class CategoryRepository
    {
        private readonly string connectionString =
        "Server=KHARL2005\\SQLEXPRESS02;Initial Catalog=SALESINVENTORY;Trusted_Connection=True;TrustServerCertificate=True;";

        public List<CategoryModel> GetAll()
        {
            var categories = new List<CategoryModel>();
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(@"
                SELECT CategoryId, CategoryName
                FROM tblCategory
                WHERE IsActive = 1
                ORDER BY CategoryName ASC;", conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categories.Add(new CategoryModel
                        {
                            CategoryId = Convert.ToInt32(reader["CategoryId"]),
                            CategoryName = reader["CategoryName"].ToString()
                        });
                    }
                }
            }
            return categories;
        }

        public void AddCategory(string categoryName)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (var check = new SqlCommand(
                    "SELECT IsActive FROM tblCategory WHERE CategoryName = @Name;", conn))
                {
                    check.Parameters.AddWithValue("@Name", categoryName);
                    object isActive = check.ExecuteScalar();

                    if (isActive != null && Convert.ToBoolean(isActive))
                        throw new InvalidOperationException($"Category '{categoryName}' already exists.");

                    string sql = isActive != null
                        ? "UPDATE tblCategory SET IsActive = 1 WHERE CategoryName = @Name;"
                        : "INSERT INTO tblCategory (CategoryName) VALUES (@Name);";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", categoryName);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public void UpdateCategory(int categoryId, string newName)
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();
            using var tx = conn.BeginTransaction();
            try
            {
                string oldName;
                using (var get = new SqlCommand(
                    "SELECT CategoryName FROM tblCategory WHERE CategoryId = @Id AND IsActive = 1;", conn, tx))
                {
                    get.Parameters.AddWithValue("@Id", categoryId);
                    oldName = get.ExecuteScalar()?.ToString()
                        ?? throw new InvalidOperationException("Category not found.");
                }

                if (oldName == newName)
                {
                    tx.Commit();
                    return;
                }

                using (var dup = new SqlCommand(
                    "SELECT COUNT(*) FROM tblCategory WHERE CategoryName = @Name AND CategoryId <> @Id;", conn, tx))
                {
                    dup.Parameters.AddWithValue("@Name", newName);
                    dup.Parameters.AddWithValue("@Id", categoryId);
                    if (Convert.ToInt32(dup.ExecuteScalar()) > 0)
                        throw new InvalidOperationException($"Category '{newName}' already exists.");
                }

                using (var rename = new SqlCommand(
                    "UPDATE tblCategory SET CategoryName = @Name WHERE CategoryId = @Id;", conn, tx))
                {
                    rename.Parameters.AddWithValue("@Name", newName);
                    rename.Parameters.AddWithValue("@Id", categoryId);
                    rename.ExecuteNonQuery();
                }

                using (var products = new SqlCommand(
                    "UPDATE tblProduct SET Category = @NewName WHERE Category = @OldName;", conn, tx))
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

        public void DeleteCategory(int categoryId)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (var inUse = new SqlCommand(@"
                    SELECT COUNT(*) FROM tblProduct p
                    INNER JOIN tblCategory c ON p.Category = c.CategoryName
                    WHERE c.CategoryId = @Id AND p.IsActive = 1;", conn))
                {
                    inUse.Parameters.AddWithValue("@Id", categoryId);
                    int count = Convert.ToInt32(inUse.ExecuteScalar());
                    if (count > 0)
                        throw new InvalidOperationException(
                            $"This category is used by {count} product(s). Move them to another category first.");
                }

                using (var cmd = new SqlCommand(
                    "UPDATE tblCategory SET IsActive = 0 WHERE CategoryId = @Id;", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", categoryId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
