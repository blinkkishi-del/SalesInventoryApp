namespace UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pbLogo = new PictureBox();
            lblStorename = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            btnExit = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(96, 140);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(399, 378);
            pbLogo.TabIndex = 7;
            pbLogo.TabStop = false;
            pbLogo.Click += pbLogo_Click;
            // 
            // lblStorename
            // 
            lblStorename.AutoSize = true;
            lblStorename.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStorename.Location = new Point(150, 89);
            lblStorename.Name = "lblStorename";
            lblStorename.Size = new Size(281, 35);
            lblStorename.TabIndex = 8;
            lblStorename.Text = "Quirk and Quill";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(744, 224);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(114, 23);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(744, 348);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(114, 23);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Password";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1196, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(74, 27);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(744, 371);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(371, 44);
            txtPassword.TabIndex = 13;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(744, 247);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(371, 45);
            txtUsername.TabIndex = 14;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(859, 463);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 15;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 653);
            Controls.Add(btnLogin);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnExit);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblStorename);
            Controls.Add(pbLogo);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private PictureBox pbLogo;
        private Label lblStorename;
        private Label lblUsername;
        private Label lblPassword;
        private Button button3;
        private Button btnExit;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnLogin;
    }
}