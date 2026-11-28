using Microsoft.Data.SqlClient;
using Model;

namespace BusinessLogic.Repository
{
    public class ProductOrderRepository
    {
        private readonly string connectionString =
        "Server=KHARL2005\\SQLEXPRESS02;Initial Catalog=SALESINVENTORY;Trusted_Connection=True;TrustServerCertificate=True;";

        public void AddOrUpdate(OrderProductModel order, string cashier)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string checkQuery = "SELECT COUNT(*) FROM tblOrderProduct WHERE ProductName = @ProductName AND CashierUsername = @Cashier";
                using (var checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@ProductName", order.ItemName);
                    checkCmd.Parameters.AddWithValue("@Cashier", cashier);
                    int exists = (int)checkCmd.ExecuteScalar();

                    if (exists > 0)
                    {
                        string updateQuery = @"UPDATE tblOrderProduct
                                               SET Quantity = Quantity + @Quantity
                                               WHERE ProductName = @ProductName AND CashierUsername = @Cashier";
                        using (var updateCmd = new SqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@Quantity", order.Quantity);
                            updateCmd.Parameters.AddWithValue("@ProductName", order.ItemName);
                            updateCmd.Parameters.AddWithValue("@Cashier", cashier);
                            updateCmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        string insertQuery = @"INSERT INTO tblOrderProduct (ProductName, Quantity, UnitPrice, CashierUsername)
                                               VALUES (@ProductName, @Quantity, @UnitPrice, @Cashier)";
                        using (var insertCmd = new SqlCommand(insertQuery, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@ProductName", order.ItemName);
                            insertCmd.Parameters.AddWithValue("@Quantity", order.Quantity);
                            insertCmd.Parameters.AddWithValue("@UnitPrice", order.Price);
                            insertCmd.Parameters.AddWithValue("@Cashier", cashier);
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        public List<OrderProductModel> GetAll(string cashier)
        {
            var orders = new List<OrderProductModel>();
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT ProductName, Quantity, UnitPrice, DiscountPercent FROM tblOrderProduct
                                 WHERE CashierUsername = @Cashier ORDER BY OrderId DESC";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Cashier", cashier);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            orders.Add(new OrderProductModel
                            {
                                ItemName = reader["ProductName"].ToString(),
                                Quantity = Convert.ToInt32(reader["Quantity"]),
                                Price = Convert.ToDecimal(reader["UnitPrice"]),
                                DiscountPercent = Convert.ToDecimal(reader["DiscountPercent"])
                            });
                        }
                    }
                }
            }
            return orders;
        }

        public void SetDiscount(string productName, decimal discountPercent, string cashier)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(
                "UPDATE tblOrderProduct SET DiscountPercent = @Percent WHERE ProductName = @ProductName AND CashierUsername = @Cashier", conn))
            {
                cmd.Parameters.AddWithValue("@Percent", discountPercent);
                cmd.Parameters.AddWithValue("@ProductName", productName);
                cmd.Parameters.AddWithValue("@Cashier", cashier);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(string productName, string cashier)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string getQty = "SELECT Quantity FROM tblOrderProduct WHERE ProductName = @ProductName AND CashierUsername = @Cashier";
                using (var checkCmd = new SqlCommand(getQty, conn))
                {
                    checkCmd.Parameters.AddWithValue("@ProductName", productName);
                    checkCmd.Parameters.AddWithValue("@Cashier", cashier);
                    object result = checkCmd.ExecuteScalar();

                    if (result == null) return;

                    int qty = Convert.ToInt32(result);

                    if (qty > 1)
                    {
                        string update = @"UPDATE tblOrderProduct
                                          SET Quantity = Quantity - 1
                                          WHERE ProductName = @ProductName AND CashierUsername = @Cashier";
                        using (var updateCmd = new SqlCommand(update, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@ProductName", productName);
                            updateCmd.Parameters.AddWithValue("@Cashier", cashier);
                            updateCmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        string delete = @"DELETE FROM tblOrderProduct
                                          WHERE ProductName = @ProductName AND CashierUsername = @Cashier";
                        using (var delCmd = new SqlCommand(delete, conn))
                        {
                            delCmd.Parameters.AddWithValue("@ProductName", productName);
                            delCmd.Parameters.AddWithValue("@Cashier", cashier);
                            delCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        public void ClearAll(string cashier)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("DELETE FROM tblOrderProduct WHERE CashierUsername = @Cashier", conn))
            {
                cmd.Parameters.AddWithValue("@Cashier", cashier);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
