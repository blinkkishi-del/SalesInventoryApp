using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class Login : Form
    {

        private UserController userController;


        public Login()
        {
            InitializeComponent();
            userController = new UserController();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                if (password.Length < 6)
                {
                    MessageBox.Show("Password must be at least 6 characters!",
                        "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                UserModel user = userController.Login(username, password);

                if (user != null)
                {
                    MessageBox.Show($"Welcome {user.Username}! Role: {user.Role}",
                        "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (user.Role == "Admin")
                    {
                        AdminDashboard db = new AdminDashboard();
                        db.Show();
                        this.Hide();
                    }
                    else if (user.Role == "Cashier")
                    {
                        CashierDashboard cashierForm = new CashierDashboard();
                        cashierForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!",
                        "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


