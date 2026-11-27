using Model;
using Microsoft.Data.SqlClient;

namespace BusinessLogic.Repository
{
    public class UserRepository
    {
        private readonly string connectionString =
                        "Server=DESKTOP-SMD1DHH;Initial Catalog=SALESINVENTORY;Trusted_Connection=True;TrustServerCertificate=True;";

        public UserModel GetByUsername(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Username, Password, Role, FullName, IsActive FROM tblUsers WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new UserModel
                    {
                        Username = reader["Username"].ToString(),
                        Password = reader["Password"].ToString(),
                        Role = reader["Role"].ToString(),
                        FullName = reader["FullName"].ToString(),
                        IsActive = Convert.ToBoolean(reader["IsActive"])
                    };
                }
            }
            return null;
        }

        public List<string> GetUsernamesByRole(string role)
        {
            var usernames = new List<string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(
                "SELECT Username FROM tblUsers WHERE Role = @Role ORDER BY Username", connection))
            {
                command.Parameters.AddWithValue("@Role", role);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        usernames.Add(reader["Username"].ToString());
                }
            }
            return usernames;
        }

        public List<UserModel> GetAll()
        {
            var users = new List<UserModel>();
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(
                "SELECT Username, FullName, Role, IsActive FROM tblUsers WHERE Username IS NOT NULL ORDER BY Role, Username;", conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new UserModel
                        {
                            Username = reader["Username"].ToString(),
                            FullName = reader["FullName"].ToString(),
                            Role = reader["Role"].ToString(),
                            IsActive = Convert.ToBoolean(reader["IsActive"])
                        });
                    }
                }
            }
            return users;
        }

        public void AddUser(UserModel user)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var check = new SqlCommand("SELECT COUNT(*) FROM tblUsers WHERE Username = @Username;", conn))
                {
                    check.Parameters.AddWithValue("@Username", user.Username);
                    if (Convert.ToInt32(check.ExecuteScalar()) > 0)
                        throw new InvalidOperationException($"Username '{user.Username}' is already taken.");
                }

                using (var cmd = new SqlCommand(@"
                    INSERT INTO tblUsers (Username, Password, Role, FullName, IsActive)
                    VALUES (@Username, @Password, @Role, @FullName, 1);", conn))
                {
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@Role", user.Role);
                    cmd.Parameters.AddWithValue("@FullName", user.FullName);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void SetActive(string username, bool isActive)
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();
            using var tx = conn.BeginTransaction();
            try
            {
                if (!isActive)
                {
                    using var lastAdmin = new SqlCommand(@"
                        SELECT CASE WHEN EXISTS (SELECT 1 FROM tblUsers WHERE Username = @Username AND Role = 'Admin')
                                     AND NOT EXISTS (SELECT 1 FROM tblUsers WITH (UPDLOCK, HOLDLOCK)
                                                     WHERE Role = 'Admin' AND IsActive = 1 AND Username <> @Username)
                               THEN 1 ELSE 0 END;", conn, tx);
                    lastAdmin.Parameters.AddWithValue("@Username", username);

                    if (Convert.ToInt32(lastAdmin.ExecuteScalar()) == 1)
                        throw new InvalidOperationException("You cannot deactivate the last active Admin account.");
                }

                using var cmd = new SqlCommand("UPDATE tblUsers SET IsActive = @IsActive WHERE Username = @Username;", conn, tx);
                cmd.Parameters.AddWithValue("@IsActive", isActive);
                cmd.Parameters.AddWithValue("@Username", username);
                if (cmd.ExecuteNonQuery() == 0)
                    throw new InvalidOperationException("Account not found.");

                tx.Commit();
            }
            catch
            {
                tx.Rollback();
                throw;
            }
        }

        public void SetPassword(string username, string passwordHash)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("UPDATE tblUsers SET Password = @Password WHERE Username = @Username;", conn))
            {
                cmd.Parameters.AddWithValue("@Password", passwordHash);
                cmd.Parameters.AddWithValue("@Username", username);
                conn.Open();
                if (cmd.ExecuteNonQuery() == 0)
                    throw new InvalidOperationException("Account not found.");
            }
        }
    }
}
