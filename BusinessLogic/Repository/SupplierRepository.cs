using Microsoft.Data.SqlClient;
using Model;

namespace BusinessLogic.Repository
{
    public class SupplierRepository
    {
        private readonly string connectionString =
                        "Server=DESKTOP-SMD1DHH;Initial Catalog=SALESINVENTORY;Trusted_Connection=True;TrustServerCertificate=True;";

        public void AddSupplier(SupplierModel supplier)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(@"
                INSERT INTO tblSupplier (SupplierId, SupplierName, Address, ContactPerson, PhoneNumber, EmailAddress)
                SELECT 'SUP-' + FORMAT(1 + ISNULL(MAX(TRY_CAST(SUBSTRING(SupplierId, 5, 16) AS INT)), 0), '000'),
                       @SupplierName, @Address, @ContactPerson, @PhoneNumber, @EmailAddress
                FROM tblSupplier WITH (UPDLOCK, HOLDLOCK)
                WHERE SupplierId LIKE 'SUP-%';", conn))
            {
                cmd.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);
                cmd.Parameters.AddWithValue("@Address", supplier.Address ?? string.Empty);
                cmd.Parameters.AddWithValue("@ContactPerson", supplier.ContactPerson ?? string.Empty);
                cmd.Parameters.AddWithValue("@PhoneNumber", supplier.PhoneNumber ?? string.Empty);
                cmd.Parameters.AddWithValue("@EmailAddress", supplier.EmailAddress ?? string.Empty);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateSupplier(SupplierModel supplier)
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();
            using var tx = conn.BeginTransaction();
            try
            {
                string oldName;
                using (var get = new SqlCommand(
                    "SELECT SupplierName FROM tblSupplier WHERE SupplierId = @SupplierId AND IsActive = 1;", conn, tx))
                {
                    get.Parameters.AddWithValue("@SupplierId", supplier.SupplierId);
                    oldName = get.ExecuteScalar()?.ToString()
                        ?? throw new InvalidOperationException("Supplier not found.");
                }

                using (var dup = new SqlCommand(
                    "SELECT COUNT(*) FROM tblSupplier WHERE SupplierName = @SupplierName AND SupplierId <> @SupplierId AND IsActive = 1;", conn, tx))
                {
                    dup.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);
                    dup.Parameters.AddWithValue("@SupplierId", supplier.SupplierId);
                    if (Convert.ToInt32(dup.ExecuteScalar()) > 0)
                        throw new InvalidOperationException($"Supplier '{supplier.SupplierName}' already exists.");
                }

                using (var cmd = new SqlCommand(@"
                    UPDATE tblSupplier
                    SET SupplierName = @SupplierName,
                        Address = @Address,
                        ContactPerson = @ContactPerson,
                        PhoneNumber = @PhoneNumber,
                        EmailAddress = @EmailAddress
                    WHERE SupplierId = @SupplierId AND IsActive = 1;", conn, tx))
                {
                    cmd.Parameters.AddWithValue("@SupplierId", supplier.SupplierId);
                    cmd.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);
                    cmd.Parameters.AddWithValue("@Address", supplier.Address ?? string.Empty);
                    cmd.Parameters.AddWithValue("@ContactPerson", supplier.ContactPerson ?? string.Empty);
                    cmd.Parameters.AddWithValue("@PhoneNumber", supplier.PhoneNumber ?? string.Empty);
                    cmd.Parameters.AddWithValue("@EmailAddress", supplier.EmailAddress ?? string.Empty);
                    cmd.ExecuteNonQuery();
                }

                if (oldName != supplier.SupplierName)
                {
                    using var products = new SqlCommand(
                        "UPDATE tblProduct SET Supplier = @NewName WHERE Supplier = @OldName;", conn, tx);
                    products.Parameters.AddWithValue("@NewName", supplier.SupplierName);
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

        public void DeleteSupplier(string supplierId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                "UPDATE tblSupplier SET IsActive = 0 WHERE SupplierId = @SupplierId;", conn))
            {
                cmd.Parameters.AddWithValue("@SupplierId", supplierId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<SupplierModel> GetAll()
        {
            var suppliers = new List<SupplierModel>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT SupplierId, SupplierName, Address, ContactPerson, PhoneNumber, EmailAddress
                FROM tblSupplier
                WHERE IsActive = 1
                ORDER BY SupplierName ASC;", conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        suppliers.Add(new SupplierModel
                        {
                            SupplierId = reader["SupplierId"].ToString(),
                            SupplierName = reader["SupplierName"].ToString(),
                            Address = reader["Address"]?.ToString(),
                            ContactPerson = reader["ContactPerson"]?.ToString(),
                            PhoneNumber = reader["PhoneNumber"]?.ToString(),
                            EmailAddress = reader["EmailAddress"]?.ToString()
                        });
                    }
                }
            }
            return suppliers;
        }
    }
}
