namespace UI
{
    partial class AdminLandingPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLandingPage));
            panelMenu = new Panel();
            btnLogout = new FontAwesome.Sharp.IconButton();
            panelSubSetting = new Panel();
            btnUser = new FontAwesome.Sharp.IconButton();
            btnSettings = new FontAwesome.Sharp.IconButton();
            panelSubRecord = new Panel();
            btnPOSRecord = new FontAwesome.Sharp.IconButton();
            btnSalesReport = new FontAwesome.Sharp.IconButton();
            btnRecord = new FontAwesome.Sharp.IconButton();
            btnSupplier = new FontAwesome.Sharp.IconButton();
            panelSubStock = new Panel();
            btnStockAdjustment = new FontAwesome.Sharp.IconButton();
            btnStockEntry = new FontAwesome.Sharp.IconButton();
            btnStock = new FontAwesome.Sharp.IconButton();
            panelSubProduct = new Panel();
            btnBrand = new FontAwesome.Sharp.IconButton();
            btnCategory = new FontAwesome.Sharp.IconButton();
            btnInventory = new FontAwesome.Sharp.IconButton();
            btnProduct = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            picture_Logo = new PictureBox();
            panelTitleBar = new Panel();
            panel1 = new Panel();
            btnExit = new FontAwesome.Sharp.IconButton();
            btnMaximize = new FontAwesome.Sharp.IconButton();
            btnMinimize = new FontAwesome.Sharp.IconButton();
            lblTitleChild = new Label();
            iconCurrentChildIcon = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
            panelMenuForm = new Panel();
            panelMenu.SuspendLayout();
            panelSubSetting.SuspendLayout();
            panelSubRecord.SuspendLayout();
            panelSubStock.SuspendLayout();
            panelSubProduct.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_Logo).BeginInit();
            panelTitleBar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildIcon).BeginInit();
            SuspendLayout();
            //
            // panelMenu
            //
            panelMenu.BackColor = Color.FromArgb(26, 25, 62);
            panelMenu.Controls.Add(panelSubSetting);
            panelMenu.Controls.Add(btnSettings);
            panelMenu.Controls.Add(panelSubRecord);
            panelMenu.Controls.Add(btnRecord);
            panelMenu.Controls.Add(btnSupplier);
            panelMenu.Controls.Add(panelSubStock);
            panelMenu.Controls.Add(btnStock);
            panelMenu.Controls.Add(panelSubProduct);
            panelMenu.Controls.Add(btnProduct);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 664);
            panelMenu.TabIndex = 15;
            //
            // btnLogout
            //
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Arial Black", 8F, FontStyle.Bold);
            btnLogout.ForeColor = Color.Gray;
            btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            btnLogout.IconColor = Color.White;
            btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogout.IconSize = 28;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 616);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(10, 0, 20, 0);
            btnLogout.Size = new Size(200, 48);
            btnLogout.TabIndex = 20;
            btnLogout.Text = "Log Out";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            //
            // btnDashboard
            //
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Arial Black", 10F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.Gainsboro;
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            btnDashboard.IconColor = Color.White;
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.IconSize = 28;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 158);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 20, 0);
            btnDashboard.Size = new Size(200, 48);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            //
            // btnProduct
            //
            btnProduct.Dock = DockStyle.Top;
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.Font = new Font("Arial Black", 10F, FontStyle.Bold);
            btnProduct.ForeColor = Color.Gainsboro;
            btnProduct.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            btnProduct.IconColor = Color.White;
            btnProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProduct.IconSize = 28;
            btnProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduct.Location = new Point(0, 206);
            btnProduct.Name = "btnProduct";
            btnProduct.Padding = new Padding(10, 0, 20, 0);
            btnProduct.Size = new Size(200, 48);
            btnProduct.TabIndex = 2;
            btnProduct.Text = "Product";
            btnProduct.TextAlign = ContentAlignment.MiddleLeft;
            btnProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            //
            // panelSubProduct
            //
            panelSubProduct.BackColor = Color.FromArgb(31, 30, 68);
            panelSubProduct.Controls.Add(btnBrand);
            panelSubProduct.Controls.Add(btnCategory);
            panelSubProduct.Controls.Add(btnInventory);
            panelSubProduct.Dock = DockStyle.Top;
            panelSubProduct.Location = new Point(0, 254);
            panelSubProduct.Name = "panelSubProduct";
            panelSubProduct.Size = new Size(200, 120);
            panelSubProduct.TabIndex = 3;
            //
            // btnInventory
            //
            btnInventory.BackColor = Color.FromArgb(31, 30, 68);
            btnInventory.Dock = DockStyle.Top;
            btnInventory.FlatAppearance.BorderSize = 0;
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnInventory.ForeColor = Color.Gainsboro;
            btnInventory.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            btnInventory.IconColor = Color.Gainsboro;
            btnInventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInventory.IconSize = 22;
            btnInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventory.Location = new Point(0, 0);
            btnInventory.Name = "btnInventory";
            btnInventory.Padding = new Padding(24, 0, 4, 0);
            btnInventory.Size = new Size(200, 40);
            btnInventory.TabIndex = 0;
            btnInventory.Text = "Product Management";
            btnInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnInventory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            //
            // btnCategory
            //
            btnCategory.BackColor = Color.FromArgb(31, 30, 68);
            btnCategory.Dock = DockStyle.Top;
            btnCategory.FlatAppearance.BorderSize = 0;
            btnCategory.FlatStyle = FlatStyle.Flat;
            btnCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCategory.ForeColor = Color.Gainsboro;
            btnCategory.IconChar = FontAwesome.Sharp.IconChar.Tags;
            btnCategory.IconColor = Color.Gainsboro;
            btnCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCategory.IconSize = 22;
            btnCategory.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategory.Location = new Point(0, 40);
            btnCategory.Name = "btnCategory";
            btnCategory.Padding = new Padding(24, 0, 4, 0);
            btnCategory.Size = new Size(200, 40);
            btnCategory.TabIndex = 1;
            btnCategory.Text = "Category";
            btnCategory.TextAlign = ContentAlignment.MiddleLeft;
            btnCategory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCategory.UseVisualStyleBackColor = false;
            btnCategory.Click += btnCategory_Click;
            //
            // btnBrand
            //
            btnBrand.BackColor = Color.FromArgb(31, 30, 68);
            btnBrand.Dock = DockStyle.Top;
            btnBrand.FlatAppearance.BorderSize = 0;
            btnBrand.FlatStyle = FlatStyle.Flat;
            btnBrand.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBrand.ForeColor = Color.Gainsboro;
            btnBrand.IconChar = FontAwesome.Sharp.IconChar.Copyright;
            btnBrand.IconColor = Color.Gainsboro;
            btnBrand.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBrand.IconSize = 22;
            btnBrand.ImageAlign = ContentAlignment.MiddleLeft;
            btnBrand.Location = new Point(0, 80);
            btnBrand.Name = "btnBrand";
            btnBrand.Padding = new Padding(24, 0, 4, 0);
            btnBrand.Size = new Size(200, 40);
            btnBrand.TabIndex = 2;
            btnBrand.Text = "Brand";
            btnBrand.TextAlign = ContentAlignment.MiddleLeft;
            btnBrand.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBrand.UseVisualStyleBackColor = false;
            btnBrand.Click += btnBrand_Click;
            //
            // btnStock
            //
            btnStock.Dock = DockStyle.Top;
            btnStock.FlatAppearance.BorderSize = 0;
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Font = new Font("Arial Black", 10F, FontStyle.Bold);
            btnStock.ForeColor = Color.Gainsboro;
            btnStock.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            btnStock.IconColor = Color.White;
            btnStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStock.IconSize = 28;
            btnStock.ImageAlign = ContentAlignment.MiddleLeft;
            btnStock.Location = new Point(0, 374);
            btnStock.Name = "btnStock";
            btnStock.Padding = new Padding(10, 0, 20, 0);
            btnStock.Size = new Size(200, 48);
            btnStock.TabIndex = 4;
            btnStock.Text = "Stock";
            btnStock.TextAlign = ContentAlignment.MiddleLeft;
            btnStock.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += btnStock_Click;
            //
            // panelSubStock
            //
            panelSubStock.BackColor = Color.FromArgb(31, 30, 68);
            panelSubStock.Controls.Add(btnStockAdjustment);
            panelSubStock.Controls.Add(btnStockEntry);
            panelSubStock.Dock = DockStyle.Top;
            panelSubStock.Location = new Point(0, 422);
            panelSubStock.Name = "panelSubStock";
            panelSubStock.Size = new Size(200, 80);
            panelSubStock.TabIndex = 5;
            //
            // btnStockEntry
            //
            btnStockEntry.BackColor = Color.FromArgb(31, 30, 68);
            btnStockEntry.Dock = DockStyle.Top;
            btnStockEntry.FlatAppearance.BorderSize = 0;
            btnStockEntry.FlatStyle = FlatStyle.Flat;
            btnStockEntry.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnStockEntry.ForeColor = Color.Gainsboro;
            btnStockEntry.IconChar = FontAwesome.Sharp.IconChar.TruckRampBox;
            btnStockEntry.IconColor = Color.Gainsboro;
            btnStockEntry.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStockEntry.IconSize = 22;
            btnStockEntry.ImageAlign = ContentAlignment.MiddleLeft;
            btnStockEntry.Location = new Point(0, 0);
            btnStockEntry.Name = "btnStockEntry";
            btnStockEntry.Padding = new Padding(24, 0, 4, 0);
            btnStockEntry.Size = new Size(200, 40);
            btnStockEntry.TabIndex = 0;
            btnStockEntry.Text = "Stock Entry";
            btnStockEntry.TextAlign = ContentAlignment.MiddleLeft;
            btnStockEntry.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStockEntry.UseVisualStyleBackColor = false;
            btnStockEntry.Click += btnStockEntry_Click;
            //
            // btnStockAdjustment
            //
            btnStockAdjustment.BackColor = Color.FromArgb(31, 30, 68);
            btnStockAdjustment.Dock = DockStyle.Top;
            btnStockAdjustment.FlatAppearance.BorderSize = 0;
            btnStockAdjustment.FlatStyle = FlatStyle.Flat;
            btnStockAdjustment.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnStockAdjustment.ForeColor = Color.Gainsboro;
            btnStockAdjustment.IconChar = FontAwesome.Sharp.IconChar.SlidersH;
            btnStockAdjustment.IconColor = Color.Gainsboro;
            btnStockAdjustment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStockAdjustment.IconSize = 22;
            btnStockAdjustment.ImageAlign = ContentAlignment.MiddleLeft;
            btnStockAdjustment.Location = new Point(0, 40);
            btnStockAdjustment.Name = "btnStockAdjustment";
            btnStockAdjustment.Padding = new Padding(24, 0, 4, 0);
            btnStockAdjustment.Size = new Size(200, 40);
            btnStockAdjustment.TabIndex = 1;
            btnStockAdjustment.Text = "Stock Adjustment";
            btnStockAdjustment.TextAlign = ContentAlignment.MiddleLeft;
            btnStockAdjustment.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStockAdjustment.UseVisualStyleBackColor = false;
            btnStockAdjustment.Click += btnStockAdjustment_Click;
            //
            // btnSupplier
            //
            btnSupplier.Dock = DockStyle.Top;
            btnSupplier.FlatAppearance.BorderSize = 0;
            btnSupplier.FlatStyle = FlatStyle.Flat;
            btnSupplier.Font = new Font("Arial Black", 10F, FontStyle.Bold);
            btnSupplier.ForeColor = Color.Gainsboro;
            btnSupplier.IconChar = FontAwesome.Sharp.IconChar.Truck;
            btnSupplier.IconColor = Color.White;
            btnSupplier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSupplier.IconSize = 28;
            btnSupplier.ImageAlign = ContentAlignment.MiddleLeft;
            btnSupplier.Location = new Point(0, 502);
            btnSupplier.Name = "btnSupplier";
            btnSupplier.Padding = new Padding(10, 0, 20, 0);
            btnSupplier.Size = new Size(200, 48);
            btnSupplier.TabIndex = 6;
            btnSupplier.Text = "Supplier";
            btnSupplier.TextAlign = ContentAlignment.MiddleLeft;
            btnSupplier.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSupplier.UseVisualStyleBackColor = true;
            btnSupplier.Click += btnSupplier_Click;
            //
            // btnRecord
            //
            btnRecord.Dock = DockStyle.Top;
            btnRecord.FlatAppearance.BorderSize = 0;
            btnRecord.FlatStyle = FlatStyle.Flat;
            btnRecord.Font = new Font("Arial Black", 10F, FontStyle.Bold);
            btnRecord.ForeColor = Color.Gainsboro;
            btnRecord.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            btnRecord.IconColor = Color.White;
            btnRecord.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRecord.IconSize = 28;
            btnRecord.ImageAlign = ContentAlignment.MiddleLeft;
            btnRecord.Location = new Point(0, 550);
            btnRecord.Name = "btnRecord";
            btnRecord.Padding = new Padding(10, 0, 20, 0);
            btnRecord.Size = new Size(200, 48);
            btnRecord.TabIndex = 7;
            btnRecord.Text = "Record";
            btnRecord.TextAlign = ContentAlignment.MiddleLeft;
            btnRecord.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRecord.UseVisualStyleBackColor = true;
            btnRecord.Click += btnRecord_Click;
            //
            // panelSubRecord
            //
            panelSubRecord.BackColor = Color.FromArgb(31, 30, 68);
            panelSubRecord.Controls.Add(btnPOSRecord);
            panelSubRecord.Controls.Add(btnSalesReport);
            panelSubRecord.Dock = DockStyle.Top;
            panelSubRecord.Location = new Point(0, 598);
            panelSubRecord.Name = "panelSubRecord";
            panelSubRecord.Size = new Size(200, 80);
            panelSubRecord.TabIndex = 8;
            //
            // btnSalesReport
            //
            btnSalesReport.BackColor = Color.FromArgb(31, 30, 68);
            btnSalesReport.Dock = DockStyle.Top;
            btnSalesReport.FlatAppearance.BorderSize = 0;
            btnSalesReport.FlatStyle = FlatStyle.Flat;
            btnSalesReport.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSalesReport.ForeColor = Color.Gainsboro;
            btnSalesReport.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            btnSalesReport.IconColor = Color.Gainsboro;
            btnSalesReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalesReport.IconSize = 22;
            btnSalesReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalesReport.Location = new Point(0, 0);
            btnSalesReport.Name = "btnSalesReport";
            btnSalesReport.Padding = new Padding(24, 0, 4, 0);
            btnSalesReport.Size = new Size(200, 40);
            btnSalesReport.TabIndex = 0;
            btnSalesReport.Text = "Sales History";
            btnSalesReport.TextAlign = ContentAlignment.MiddleLeft;
            btnSalesReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalesReport.UseVisualStyleBackColor = false;
            btnSalesReport.Click += btnSalesReport_Click;
            //
            // btnPOSRecord
            //
            btnPOSRecord.BackColor = Color.FromArgb(31, 30, 68);
            btnPOSRecord.Dock = DockStyle.Top;
            btnPOSRecord.FlatAppearance.BorderSize = 0;
            btnPOSRecord.FlatStyle = FlatStyle.Flat;
            btnPOSRecord.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPOSRecord.ForeColor = Color.Gainsboro;
            btnPOSRecord.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            btnPOSRecord.IconColor = Color.Gainsboro;
            btnPOSRecord.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPOSRecord.IconSize = 22;
            btnPOSRecord.ImageAlign = ContentAlignment.MiddleLeft;
            btnPOSRecord.Location = new Point(0, 40);
            btnPOSRecord.Name = "btnPOSRecord";
            btnPOSRecord.Padding = new Padding(24, 0, 4, 0);
            btnPOSRecord.Size = new Size(200, 40);
            btnPOSRecord.TabIndex = 1;
            btnPOSRecord.Text = "POS Record";
            btnPOSRecord.TextAlign = ContentAlignment.MiddleLeft;
            btnPOSRecord.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPOSRecord.UseVisualStyleBackColor = false;
            btnPOSRecord.Click += btnPOSRecord_Click;
            //
            // btnSettings
            //
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Arial Black", 10F, FontStyle.Bold);
            btnSettings.ForeColor = Color.Gainsboro;
            btnSettings.IconChar = FontAwesome.Sharp.IconChar.Gear;
            btnSettings.IconColor = Color.White;
            btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSettings.IconSize = 28;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 718);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(10, 0, 20, 0);
            btnSettings.Size = new Size(200, 48);
            btnSettings.TabIndex = 9;
            btnSettings.Text = "Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            //
            // panelSubSetting
            //
            panelSubSetting.BackColor = Color.FromArgb(31, 30, 68);
            panelSubSetting.Controls.Add(btnUser);
            panelSubSetting.Dock = DockStyle.Top;
            panelSubSetting.Location = new Point(0, 766);
            panelSubSetting.Name = "panelSubSetting";
            panelSubSetting.Size = new Size(200, 40);
            panelSubSetting.TabIndex = 10;
            //
            // btnUser
            //
            btnUser.BackColor = Color.FromArgb(31, 30, 68);
            btnUser.Dock = DockStyle.Top;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnUser.ForeColor = Color.Gainsboro;
            btnUser.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            btnUser.IconColor = Color.Gainsboro;
            btnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUser.IconSize = 22;
            btnUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser.Location = new Point(0, 0);
            btnUser.Name = "btnUser";
            btnUser.Padding = new Padding(24, 0, 4, 0);
            btnUser.Size = new Size(200, 40);
            btnUser.TabIndex = 0;
            btnUser.Text = "User";
            btnUser.TextAlign = ContentAlignment.MiddleLeft;
            btnUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            //
            // panelLogo
            //
            panelLogo.BackColor = Color.Cyan;
            panelLogo.Controls.Add(picture_Logo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(200, 158);
            panelLogo.TabIndex = 0;
            //
            // picture_Logo
            //
            picture_Logo.BackgroundImage = (Image)resources.GetObject("picture_Logo.BackgroundImage");
            picture_Logo.BackgroundImageLayout = ImageLayout.Stretch;
            picture_Logo.BorderStyle = BorderStyle.Fixed3D;
            picture_Logo.ErrorImage = (Image)resources.GetObject("picture_Logo.ErrorImage");
            picture_Logo.Location = new Point(5, 9);
            picture_Logo.Name = "picture_Logo";
            picture_Logo.Size = new Size(191, 140);
            picture_Logo.TabIndex = 2;
            picture_Logo.TabStop = false;
            //
            // panelTitleBar
            //
            panelTitleBar.BackColor = Color.FromArgb(26, 25, 62);
            panelTitleBar.Controls.Add(panel1);
            panelTitleBar.Controls.Add(lblTitleChild);
            panelTitleBar.Controls.Add(iconCurrentChildIcon);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(200, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1023, 65);
            panelTitleBar.TabIndex = 16;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            //
            // panel1
            //
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnMaximize);
            panel1.Controls.Add(btnMinimize);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(887, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(136, 65);
            panel1.TabIndex = 2;
            //
            // btnExit
            //
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.DarkSalmon;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnExit.IconColor = Color.FromArgb(255, 128, 0);
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 25;
            btnExit.Location = new Point(99, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 22);
            btnExit.TabIndex = 5;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            //
            // btnMaximize
            //
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.ForeColor = Color.IndianRed;
            btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            btnMaximize.IconColor = Color.IndianRed;
            btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximize.IconSize = 20;
            btnMaximize.Location = new Point(65, 3);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(30, 22);
            btnMaximize.TabIndex = 4;
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            //
            // btnMinimize
            //
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.ForeColor = Color.IndianRed;
            btnMinimize.IconChar = FontAwesome.Sharp.IconChar.SquareMinus;
            btnMinimize.IconColor = Color.IndianRed;
            btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimize.Location = new Point(29, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(30, 22);
            btnMinimize.TabIndex = 3;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            //
            // lblTitleChild
            //
            lblTitleChild.AutoSize = true;
            lblTitleChild.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleChild.ForeColor = Color.Gainsboro;
            lblTitleChild.Location = new Point(58, 27);
            lblTitleChild.Name = "lblTitleChild";
            lblTitleChild.Size = new Size(50, 20);
            lblTitleChild.TabIndex = 1;
            lblTitleChild.Text = "Home";
            //
            // iconCurrentChildIcon
            //
            iconCurrentChildIcon.BackColor = Color.FromArgb(26, 25, 62);
            iconCurrentChildIcon.ForeColor = Color.MediumOrchid;
            iconCurrentChildIcon.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurrentChildIcon.IconColor = Color.MediumOrchid;
            iconCurrentChildIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildIcon.Location = new Point(20, 21);
            iconCurrentChildIcon.Name = "iconCurrentChildIcon";
            iconCurrentChildIcon.Size = new Size(32, 32);
            iconCurrentChildIcon.TabIndex = 0;
            iconCurrentChildIcon.TabStop = false;
            //
            // panelShadow
            //
            panelShadow.BackColor = Color.FromArgb(26, 25, 62);
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(200, 65);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(1023, 10);
            panelShadow.TabIndex = 17;
            //
            // panelMenuForm
            //
            panelMenuForm.BackColor = Color.FromArgb(34, 33, 74);
            panelMenuForm.Dock = DockStyle.Fill;
            panelMenuForm.Location = new Point(200, 75);
            panelMenuForm.Name = "panelMenuForm";
            panelMenuForm.Size = new Size(1023, 589);
            panelMenuForm.TabIndex = 18;
            //
            // AdminLandingPage
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1223, 664);
            Controls.Add(panelMenuForm);
            Controls.Add(panelShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "AdminLandingPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            WindowState = FormWindowState.Maximized;
            Load += AdminLandingPage_Load;
            panelMenu.ResumeLayout(false);
            panelSubSetting.ResumeLayout(false);
            panelSubRecord.ResumeLayout(false);
            panelSubStock.ResumeLayout(false);
            panelSubProduct.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture_Logo).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnProduct;
        private Panel panelSubProduct;
        private FontAwesome.Sharp.IconButton btnInventory;
        private FontAwesome.Sharp.IconButton btnCategory;
        private FontAwesome.Sharp.IconButton btnBrand;
        private FontAwesome.Sharp.IconButton btnStock;
        private Panel panelSubStock;
        private FontAwesome.Sharp.IconButton btnStockEntry;
        private FontAwesome.Sharp.IconButton btnStockAdjustment;
        private FontAwesome.Sharp.IconButton btnSupplier;
        private FontAwesome.Sharp.IconButton btnRecord;
        private Panel panelSubRecord;
        private FontAwesome.Sharp.IconButton btnSalesReport;
        private FontAwesome.Sharp.IconButton btnPOSRecord;
        private FontAwesome.Sharp.IconButton btnSettings;
        private Panel panelSubSetting;
        private FontAwesome.Sharp.IconButton btnUser;
        private Panel panelLogo;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildIcon;
        private Label lblTitleChild;
        private Panel panelShadow;
        private Panel panelMenuForm;
        private FontAwesome.Sharp.IconButton btnLogout;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private PictureBox picture_Logo;
    }
}
