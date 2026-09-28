using Model;
using Microsoft.Data.SqlClient;

namespace BusinessLogic.Repository
{
    public class UserRepository
    {
        private string CONNECTIONSTRING =
                  "Server=DESKTOP-SMD1DHH;Initial Catalog=SALESINVENTORY;Trusted_Connection=True;TrustServerCertificate=True;"; 
       
        public UserModel ValidateUser(string username, string password)
        {
            UserModel user = null; 

            using (SqlConnection connection = new SqlConnection(CONNECTIONSTRING)) 
            {
                string query = "SELECT Username, Password, Role FROM tblUsers WHERE Username = @Username AND Password = @Password";

                SqlCommand command = new SqlCommand(query, connection); 

                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password); 

                connection.Open(); 
                SqlDataReader reader = command.ExecuteReader(); 

             
                if (reader.Read()) 
                {
                    user = new UserModel 
                    {
                        Username = reader["Username"].ToString(), 
                        Password = reader["Password"].ToString(), 
                        Role = reader["Role"].ToString() 
                    };
                }
            }

            return user;
        }


    }
}
