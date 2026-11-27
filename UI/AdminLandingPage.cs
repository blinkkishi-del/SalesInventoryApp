using FontAwesome.Sharp;
using Model;
using System.Runtime.InteropServices;
namespace UI
{
    public partial class AdminLandingPage : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        internal UserModel UserSession;
        public AdminLandingPage()
        {
            InitializeComponent();

        }

        private void btnProduct_Click(object sender, EventArgs e) { }
        private void btnStock_Click(object sender, EventArgs e) { }
        private void btnRecord_Click(object sender, EventArgs e) { }
        private void btnSettings_Click(object sender, EventArgs e) { }

   

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {

        }

        private void btnBrand_Click(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {

        }

        private void btnStockEntry_Click(object sender, EventArgs e)
        {

        }

        private void btnStockAdjustment_Click(object sender, EventArgs e)
        {

        }

        private void btnPOSRecord_Click(object sender, EventArgs e)
        {

        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {

        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void OpenReorder(string productId, string supplierName)
        {
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
         
        }

      

        private void btnMaximize_Click(object sender, EventArgs e)
        {
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
        }

        private void AdminLandingPage_Load(object sender, EventArgs e)
        {
        }
    }
}

