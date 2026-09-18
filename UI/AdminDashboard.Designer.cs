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
            btnProductcategory = new Button();
            btnSupplier = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
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
            btnProduct.Location = new Point(556, 21);
            btnProduct.Margin = new Padding(2, 3, 2, 3);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(153, 62);
            btnProduct.TabIndex = 6;
            btnProduct.Text = "Search";
            btnProduct.UseVisualStyleBackColor = false;
            // 
            // lblAdmindashboard
            // 
            lblAdmindashboard.AutoSize = true;
            lblAdmindashboard.Font = new Font("Garamond", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmindashboard.ForeColor = SystemColors.ActiveCaptionText;
            lblAdmindashboard.Location = new Point(25, 20);
            lblAdmindashboard.Margin = new Padding(2, 0, 2, 0);
            lblAdmindashboard.Name = "lblAdmindashboard";
            lblAdmindashboard.Size = new Size(363, 50);
            lblAdmindashboard.TabIndex = 7;
            lblAdmindashboard.Text = "Admin Dashboard";
            lblAdmindashboard.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(63, 21);
            txtSearch.Margin = new Padding(2, 3, 2, 3);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(473, 62);
            txtSearch.TabIndex = 8;
            txtSearch.WordWrap = false;
            // 
            // btnStockreport
            // 
            btnStockreport.BackColor = SystemColors.WindowFrame;
            btnStockreport.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStockreport.ForeColor = SystemColors.ButtonHighlight;
            btnStockreport.Location = new Point(45, 223);
            btnStockreport.Margin = new Padding(2, 3, 2, 3);
            btnStockreport.Name = "btnStockreport";
            btnStockreport.Size = new Size(356, 74);
            btnStockreport.TabIndex = 9;
            btnStockreport.Text = "Stock Report";
            btnStockreport.UseVisualStyleBackColor = false;
            // 
            // btnSalesreport
            // 
            btnSalesreport.BackColor = SystemColors.WindowFrame;
            btnSalesreport.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalesreport.ForeColor = SystemColors.ButtonHighlight;
            btnSalesreport.Location = new Point(47, 117);
            btnSalesreport.Margin = new Padding(2, 3, 2, 3);
            btnSalesreport.Name = "btnSalesreport";
            btnSalesreport.Size = new Size(355, 72);
            btnSalesreport.TabIndex = 10;
            btnSalesreport.Text = "Sales Report";
            btnSalesreport.UseVisualStyleBackColor = false;
            // 
            // btnInvmanage
            // 
            btnInvmanage.BackColor = SystemColors.WindowFrame;
            btnInvmanage.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInvmanage.ForeColor = SystemColors.ButtonHighlight;
            btnInvmanage.Location = new Point(46, 17);
            btnInvmanage.Margin = new Padding(2, 3, 2, 3);
            btnInvmanage.Name = "btnInvmanage";
            btnInvmanage.Size = new Size(355, 74);
            btnInvmanage.TabIndex = 11;
            btnInvmanage.Text = "Inventory Management";
            btnInvmanage.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.ActiveCaption;
            btnLogout.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(137, 537);
            btnLogout.Margin = new Padding(2, 3, 2, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(161, 58);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnProductcategory
            // 
            btnProductcategory.BackColor = SystemColors.WindowFrame;
            btnProductcategory.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductcategory.ForeColor = SystemColors.ButtonHighlight;
            btnProductcategory.Location = new Point(47, 333);
            btnProductcategory.Margin = new Padding(2, 3, 2, 3);
            btnProductcategory.Name = "btnProductcategory";
            btnProductcategory.Size = new Size(355, 69);
            btnProductcategory.TabIndex = 13;
            btnProductcategory.Text = "Product Category";
            btnProductcategory.UseVisualStyleBackColor = false;
            // 
            // btnSupplier
            // 
            btnSupplier.BackColor = SystemColors.WindowFrame;
            btnSupplier.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupplier.Location = new Point(45, 437);
            btnSupplier.Margin = new Padding(2, 3, 2, 3);
            btnSupplier.Name = "btnSupplier";
            btnSupplier.Size = new Size(356, 68);
            btnSupplier.TabIndex = 14;
            btnSupplier.Text = "Supplier";
            btnSupplier.UseVisualStyleBackColor = false;
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
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 620);
            panel1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuBar;
            panel2.Controls.Add(lblAdmindashboard);
            panel2.Location = new Point(490, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(421, 87);
            panel2.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonShadow;
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(btnProduct);
            panel3.Location = new Point(490, 122);
            panel3.Name = "panel3";
            panel3.Size = new Size(776, 510);
            panel3.TabIndex = 8;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1278, 644);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.Control;
            Margin = new Padding(2, 3, 2, 3);
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
        private Button btnProductcategory;
        private Button btnSupplier;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}