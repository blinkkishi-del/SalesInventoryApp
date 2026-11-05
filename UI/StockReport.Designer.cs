namespace UI
{
    partial class StockReport
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
            cbProductsCategory = new ComboBox();
            panelStocks = new Panel();
            lblNumberofstocks = new Label();
            lblStock = new Label();
            iconStock = new FontAwesome.Sharp.IconPictureBox();
            btnPrint = new FontAwesome.Sharp.IconButton();
            panelLowStock = new Panel();
            lblLowStock = new Label();
            lblLowStocks = new Label();
            lblLow = new Label();
            iconLowStock = new FontAwesome.Sharp.IconPictureBox();
            dgProducts = new DataGridView();
            panelStocks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconStock).BeginInit();
            panelLowStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconLowStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
            SuspendLayout();
            // 
            // cbProductsCategory
            // 
            cbProductsCategory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbProductsCategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbProductsCategory.FormattingEnabled = true;
            cbProductsCategory.Location = new Point(660, 219);
            cbProductsCategory.Name = "cbProductsCategory";
            cbProductsCategory.Size = new Size(281, 36);
            cbProductsCategory.TabIndex = 65;
            cbProductsCategory.SelectedIndexChanged += cbProductsCategory_SelectedIndexChanged;
            // 
            // panelStocks
            // 
            panelStocks.BackColor = Color.FromArgb(224, 224, 224);
            panelStocks.BorderStyle = BorderStyle.Fixed3D;
            panelStocks.Controls.Add(lblNumberofstocks);
            panelStocks.Controls.Add(lblStock);
            panelStocks.Controls.Add(iconStock);
            panelStocks.Location = new Point(186, 33);
            panelStocks.Name = "panelStocks";
            panelStocks.Size = new Size(311, 140);
            panelStocks.TabIndex = 66;
            // 
            // lblNumberofstocks
            // 
            lblNumberofstocks.AutoSize = true;
            lblNumberofstocks.BackColor = Color.Transparent;
            lblNumberofstocks.Font = new Font("Microsoft Sans Serif", 22.75F, FontStyle.Bold);
            lblNumberofstocks.ForeColor = Color.Black;
            lblNumberofstocks.Location = new Point(54, 72);
            lblNumberofstocks.Name = "lblNumberofstocks";
            lblNumberofstocks.Size = new Size(63, 44);
            lblNumberofstocks.TabIndex = 54;
            lblNumberofstocks.Text = "12";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.BackColor = Color.Transparent;
            lblStock.Font = new Font("Microsoft Sans Serif", 18.75F, FontStyle.Bold);
            lblStock.ForeColor = Color.Black;
            lblStock.Location = new Point(13, 20);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(154, 37);
            lblStock.TabIndex = 53;
            lblStock.Text = "STOCKS";
            // 
            // iconStock
            // 
            iconStock.BackColor = Color.Blue;
            iconStock.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            iconStock.IconColor = Color.White;
            iconStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconStock.IconSize = 125;
            iconStock.Location = new Point(179, 3);
            iconStock.Name = "iconStock";
            iconStock.Size = new Size(125, 130);
            iconStock.TabIndex = 0;
            iconStock.TabStop = false;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrint.BackColor = Color.FromArgb(128, 128, 255);
            btnPrint.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = Color.Black;
            btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            btnPrint.IconColor = Color.Black;
            btnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPrint.IconSize = 23;
            btnPrint.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrint.Location = new Point(972, 212);
            btnPrint.Margin = new Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(122, 51);
            btnPrint.TabIndex = 67;
            btnPrint.Text = "PRINT";
            btnPrint.TextAlign = ContentAlignment.MiddleRight;
            btnPrint.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // panelLowStock
            // 
            panelLowStock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelLowStock.BackColor = Color.FromArgb(224, 224, 224);
            panelLowStock.BorderStyle = BorderStyle.Fixed3D;
            panelLowStock.Controls.Add(lblLowStock);
            panelLowStock.Controls.Add(lblLowStocks);
            panelLowStock.Controls.Add(lblLow);
            panelLowStock.Controls.Add(iconLowStock);
            panelLowStock.Location = new Point(620, 33);
            panelLowStock.Name = "panelLowStock";
            panelLowStock.Size = new Size(311, 140);
            panelLowStock.TabIndex = 67;
            // 
            // lblLowStock
            // 
            lblLowStock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLowStock.AutoSize = true;
            lblLowStock.BackColor = Color.Transparent;
            lblLowStock.Font = new Font("Microsoft Sans Serif", 22.75F, FontStyle.Bold);
            lblLowStock.ForeColor = Color.Black;
            lblLowStock.Location = new Point(54, 72);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(63, 44);
            lblLowStock.TabIndex = 69;
            lblLowStock.Text = "12";
            // 
            // lblLowStocks
            // 
            lblLowStocks.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLowStocks.AutoSize = true;
            lblLowStocks.BackColor = Color.Transparent;
            lblLowStocks.Font = new Font("Microsoft Sans Serif", 14.75F, FontStyle.Bold);
            lblLowStocks.ForeColor = Color.Black;
            lblLowStocks.Location = new Point(29, 40);
            lblLowStocks.Name = "lblLowStocks";
            lblLowStocks.Size = new Size(122, 29);
            lblLowStocks.TabIndex = 55;
            lblLowStocks.Text = "STOCKS";
            // 
            // lblLow
            // 
            lblLow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLow.AutoSize = true;
            lblLow.BackColor = Color.Transparent;
            lblLow.Font = new Font("Microsoft Sans Serif", 14.75F, FontStyle.Bold);
            lblLow.ForeColor = Color.Black;
            lblLow.Location = new Point(54, 7);
            lblLow.Name = "lblLow";
            lblLow.Size = new Size(73, 29);
            lblLow.TabIndex = 53;
            lblLow.Text = "LOW";
            // 
            // iconLowStock
            // 
            iconLowStock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconLowStock.BackColor = Color.Blue;
            iconLowStock.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            iconLowStock.IconColor = Color.White;
            iconLowStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconLowStock.IconSize = 125;
            iconLowStock.Location = new Point(179, 3);
            iconLowStock.Name = "iconLowStock";
            iconLowStock.Size = new Size(125, 130);
            iconLowStock.TabIndex = 0;
            iconLowStock.TabStop = false;
            // 
            // dgProducts
            // 
            dgProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgProducts.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dgProducts.Location = new Point(5, 293);
            dgProducts.Name = "dgProducts";
            dgProducts.RowHeadersWidth = 51;
            dgProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProducts.Size = new Size(1123, 392);
            dgProducts.TabIndex = 68;
            // 
            // StockReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1133, 691);
            Controls.Add(dgProducts);
            Controls.Add(panelLowStock);
            Controls.Add(btnPrint);
            Controls.Add(panelStocks);
            Controls.Add(cbProductsCategory);
            ForeColor = Color.Black;
            Name = "StockReport";
            Text = "StockReport";
            Load += StockReport_Load;
            panelStocks.ResumeLayout(false);
            panelStocks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconStock).EndInit();
            panelLowStock.ResumeLayout(false);
            panelLowStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconLowStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cbProductsCategory;
        private Panel panelStocks;
        private FontAwesome.Sharp.IconButton btnPrint;
        private FontAwesome.Sharp.IconPictureBox iconStock;
        private Label lblStock;
        private Label lblNumberofstocks;
        private Panel panel1;
        private Label label1;
        private Label lblLow;
        private FontAwesome.Sharp.IconPictureBox iconLowStock;
        private Label lblLowStocks;
        private DataGridView dgProducts;
        private Panel panelLowStock;
        private Label lblLowStock;
    }
}