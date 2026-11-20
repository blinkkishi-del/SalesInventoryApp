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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            iconTotalInventory = new FontAwesome.Sharp.IconPictureBox();
            lblTotalInventory = new Label();
            label1 = new Label();
            panel2 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            lblLowStock = new Label();
            label2 = new Label();
            panel4 = new Panel();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            lblTotalSalesToday = new Label();
            label3 = new Label();
            btnPrintLowStock = new FontAwesome.Sharp.IconButton();
            dgridLowStock = new DataGridView();
            label4 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconTotalInventory).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgridLowStock).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(iconTotalInventory);
            panel1.Controls.Add(lblTotalInventory);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(60, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 122);
            panel1.TabIndex = 0;
            // 
            // iconTotalInventory
            // 
            iconTotalInventory.BackColor = SystemColors.ActiveCaption;
            iconTotalInventory.ForeColor = SystemColors.ControlText;
            iconTotalInventory.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            iconTotalInventory.IconColor = SystemColors.ControlText;
            iconTotalInventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconTotalInventory.IconSize = 83;
            iconTotalInventory.Location = new Point(180, 22);
            iconTotalInventory.Name = "iconTotalInventory";
            iconTotalInventory.Size = new Size(89, 83);
            iconTotalInventory.TabIndex = 2;
            iconTotalInventory.TabStop = false;
            // 
            // lblTotalInventory
            // 
            lblTotalInventory.AutoSize = true;
            lblTotalInventory.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalInventory.Location = new Point(57, 49);
            lblTotalInventory.Name = "lblTotalInventory";
            lblTotalInventory.Size = new Size(30, 37);
            lblTotalInventory.TabIndex = 1;
            lblTotalInventory.Text = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 16);
            label1.Name = "label1";
            label1.Size = new Size(149, 22);
            label1.TabIndex = 0;
            label1.Text = "Total Inventory";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = Color.Crimson;
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(lblLowStock);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(373, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(272, 122);
            panel2.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 83;
            iconPictureBox1.Location = new Point(180, 22);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(89, 83);
            iconPictureBox1.TabIndex = 3;
            iconPictureBox1.TabStop = false;
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStock.Location = new Point(52, 49);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(30, 37);
            lblLowStock.TabIndex = 2;
            lblLowStock.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 16);
            label2.Name = "label2";
            label2.Size = new Size(118, 22);
            label2.TabIndex = 1;
            label2.Text = "Low Stocks";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.BackColor = Color.LimeGreen;
            panel4.Controls.Add(iconPictureBox3);
            panel4.Controls.Add(lblTotalSalesToday);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(685, 34);
            panel4.Name = "panel4";
            panel4.Size = new Size(272, 122);
            panel4.TabIndex = 2;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.Transparent;
            iconPictureBox3.ForeColor = SystemColors.ControlText;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            iconPictureBox3.IconColor = SystemColors.ControlText;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 83;
            iconPictureBox3.Location = new Point(170, 20);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(89, 83);
            iconPictureBox3.TabIndex = 4;
            iconPictureBox3.TabStop = false;
            // 
            // lblTotalSalesToday
            // 
            lblTotalSalesToday.AutoSize = true;
            lblTotalSalesToday.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalSalesToday.Location = new Point(53, 49);
            lblTotalSalesToday.Name = "lblTotalSalesToday";
            lblTotalSalesToday.Size = new Size(30, 37);
            lblTotalSalesToday.TabIndex = 3;
            lblTotalSalesToday.Text = "1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 16);
            label3.Name = "label3";
            label3.Size = new Size(129, 22);
            label3.TabIndex = 2;
            label3.Text = "Today's Sale";
            // 
            // btnPrintLowStock
            // 
            btnPrintLowStock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrintLowStock.BackColor = Color.FromArgb(128, 128, 255);
            btnPrintLowStock.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintLowStock.ForeColor = Color.Black;
            btnPrintLowStock.IconChar = FontAwesome.Sharp.IconChar.Print;
            btnPrintLowStock.IconColor = Color.Black;
            btnPrintLowStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPrintLowStock.IconSize = 23;
            btnPrintLowStock.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrintLowStock.Location = new Point(866, 202);
            btnPrintLowStock.Name = "btnPrintLowStock";
            btnPrintLowStock.Size = new Size(107, 38);
            btnPrintLowStock.TabIndex = 62;
            btnPrintLowStock.Text = "PRINT";
            btnPrintLowStock.TextAlign = ContentAlignment.MiddleRight;
            btnPrintLowStock.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPrintLowStock.UseVisualStyleBackColor = false;
            btnPrintLowStock.Click += btnPrintLowStock_Click;
            // 
            // dgridLowStock
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgridLowStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgridLowStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgridLowStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgridLowStock.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgridLowStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgridLowStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgridLowStock.DefaultCellStyle = dataGridViewCellStyle3;
            dgridLowStock.GridColor = SystemColors.Desktop;
            dgridLowStock.Location = new Point(35, 267);
            dgridLowStock.Margin = new Padding(3, 2, 3, 2);
            dgridLowStock.Name = "dgridLowStock";
            dgridLowStock.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgridLowStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgridLowStock.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dgridLowStock.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgridLowStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgridLowStock.Size = new Size(938, 261);
            dgridLowStock.TabIndex = 63;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(11, 4);
            label4.Name = "label4";
            label4.Size = new Size(169, 22);
            label4.TabIndex = 2;
            label4.Text = "Low Stock Items:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(35, 231);
            panel3.Name = "panel3";
            panel3.Size = new Size(189, 31);
            panel3.TabIndex = 64;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1007, 550);
            Controls.Add(panel3);
            Controls.Add(dgridLowStock);
            Controls.Add(btnPrintLowStock);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconTotalInventory).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgridLowStock).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTotalInventory;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel4;
        private Label label3;
        private Label lblLowStock;
        private Label lblTotalSalesToday;
        private FontAwesome.Sharp.IconButton btnPrintLowStock;
        private DataGridView dgridLowStock;
        private Label label4;
        private FontAwesome.Sharp.IconPictureBox iconTotalInventory;
        private Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
    }
}