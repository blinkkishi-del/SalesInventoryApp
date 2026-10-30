namespace UI
{
    partial class PointofSales
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
            panel1 = new Panel();
            lblTotalReceipt = new Label();
            lblChange = new Label();
            dgViewReceipt = new DataGridView();
            txtPay = new TextBox();
            btnPay = new FontAwesome.Sharp.IconButton();
            datetpDate = new DateTimePicker();
            label2 = new Label();
            lblPay = new Label();
            lblTotal = new Label();
            lblReceiptNo = new Label();
            lblDate = new Label();
            lblStorename = new Label();
            btnCancel = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            dgProducts = new DataGridView();
            btnSearch = new FontAwesome.Sharp.IconButton();
            txtSearch = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgViewReceipt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTotalReceipt);
            panel1.Controls.Add(lblChange);
            panel1.Controls.Add(dgViewReceipt);
            panel1.Controls.Add(txtPay);
            panel1.Controls.Add(btnPay);
            panel1.Controls.Add(datetpDate);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblPay);
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(lblReceiptNo);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(lblStorename);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(dgProducts);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1007, 554);
            panel1.TabIndex = 0;
            // 
            // lblTotalReceipt
            // 
            lblTotalReceipt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalReceipt.AutoSize = true;
            lblTotalReceipt.Font = new Font("Segoe UI", 11F);
            lblTotalReceipt.Location = new Point(716, 432);
            lblTotalReceipt.Name = "lblTotalReceipt";
            lblTotalReceipt.Size = new Size(12, 20);
            lblTotalReceipt.TabIndex = 78;
            lblTotalReceipt.Text = ".";
            // 
            // lblChange
            // 
            lblChange.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI", 11F);
            lblChange.Location = new Point(716, 510);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(12, 20);
            lblChange.TabIndex = 77;
            lblChange.Text = ".";
            // 
            // dgViewReceipt
            // 
            dgViewReceipt.AllowUserToAddRows = false;
            dgViewReceipt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dgViewReceipt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgViewReceipt.BackgroundColor = SystemColors.Control;
            dgViewReceipt.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgViewReceipt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgViewReceipt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgViewReceipt.DefaultCellStyle = dataGridViewCellStyle2;
            dgViewReceipt.Location = new Point(584, 214);
            dgViewReceipt.Margin = new Padding(3, 2, 3, 2);
            dgViewReceipt.Name = "dgViewReceipt";
            dgViewReceipt.ReadOnly = true;
            dgViewReceipt.RowHeadersWidth = 51;
            dgViewReceipt.Size = new Size(387, 199);
            dgViewReceipt.TabIndex = 76;
            // 
            // txtPay
            // 
            txtPay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPay.BackColor = Color.GhostWhite;
            txtPay.Font = new Font("Segoe UI", 11F);
            txtPay.Location = new Point(716, 466);
            txtPay.Margin = new Padding(3, 2, 3, 2);
            txtPay.Name = "txtPay";
            txtPay.Size = new Size(120, 27);
            txtPay.TabIndex = 75;
            // 
            // btnPay
            // 
            btnPay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPay.BackColor = Color.MediumSpringGreen;
            btnPay.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPay.ForeColor = Color.Black;
            btnPay.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            btnPay.IconColor = Color.Black;
            btnPay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPay.IconSize = 23;
            btnPay.ImageAlign = ContentAlignment.MiddleLeft;
            btnPay.Location = new Point(868, 466);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(116, 38);
            btnPay.TabIndex = 74;
            btnPay.Text = "PAY";
            btnPay.TextAlign = ContentAlignment.MiddleRight;
            btnPay.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += txtPay_TextChanged;
            // 
            // datetpDate
            // 
            datetpDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            datetpDate.CalendarFont = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            datetpDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            datetpDate.Location = new Point(670, 136);
            datetpDate.Margin = new Padding(3, 2, 3, 2);
            datetpDate.Name = "datetpDate";
            datetpDate.Size = new Size(289, 29);
            datetpDate.TabIndex = 73;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(593, 506);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 72;
            label2.Text = "Change:";
            // 
            // lblPay
            // 
            lblPay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPay.AutoSize = true;
            lblPay.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblPay.ForeColor = Color.Black;
            lblPay.Location = new Point(625, 465);
            lblPay.Name = "lblPay";
            lblPay.Size = new Size(59, 25);
            lblPay.TabIndex = 71;
            lblPay.Text = "Pay:";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(614, 432);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(79, 25);
            lblTotal.TabIndex = 70;
            lblTotal.Text = "Total: ";
            // 
            // lblReceiptNo
            // 
            lblReceiptNo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblReceiptNo.AutoSize = true;
            lblReceiptNo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblReceiptNo.ForeColor = Color.Black;
            lblReceiptNo.Location = new Point(584, 178);
            lblReceiptNo.Name = "lblReceiptNo";
            lblReceiptNo.Size = new Size(135, 25);
            lblReceiptNo.TabIndex = 69;
            lblReceiptNo.Text = "Receipt No:";
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblDate.ForeColor = Color.Black;
            lblDate.Location = new Point(584, 136);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(75, 25);
            lblDate.TabIndex = 68;
            lblDate.Text = "Date: ";
            // 
            // lblStorename
            // 
            lblStorename.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblStorename.AutoSize = true;
            lblStorename.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblStorename.ForeColor = Color.Black;
            lblStorename.Location = new Point(584, 99);
            lblStorename.Name = "lblStorename";
            lblStorename.Size = new Size(142, 25);
            lblStorename.TabIndex = 67;
            lblStorename.Text = "Store Name:";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.BackColor = Color.Silver;
            btnCancel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Black;
            btnCancel.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancel.IconColor = Color.Black;
            btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancel.IconSize = 23;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(203, 506);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(108, 38);
            btnCancel.TabIndex = 59;
            btnCancel.Text = "CANCEL";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.BackColor = Color.OrangeRed;
            btnDelete.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            btnDelete.IconColor = Color.Black;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.IconSize = 23;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(52, 506);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(116, 38);
            btnDelete.TabIndex = 58;
            btnDelete.Text = "DELETE";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgProducts
            // 
            dgProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgProducts.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgProducts.DefaultCellStyle = dataGridViewCellStyle4;
            dgProducts.Location = new Point(10, 86);
            dgProducts.Margin = new Padding(3, 2, 3, 2);
            dgProducts.Name = "dgProducts";
            dgProducts.RowHeadersWidth = 51;
            dgProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProducts.Size = new Size(548, 404);
            dgProducts.TabIndex = 57;
            dgProducts.CellDoubleClick += dgProducts_CellDoubleClick;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Silver;
            btnSearch.Font = new Font("Arial", 11.75F, FontStyle.Bold);
            btnSearch.ForeColor = Color.Black;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnSearch.IconColor = Color.Black;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 26;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(382, 40);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(144, 40);
            btnSearch.TabIndex = 56;
            btnSearch.Text = "SEARCH";
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.Font = new Font("Segoe UI", 14F);
            txtSearch.Location = new Point(88, 44);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Items Here";
            txtSearch.Size = new Size(275, 32);
            txtSearch.TabIndex = 51;
            // 
            // PointofSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 554);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PointofSales";
            Text = "PointofSales";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgViewReceipt).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private DataGridView dgProducts;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnCancel;
        private DateTimePicker datetpDate;
        private Label label2;
        private Label lblPay;
        private Label lblTotal;
        private Label lblReceiptNo;
        private Label lblDate;
        private Label lblStorename;
        private FontAwesome.Sharp.IconButton btnPay;
        private TextBox txtPay;
        private DataGridView dgViewReceipt;
        private Label lblTotalReceipt;
        private Label lblChange;
    }
}