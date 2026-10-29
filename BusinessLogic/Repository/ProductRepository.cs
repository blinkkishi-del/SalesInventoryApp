using Microsoft.Data.SqlClient;
using Model;
using System.Data;

namespace BusinessLogic.Repository
{
    internal class ProductRepository
    {
        private readonly string connectionString =
        "Server=DESKTOP-SMD1DHH;Initial Catalog=SALESINVENTORY;Trusted_Connection=True;TrustServerCertificate=True;";

        public void AddProduct(ProductDetailsModel product)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("AddProduct", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                cmd.Parameters.AddWithValue("@Category", product.Category);
                cmd.Parameters.AddWithValue("@Supplier", product.Supplier);
                cmd.Parameters.AddWithValue("@Quantity", product.Quantity);
                cmd.Parameters.AddWithValue("@Amount", product.Amount);

                conn.Open();
                cmd.ExecuteNonQuery();
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
                cmd.Parameters.AddWithValue("@Category", product.Category);
                cmd.Parameters.AddWithValue("@Supplier", product.Supplier);
                cmd.Parameters.AddWithValue("@Quantity", product.Quantity);
                cmd.Parameters.AddWithValue("@Amount", product.Amount);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

        }

        public void DeleteProduct(string productId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DelProduct", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@ProductId", productId);

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
                        var product = new ProductDetailsModel
                        {
                            ProductId = reader["ProductId"].ToString(),
                            ProductName = reader["ProductName"].ToString(),
                            Category = reader["Category"]?.ToString(),
                            Supplier = reader["Supplier"]?.ToString(),
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            Amount = Convert.ToDecimal(reader["Amount"])
                        };

                        products.Add(product);
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
                        var product = new ProductDetailsModel
                        {
                            ProductId = reader["ProductId"].ToString(),
                            ProductName = reader["ProductName"].ToString(),
                            Category = reader["Category"]?.ToString(),
                            Supplier = reader["Supplier"]?.ToString(),
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            Amount = Convert.ToDecimal(reader["Amount"])
                        };

                        products.Add(product);
                    }
                }
            }

            return products;
        }

    }
}
