namespace UI
{
    partial class CashierDashboard
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
            panelMenu = new Panel();
            btnLogout = new FontAwesome.Sharp.IconButton();
            btnPOS = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelTitleBar = new Panel();
            panel1 = new Panel();
            btnExit = new FontAwesome.Sharp.IconButton();
            btnMaximize = new FontAwesome.Sharp.IconButton();
            btnMinimize = new FontAwesome.Sharp.IconButton();
            lblTitleChild = new Label();
            iconCurrentChildIcon = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
            btnSupplier = new Button();
            panelMenuForm = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitleBar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildIcon).BeginInit();
            panelShadow.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(26, 25, 62);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnPOS);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(229, 885);
            panelMenu.TabIndex = 16;
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
            btnLogout.Location = new Point(0, 805);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(11, 0, 23, 0);
            btnLogout.Size = new Size(229, 80);
            btnLogout.TabIndex = 20;
            btnLogout.Text = "Log Out";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnPOS
            // 
            btnPOS.Dock = DockStyle.Top;
            btnPOS.FlatAppearance.BorderSize = 0;
            btnPOS.FlatStyle = FlatStyle.Flat;
            btnPOS.Font = new Font("Arial Black", 10F, FontStyle.Bold);
            btnPOS.ForeColor = Color.Gainsboro;
            btnPOS.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            btnPOS.IconColor = Color.White;
            btnPOS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPOS.IconSize = 32;
            btnPOS.ImageAlign = ContentAlignment.MiddleLeft;
            btnPOS.Location = new Point(0, 291);
            btnPOS.Margin = new Padding(3, 4, 3, 4);
            btnPOS.Name = "btnPOS";
            btnPOS.Padding = new Padding(11, 0, 23, 0);
            btnPOS.Size = new Size(229, 80);
            btnPOS.TabIndex = 17;
            btnPOS.Text = "Point of Sales";
            btnPOS.TextAlign = ContentAlignment.MiddleLeft;
            btnPOS.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPOS.UseVisualStyleBackColor = true;
            btnPOS.Click += btnPOS_Click;
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
            btnDashboard.IconSize = 32;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 211);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(11, 0, 23, 0);
            btnDashboard.Size = new Size(229, 80);
            btnDashboard.TabIndex = 16;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 4, 3, 4);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(229, 211);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(31, 43);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 101);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(26, 25, 62);
            panelTitleBar.Controls.Add(panel1);
            panelTitleBar.Controls.Add(lblTitleChild);
            panelTitleBar.Controls.Add(iconCurrentChildIcon);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(229, 0);
            panelTitleBar.Margin = new Padding(3, 4, 3, 4);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1169, 87);
            panelTitleBar.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnMaximize);
            panel1.Controls.Add(btnMinimize);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1014, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(155, 87);
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
            btnExit.Location = new Point(113, 4);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(34, 29);
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
            btnMaximize.Location = new Point(74, 4);
            btnMaximize.Margin = new Padding(3, 4, 3, 4);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(34, 29);
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
            btnMinimize.Location = new Point(38, 4);
            btnMinimize.Margin = new Padding(3, 4, 3, 4);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(30, 29);
            btnMinimize.TabIndex = 3;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // lblTitleChild
            // 
            lblTitleChild.AutoSize = true;
            lblTitleChild.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleChild.ForeColor = Color.Gainsboro;
            lblTitleChild.Location = new Point(66, 36);
            lblTitleChild.Name = "lblTitleChild";
            lblTitleChild.Size = new Size(64, 25);
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
            iconCurrentChildIcon.IconSize = 37;
            iconCurrentChildIcon.Location = new Point(23, 28);
            iconCurrentChildIcon.Margin = new Padding(3, 4, 3, 4);
            iconCurrentChildIcon.Name = "iconCurrentChildIcon";
            iconCurrentChildIcon.Size = new Size(37, 43);
            iconCurrentChildIcon.TabIndex = 0;
            iconCurrentChildIcon.TabStop = false;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.FromArgb(26, 25, 62);
            panelShadow.Controls.Add(btnSupplier);
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(229, 87);
            panelShadow.Margin = new Padding(3, 4, 3, 4);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(1169, 13);
            panelShadow.TabIndex = 18;
            // 
            // btnSupplier
            // 
            btnSupplier.BackColor = SystemColors.WindowFrame;
            btnSupplier.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupplier.Location = new Point(165, 93);
            btnSupplier.Margin = new Padding(2, 3, 2, 3);
            btnSupplier.Name = "btnSupplier";
            btnSupplier.Size = new Size(285, 53);
            btnSupplier.TabIndex = 14;
            btnSupplier.Text = "Supplier";
            btnSupplier.UseVisualStyleBackColor = false;
            // 
            // panelMenuForm
            // 
            panelMenuForm.BackColor = Color.FromArgb(34, 33, 74);
            panelMenuForm.Dock = DockStyle.Fill;
            panelMenuForm.Location = new Point(229, 100);
            panelMenuForm.Margin = new Padding(3, 4, 3, 4);
            panelMenuForm.Name = "panelMenuForm";
            panelMenuForm.Size = new Size(1169, 785);
            panelMenuForm.TabIndex = 19;
            // 
            // CashierDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1398, 885);
            Controls.Add(panelMenuForm);
            Controls.Add(panelShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Margin = new Padding(2, 3, 2, 3);
            Name = "CashierDashboard";
            Text = "CashierDashboard";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildIcon).EndInit();
            panelShadow.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnSalesReport;
        private FontAwesome.Sharp.IconButton btnStocksReport;
        private FontAwesome.Sharp.IconButton btnPOS;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Panel panelTitleBar;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private Label lblTitleChild;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildIcon;
        private Panel panelShadow;
        private Button btnSupplier;
        private Panel panelMenuForm;
    }
}