using BusinessLogic.Controller;
using Model;
using System.Runtime.InteropServices;

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
                        AdminLandingPage db = new AdminLandingPage();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

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


