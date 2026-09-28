namespace UI
{
    partial class AdminDashboard
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
            btnProduct = new Button();
            lblAdmindashboard = new Label();
            txtSearch = new TextBox();
            btnStockreport = new Button();
            btnSalesreport = new Button();
            btnInvmanage = new Button();
            btnLogout = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            btnSupplier = new Button();
            btnProductcategory = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnProduct
            // 
            btnProduct.BackColor = SystemColors.Control;
            btnProduct.Font = new Font("Constantia", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProduct.ForeColor = SystemColors.InactiveCaptionText;
            btnProduct.Location = new Point(445, 17);
            btnProduct.Margin = new Padding(2, 2, 2, 2);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(122, 50);
            btnProduct.TabIndex = 6;
            btnProduct.Text = "Search";
            btnProduct.UseVisualStyleBackColor = false;
            // 
            // lblAdmindashboard
            // 
            lblAdmindashboard.AutoSize = true;
            lblAdmindashboard.Font = new Font("Garamond", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmindashboard.ForeColor = SystemColors.ActiveCaptionText;
            lblAdmindashboard.Location = new Point(20, 16);
            lblAdmindashboard.Margin = new Padding(2, 0, 2, 0);
            lblAdmindashboard.Name = "lblAdmindashboard";
            lblAdmindashboard.Size = new Size(304, 42);
            lblAdmindashboard.TabIndex = 7;
            lblAdmindashboard.Text = "Admin Dashboard";
            lblAdmindashboard.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(50, 17);
            txtSearch.Margin = new Padding(2, 2, 2, 2);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(379, 50);
            txtSearch.TabIndex = 8;
            txtSearch.WordWrap = false;
            // 
            // btnStockreport
            // 
            btnStockreport.BackColor = SystemColors.WindowFrame;
            btnStockreport.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStockreport.ForeColor = SystemColors.ButtonHighlight;
            btnStockreport.Location = new Point(36, 178);
            btnStockreport.Margin = new Padding(2, 2, 2, 2);
            btnStockreport.Name = "btnStockreport";
            btnStockreport.Size = new Size(285, 59);
            btnStockreport.TabIndex = 9;
            btnStockreport.Text = "Stock Report";
            btnStockreport.UseVisualStyleBackColor = false;
            // 
            // btnSalesreport
            // 
            btnSalesreport.BackColor = SystemColors.WindowFrame;
            btnSalesreport.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalesreport.ForeColor = SystemColors.ButtonHighlight;
            btnSalesreport.Location = new Point(38, 94);
            btnSalesreport.Margin = new Padding(2, 2, 2, 2);
            btnSalesreport.Name = "btnSalesreport";
            btnSalesreport.Size = new Size(284, 58);
            btnSalesreport.TabIndex = 10;
            btnSalesreport.Text = "Sales Report";
            btnSalesreport.UseVisualStyleBackColor = false;
            // 
            // btnInvmanage
            // 
            btnInvmanage.BackColor = SystemColors.WindowFrame;
            btnInvmanage.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInvmanage.ForeColor = SystemColors.ButtonHighlight;
            btnInvmanage.Location = new Point(37, 14);
            btnInvmanage.Margin = new Padding(2, 2, 2, 2);
            btnInvmanage.Name = "btnInvmanage";
            btnInvmanage.Size = new Size(284, 59);
            btnInvmanage.TabIndex = 11;
            btnInvmanage.Text = "Inventory Management";
            btnInvmanage.UseVisualStyleBackColor = false;
            btnInvmanage.Click += btnInvmanage_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.ActiveCaption;
            btnLogout.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(110, 430);
            btnLogout.Margin = new Padding(2, 2, 2, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(129, 46);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Menu;
            panel1.Controls.Add(btnInvmanage);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnSupplier);
            panel1.Controls.Add(btnSalesreport);
            panel1.Controls.Add(btnProductcategory);
            panel1.Controls.Add(btnStockreport);
            panel1.Location = new Point(10, 10);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 496);
            panel1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuBar;
            panel2.Controls.Add(lblAdmindashboard);
            panel2.Location = new Point(392, 10);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(337, 70);
            panel2.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonShadow;
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(btnProduct);
            panel3.Location = new Point(392, 98);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(621, 408);
            panel3.TabIndex = 8;
            // 
            // btnSupplier
            // 
            btnSupplier.BackColor = SystemColors.WindowFrame;
            btnSupplier.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupplier.Location = new Point(36, 350);
            btnSupplier.Margin = new Padding(2);
            btnSupplier.Name = "btnSupplier";
            btnSupplier.Size = new Size(285, 54);
            btnSupplier.TabIndex = 14;
            btnSupplier.Text = "Supplier";
            btnSupplier.UseVisualStyleBackColor = false;
            // 
            // btnProductcategory
            // 
            btnProductcategory.BackColor = SystemColors.WindowFrame;
            btnProductcategory.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductcategory.ForeColor = SystemColors.ButtonHighlight;
            btnProductcategory.Location = new Point(38, 266);
            btnProductcategory.Margin = new Padding(2);
            btnProductcategory.Name = "btnProductcategory";
            btnProductcategory.Size = new Size(284, 55);
            btnProductcategory.TabIndex = 13;
            btnProductcategory.Text = "Product Category";
            btnProductcategory.UseVisualStyleBackColor = false;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1022, 515);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.Control;
            Margin = new Padding(2, 2, 2, 2);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion


        private Button btnProduct;
        private Label lblAdmindashboard;
        private TextBox txtSearch;
        private Button btnStockreport;
        private Button btnSalesreport;
        private Button btnInvmanage;
        private Button btnLogout;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnSupplier;
        private Button btnProductcategory;
    }
}