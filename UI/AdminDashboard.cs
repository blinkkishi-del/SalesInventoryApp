using Microsoft.VisualBasic.ApplicationServices;
using Model;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UI
{
    public partial class AdminDashboard : Form
    {
        UserModel UserSession;
        public AdminDashboard()
        {
            InitializeComponent();
            UserSession = new UserModel();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                UserSession.Clear();

                Login login = new Login();
                login.Show();

                this.Close();
            }
        }

        private void btnInvmanage_Click(object sender, EventArgs e)
        {
            InventoryManagement inventoryManagementForm = new InventoryManagement();
            this.Hide();
            inventoryManagementForm.Show();
        }
    }
}
