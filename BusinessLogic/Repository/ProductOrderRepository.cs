using Microsoft.Data.SqlClient;
using Model;


namespace BusinessLogic.Repository
{
    public class ProductOrderRepository
    {
        private readonly string connectionString =
            "Server=DESKTOP-SMD1DHH;Initial Catalog=SALESINVENTORY;Trusted_Connection=True;TrustServerCertificate=True;";

        public void AddOrUpdate(OrderProductModel order)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string checkQuery = "SELECT COUNT(*) FROM tblOrderProduct WHERE ProductName = @ProductName";
                using (var checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@ProductName", order.ItemName);
                    int exists = (int)checkCmd.ExecuteScalar();

                    if (exists > 0)
                    {
                        string updateQuery = @"UPDATE tblOrderProduct
                                               SET Quantity = Quantity + @Quantity
                                               WHERE ProductName = @ProductName";
                        using (var updateCmd = new SqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@Quantity", order.Quantity);
                            updateCmd.Parameters.AddWithValue("@ProductName", order.ItemName);
                            updateCmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        string insertQuery = @"INSERT INTO tblOrderProduct (ProductName, Quantity, UnitPrice)
                                               VALUES (@ProductName, @Quantity, @UnitPrice)";
                        using (var insertCmd = new SqlCommand(insertQuery, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@ProductName", order.ItemName);
                            insertCmd.Parameters.AddWithValue("@Quantity", order.Quantity);
                            insertCmd.Parameters.AddWithValue("@UnitPrice", order.Price);
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        public List<OrderProductModel> GetAll()
        {
            var orders = new List<OrderProductModel>();

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ProductName, Quantity, UnitPrice FROM tblOrderProduct ORDER BY OrderId DESC";
                using (var cmd = new SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        orders.Add(new OrderProductModel
                        {
                            ItemName = reader["ProductName"].ToString(),
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            Price = Convert.ToDecimal(reader["UnitPrice"])
                        });
                    }
                }
            }

            return orders;
        }

        public void Delete(string productName)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string getQty = "SELECT Quantity FROM tblOrderProduct WHERE ProductName = @ProductName";
                using (var checkCmd = new SqlCommand(getQty, conn))
                {
                    checkCmd.Parameters.AddWithValue("@ProductName", productName);
                    object result = checkCmd.ExecuteScalar();

                    if (result == null)
                        return;

                    int qty = Convert.ToInt32(result);

                    if (qty > 1)
                    {
                        string update = @"UPDATE tblOrderProduct 
                                  SET Quantity = Quantity - 1 
                                  WHERE ProductName = @ProductName";

                        using (var updateCmd = new SqlCommand(update, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@ProductName", productName);
                            updateCmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        string delete = @"DELETE FROM tblOrderProduct 
                                  WHERE ProductName = @ProductName";

                        using (var delCmd = new SqlCommand(delete, conn))
                        {
                            delCmd.Parameters.AddWithValue("@ProductName", productName);
                            delCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }


        public void ClearAll()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM tblOrderProduct";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }




        public List<ProductDetailsModel> SearchByProductName(string productName)
        {
            var products = new List<ProductDetailsModel>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(@"
        SELECT ProductId, ProductName, Category, Supplier, Quantity, Amount
        FROM Product
        WHERE ProductName LIKE @ProductName
        ORDER BY ProductName ASC", conn))
            {
                cmd.Parameters.AddWithValue("@ProductName", "%" + productName + "%");
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
        public List<ProductDetailsModel> GetProductsOrderedByStock()
        {
            var products = new List<ProductDetailsModel>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(@"
        SELECT ProductId, ProductName, Category, Supplier, Quantity, Amount
        FROM Product
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
                            Category = reader["Category"]?.ToString(),
                            Supplier = reader["Supplier"]?.ToString(),
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            Amount = Convert.ToDecimal(reader["Amount"])
                        });
                    }
                }
            }
            return products;






        }
    }
}
