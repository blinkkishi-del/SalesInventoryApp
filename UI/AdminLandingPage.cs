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

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 48);
            panelMenu.Controls.Add(leftBorderBtn);
            HideSubmenus();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            UserSession = new UserModel();
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(24, 161, 251);
            public static Color color5 = Color.FromArgb(111, 207, 151);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;
                if (currentBtn.Parent == panelMenu)
                {
                    currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                    currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                    currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                }

                leftBorderBtn.BackColor = color;
                UpdateLeftBorder();

                iconCurrentChildIcon.IconChar = currentBtn.IconChar;
                iconCurrentChildIcon.IconColor = color;
            }
        }

        private void UpdateLeftBorder()
        {
            if (currentBtn == null || !currentBtn.Parent.Visible)
            {
                leftBorderBtn.Visible = false;
                return;
            }
            panelMenu.PerformLayout();
            Point pos = panelMenu.PointToClient(currentBtn.Parent.PointToScreen(currentBtn.Location));
            leftBorderBtn.Size = new Size(7, currentBtn.Height);
            leftBorderBtn.Location = new Point(0, pos.Y);
            leftBorderBtn.Visible = true;
            leftBorderBtn.BringToFront();
        }

        private void HideSubmenus()
        {
            panelSubProduct.Visible = false;
            panelSubStock.Visible = false;
            panelSubRecord.Visible = false;
            panelSubSetting.Visible = false;
        }

        private void ShowSubmenu(Panel submenu)
        {
            bool open = !submenu.Visible;
            HideSubmenus();
            submenu.Visible = open;
            UpdateLeftBorder();
        }

        private void btnProduct_Click(object sender, EventArgs e) => ShowSubmenu(panelSubProduct);
        private void btnStock_Click(object sender, EventArgs e) => ShowSubmenu(panelSubStock);
        private void btnRecord_Click(object sender, EventArgs e) => ShowSubmenu(panelSubRecord);
        private void btnSettings_Click(object sender, EventArgs e) => ShowSubmenu(panelSubSetting);

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
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

        private void btnInventory_Click(object sender, EventArgs e)
        {
            if (currentBtn == sender) return;
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new InventoryManagement());
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            if (currentBtn == sender) return;
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new CategoryManagement());
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            if (currentBtn == sender) return;
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new BrandManagement());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            if (currentBtn == sender) return;
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new UserManagement(UserSession));
        }

        private void btnStockEntry_Click(object sender, EventArgs e)
        {
            if (currentBtn == sender) return;
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new StockEntry(UserSession?.Username));
        }

        private void btnStockAdjustment_Click(object sender, EventArgs e)
        {
            if (currentBtn == sender) return;
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new StockAdjustment(UserSession?.Username));
        }

        private void btnPOSRecord_Click(object sender, EventArgs e)
        {
            if (currentBtn == sender) return;
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new POSRecord());
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            if (currentBtn == sender) return;
            HideSubmenus();
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new SupplierManagement());
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            if (currentBtn == sender) return;
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new SalesReport());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (currentBtn == sender) return;
            HideSubmenus();
            ActivateButton(sender, RGBColors.color1);
            var dash = new AdminDashboard();
            dash.CurrentUser = UserSession;
            dash.ReorderRequested = OpenReorder;
            OpenChildForm(dash);
        }

        private void OpenReorder(string productId, string supplierName)
        {
            HideSubmenus();
            panelSubStock.Visible = true;
            ActivateButton(btnStockEntry, RGBColors.color4);
            OpenChildForm(new StockEntry(UserSession?.Username, productId, supplierName));
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMenuForm.Controls.Add(childForm);
            panelMenuForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChild.Text = childForm.Text;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if ((this.WindowState) == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void AdminLandingPage_Load(object sender, EventArgs e)
        {
            btnDashboard_Click(btnDashboard, EventArgs.Empty);
        }
    }
}

