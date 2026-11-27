using Microsoft.Data.SqlClient;
using Model;
using System.Data;

namespace BusinessLogic.Repository
{
    internal class ProductRepository
    {
        private readonly string connectionString =
                        "Server=DESKTOP-SMD1DHH;Initial Catalog=SALESINVENTORY;Trusted_Connection=True;TrustServerCertificate=True;";

        public string AddProduct(ProductDetailsModel product)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("AddProduct", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                cmd.Parameters.AddWithValue("@Model", (object)product.Model ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Brand", (object)product.Brand ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Category", product.Category);
                cmd.Parameters.AddWithValue("@Supplier", product.Supplier);
                cmd.Parameters.AddWithValue("@Quantity", product.Quantity);
                cmd.Parameters.AddWithValue("@Amount", product.Amount);
                conn.Open();
                return cmd.ExecuteScalar()?.ToString() ?? "";
            }
        }

        public string GetNextProductId()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT 'APP-' + FORMAT(1 + ISNULL(MAX(TRY_CAST(SUBSTRING(ProductId, 5, 16) AS INT)), 0), '000')
                FROM tblProduct WHERE ProductId LIKE 'APP-%';", conn))
            {
                conn.Open();
                return cmd.ExecuteScalar()?.ToString() ?? "";
            }
        }

        public void UpdateProduct(ProductDetailsModel product)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UpProduct", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@ProductId", product.ProductId);
                cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                cmd.Parameters.AddWithValue("@Model", (object)product.Model ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Brand", (object)product.Brand ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Category", product.Category);
                cmd.Parameters.AddWithValue("@Supplier", product.Supplier);
                cmd.Parameters.AddWithValue("@Quantity", DBNull.Value);
                cmd.Parameters.AddWithValue("@Amount", product.Amount);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<ProductDetailsModel> GetAll()
        {
            var products = new List<ProductDetailsModel>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("GetTop50Products", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new ProductDetailsModel
                        {
                            ProductId = reader["ProductId"].ToString(),
                            ProductName = reader["ProductName"].ToString(),
                            Model = reader["Model"]?.ToString(),
                            Brand = reader["Brand"]?.ToString(),
                            Category = reader["Category"]?.ToString(),
                            Supplier = reader["Supplier"]?.ToString(),
                            Quantity = reader["Quantity"] is DBNull ? 0 : Convert.ToInt32(reader["Quantity"]),
                            Amount = reader["Amount"] is DBNull ? 0 : Convert.ToDecimal(reader["Amount"])
                        });
                    }
                }
            }
            return products;
        }

        public List<ProductDetailsModel> SearchProducts(string keyword)
        {
            var products = new List<ProductDetailsModel>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("ss_SearchProducts", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Keyword", keyword ?? string.Empty);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new ProductDetailsModel
                        {
                            ProductId = reader["ProductId"].ToString(),
                            ProductName = reader["ProductName"].ToString(),
                            Model = reader["Model"]?.ToString(),
                            Brand = reader["Brand"]?.ToString(),
                            Category = reader["Category"]?.ToString(),
                            Supplier = reader["Supplier"]?.ToString(),
                            Quantity = reader["Quantity"] is DBNull ? 0 : Convert.ToInt32(reader["Quantity"]),
                            Amount = reader["Amount"] is DBNull ? 0 : Convert.ToDecimal(reader["Amount"])
                        });
                    }
                }
            }
            return products;
        }

        public List<ProductDetailsModel> GetProductsOrderedByStock()
        {
            var products = new List<ProductDetailsModel>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT ProductId, ProductName, Model, Brand, Category, Supplier, Quantity, Amount
                FROM tblProduct
                WHERE IsActive = 1
                ORDER BY
                    CASE WHEN Quantity <= 0 THEN 1 ELSE 0 END,
                    ProductName ASC", conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new ProductDetailsModel
                        {
                            ProductId = reader["ProductId"].ToString(),
                            ProductName = reader["ProductName"].ToString(),
                            Model = reader["Model"]?.ToString(),
                            Brand = reader["Brand"]?.ToString(),
                            Category = reader["Category"]?.ToString(),
                            Supplier = reader["Supplier"]?.ToString(),
                            Quantity = reader["Quantity"] is DBNull ? 0 : Convert.ToInt32(reader["Quantity"]),
                            Amount = reader["Amount"] is DBNull ? 0 : Convert.ToDecimal(reader["Amount"])
                        });
                    }
                }
            }
            return products;
        }

        public int GetTotalInventory()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                "SELECT ISNULL(SUM(Quantity), 0) FROM tblProduct WHERE IsActive = 1", conn))
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                return (result != DBNull.Value) ? Convert.ToInt32(result) : 0;
            }
        }

        public List<ProductDetailsModel> GetLowStockProducts(int threshold = 10)
        {
            var products = new List<ProductDetailsModel>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT ProductId, ProductName, Model, Brand, Category, Supplier, Quantity, Amount
                FROM tblProduct
                WHERE IsActive = 1 AND Quantity <= @Threshold
                ORDER BY Quantity ASC", conn))
            {
                cmd.Parameters.AddWithValue("@Threshold", threshold);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new ProductDetailsModel
                        {
                            ProductId = reader["ProductId"].ToString(),
                            ProductName = reader["ProductName"].ToString(),
                            Model = reader["Model"]?.ToString(),
                            Brand = reader["Brand"]?.ToString(),
                            Category = reader["Category"]?.ToString(),
                            Supplier = reader["Supplier"]?.ToString(),
                            Quantity = reader["Quantity"] is DBNull ? 0 : Convert.ToInt32(reader["Quantity"]),
                            Amount = reader["Amount"] is DBNull ? 0 : Convert.ToDecimal(reader["Amount"])
                        });
                    }
                }
            }
            return products;
        }
    }
}
