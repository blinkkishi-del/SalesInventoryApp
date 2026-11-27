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

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            btnMaximize.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text;

                UserModel user = userController.Login(username, password);

                if (user != null)
                {
                    MessageBox.Show($"Welcome {user.Username}! Role: {user.Role}",
                        "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (user.Role == "Admin")
                    {
                        AdminLandingPage db = new AdminLandingPage();
                        db.UserSession = user;
                        db.Show();
                        this.Hide();
                    }
                    else if (user.Role == "Cashier")
                    {
                        CashierLandingPage cashierForm = new CashierLandingPage();
                        cashierForm.UserSession = user;
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
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}

