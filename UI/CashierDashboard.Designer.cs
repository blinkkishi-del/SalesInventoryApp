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
            btnHome = new Button();
            txtSearch = new TextBox();
            panel1 = new Panel();
            lblCashierdashboard = new Label();
            panel2 = new Panel();
            btnPos = new Button();
            btnLogout = new Button();
            panel3 = new Panel();
            btnProduct = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.WindowFrame;
            btnHome.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = SystemColors.ButtonHighlight;
            btnHome.Location = new Point(37, 30);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(328, 61);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(90, 45);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(460, 61);
            txtSearch.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(lblCashierdashboard);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(426, 108);
            panel1.TabIndex = 6;
            // 
            // lblCashierdashboard
            // 
            lblCashierdashboard.AutoSize = true;
            lblCashierdashboard.Font = new Font("Garamond", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCashierdashboard.Location = new Point(37, 34);
            lblCashierdashboard.Name = "lblCashierdashboard";
            lblCashierdashboard.Size = new Size(346, 45);
            lblCashierdashboard.TabIndex = 0;
            lblCashierdashboard.Text = "Cashier Dashboard";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnPos);
            panel2.Controls.Add(btnHome);
            panel2.Location = new Point(12, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(426, 496);
            panel2.TabIndex = 1;
            // 
            // btnPos
            // 
            btnPos.BackColor = SystemColors.WindowFrame;
            btnPos.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPos.ForeColor = SystemColors.ButtonHighlight;
            btnPos.Location = new Point(37, 139);
            btnPos.Name = "btnPos";
            btnPos.Size = new Size(328, 61);
            btnPos.TabIndex = 1;
            btnPos.Text = "Point of Sale";
            btnPos.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.ActiveCaption;
            btnLogout.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(101, 400);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(184, 61);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDark;
            panel3.Controls.Add(btnProduct);
            panel3.Controls.Add(txtSearch);
            panel3.Location = new Point(444, 136);
            panel3.Name = "panel3";
            panel3.Size = new Size(822, 496);
            panel3.TabIndex = 6;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = SystemColors.ControlLight;
            btnProduct.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProduct.ForeColor = SystemColors.ActiveCaptionText;
            btnProduct.Location = new Point(585, 45);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(161, 61);
            btnProduct.TabIndex = 6;
            btnProduct.Text = "Search";
            btnProduct.UseVisualStyleBackColor = false;
            // 
            // CashierDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 644);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CashierDashboard";
            Text = "CashierDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnHome;
        private TextBox txtSearch;
        private Panel panel1;
        private Label lblCashierdashboard;
        private Panel panel2;
        private Button btnLogout;
        private Button btnPos;
        private Panel panel3;
        private Button btnProduct;
    }
}