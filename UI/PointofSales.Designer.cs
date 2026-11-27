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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            lblQty = new Label();
            nudQty = new NumericUpDown();
            lblShortcuts = new Label();
            lblHomexia = new Label();
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
            btnDiscount = new FontAwesome.Sharp.IconButton();
            dgProducts = new DataGridView();
            btnSearch = new FontAwesome.Sharp.IconButton();
            txtSearch = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgViewReceipt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQty).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(244, 245, 249);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblQty);
            panel1.Controls.Add(nudQty);
            panel1.Controls.Add(lblShortcuts);
            panel1.Controls.Add(lblHomexia);
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
            panel1.Controls.Add(btnDiscount);
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
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.5F, FontStyle.Italic);
            label1.ForeColor = Color.FromArgb(107, 114, 128);
            label1.Location = new Point(30, 103);
            label1.Name = "label1";
            label1.Size = new Size(190, 17);
            label1.TabIndex = 80;
            label1.Text = "Double-click or press Enter to add";
            //
            // lblQty
            //
            lblQty.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblQty.ForeColor = Color.FromArgb(34, 33, 74);
            lblQty.Location = new Point(330, 101);
            lblQty.Name = "lblQty";
            lblQty.Text = "Qty";
            nudQty.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            nudQty.Font = new Font("Segoe UI", 10F);
            nudQty.Location = new Point(365, 97);
            nudQty.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQty.Name = "nudQty";
            nudQty.Size = new Size(70, 25);
            nudQty.TabIndex = 82;
            nudQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //
            // lblShortcuts
            //
            lblShortcuts.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblShortcuts.AutoSize = true;
            lblShortcuts.Font = new Font("Segoe UI", 9F);
            lblShortcuts.ForeColor = Color.FromArgb(107, 114, 128);
            lblShortcuts.Location = new Point(14, 529);
            lblShortcuts.Name = "lblShortcuts";
            lblShortcuts.Text = "F1 Search    F2 Qty    F3 Discount    F4 Remove    F5 Void    F8 Pay";
            // 
            // lblHomexia
            // 
            lblHomexia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHomexia.AutoSize = true;
            lblHomexia.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            lblHomexia.ForeColor = Color.FromArgb(34, 33, 74);
            lblHomexia.Location = new Point(679, 42);
            lblHomexia.Name = "lblHomexia";
            lblHomexia.Size = new Size(93, 30);
            lblHomexia.TabIndex = 79;
            lblHomexia.Text = "Homexa";
            // 
            // lblTotalReceipt
            // 
            lblTotalReceipt.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalReceipt.AutoSize = true;
            lblTotalReceipt.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblTotalReceipt.ForeColor = Color.FromArgb(124, 58, 237);
            lblTotalReceipt.Location = new Point(720, 428);
            lblTotalReceipt.Name = "lblTotalReceipt";
            lblTotalReceipt.Size = new Size(32, 25);
            lblTotalReceipt.TabIndex = 78;
            lblTotalReceipt.Text = "00";
            // 
            // lblChange
            // 
            lblChange.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblChange.ForeColor = Color.FromArgb(22, 163, 74);
            lblChange.Location = new Point(720, 506);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(32, 25);
            lblChange.TabIndex = 77;
            lblChange.Text = "00";
            // 
            // dgViewReceipt
            // 
            dgViewReceipt.AllowUserToAddRows = false;
            dgViewReceipt.AllowUserToResizeColumns = false;
            dgViewReceipt.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(247, 248, 251);
            dgViewReceipt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgViewReceipt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgViewReceipt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgViewReceipt.BackgroundColor = Color.White;
            dgViewReceipt.BorderStyle = BorderStyle.None;
            dgViewReceipt.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(34, 33, 74);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(34, 33, 74);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgViewReceipt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgViewReceipt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(237, 233, 254);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(34, 33, 74);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgViewReceipt.DefaultCellStyle = dataGridViewCellStyle3;
            dgViewReceipt.EnableHeadersVisualStyles = false;
            dgViewReceipt.GridColor = Color.FromArgb(230, 232, 238);
            dgViewReceipt.Location = new Point(531, 164);
            dgViewReceipt.Margin = new Padding(3, 2, 3, 2);
            dgViewReceipt.Name = "dgViewReceipt";
            dgViewReceipt.ReadOnly = true;
            dgViewReceipt.RowHeadersVisible = false;
            dgViewReceipt.RowHeadersWidth = 51;
            dgViewReceipt.Size = new Size(464, 199);
            dgViewReceipt.TabIndex = 76;
            // 
            // txtPay
            // 
            txtPay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtPay.BackColor = Color.White;
            txtPay.BorderStyle = BorderStyle.FixedSingle;
            txtPay.Font = new Font("Segoe UI", 11F);
            txtPay.ForeColor = Color.FromArgb(34, 33, 74);
            txtPay.Location = new Point(672, 462);
            txtPay.Margin = new Padding(3, 2, 3, 2);
            txtPay.Name = "txtPay";
            txtPay.RightToLeft = RightToLeft.Yes;
            txtPay.Size = new Size(120, 27);
            txtPay.TabIndex = 75;
            // 
            // btnPay
            // 
            btnPay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPay.BackColor = Color.FromArgb(46, 204, 113);
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnPay.ForeColor = Color.White;
            btnPay.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnPay.IconColor = Color.White;
            btnPay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPay.IconSize = 23;
            btnPay.ImageAlign = ContentAlignment.MiddleLeft;
            btnPay.Location = new Point(824, 462);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(116, 38);
            btnPay.TabIndex = 74;
            btnPay.Text = "PAY";
            btnPay.TextAlign = ContentAlignment.MiddleRight;
            btnPay.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPay.UseVisualStyleBackColor = false;
            btnPay.TextChanged += txtPay_TextChanged;
            btnPay.Click += btnPay_Click;
            // 
            // datetpDate
            // 
            datetpDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            datetpDate.CalendarFont = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            datetpDate.CalendarForeColor = Color.FromArgb(34, 33, 74);
            datetpDate.CustomFormat = "";
            datetpDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            datetpDate.Location = new Point(617, 79);
            datetpDate.Margin = new Padding(3, 2, 3, 2);
            datetpDate.Name = "datetpDate";
            datetpDate.Size = new Size(284, 29);
            datetpDate.TabIndex = 73;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.ForeColor = Color.FromArgb(107, 114, 128);
            label2.Location = new Point(549, 502);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 72;
            label2.Text = "Change:";
            // 
            // lblPay
            // 
            lblPay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPay.AutoSize = true;
            lblPay.Font = new Font("Segoe UI", 13F);
            lblPay.ForeColor = Color.FromArgb(107, 114, 128);
            lblPay.Location = new Point(581, 461);
            lblPay.Name = "lblPay";
            lblPay.Size = new Size(43, 25);
            lblPay.TabIndex = 71;
            lblPay.Text = "Pay:";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 13F);
            lblTotal.ForeColor = Color.FromArgb(107, 114, 128);
            lblTotal.Location = new Point(570, 428);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(58, 25);
            lblTotal.TabIndex = 70;
            lblTotal.Text = "Total: ";
            // 
            // lblReceiptNo
            // 
            lblReceiptNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblReceiptNo.AutoSize = true;
            lblReceiptNo.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblReceiptNo.ForeColor = Color.FromArgb(34, 33, 74);
            lblReceiptNo.Location = new Point(531, 121);
            lblReceiptNo.Name = "lblReceiptNo";
            lblReceiptNo.Size = new Size(108, 25);
            lblReceiptNo.TabIndex = 69;
            lblReceiptNo.Text = "Receipt No:";
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 13F);
            lblDate.ForeColor = Color.FromArgb(107, 114, 128);
            lblDate.Location = new Point(531, 79);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(58, 25);
            lblDate.TabIndex = 68;
            lblDate.Text = "Date: ";
            // 
            // lblStorename
            // 
            lblStorename.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStorename.AutoSize = true;
            lblStorename.Font = new Font("Segoe UI", 13F);
            lblStorename.ForeColor = Color.FromArgb(107, 114, 128);
            lblStorename.Location = new Point(531, 42);
            lblStorename.Name = "lblStorename";
            lblStorename.Size = new Size(109, 25);
            lblStorename.TabIndex = 67;
            lblStorename.Text = "Store Name:";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(149, 165, 166);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancel.IconColor = Color.White;
            btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancel.IconSize = 23;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(857, 368);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(108, 38);
            btnCancel.TabIndex = 59;
            btnCancel.Text = "VOID";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnDelete.IconColor = Color.White;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.IconSize = 23;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(531, 368);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(116, 38);
            btnDelete.TabIndex = 58;
            btnDelete.Text = "REMOVE";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDiscount
            // 
            btnDiscount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDiscount.BackColor = Color.FromArgb(124, 58, 237);
            btnDiscount.FlatAppearance.BorderSize = 0;
            btnDiscount.FlatStyle = FlatStyle.Flat;
            btnDiscount.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnDiscount.ForeColor = Color.White;
            btnDiscount.IconChar = FontAwesome.Sharp.IconChar.Percentage;
            btnDiscount.IconColor = Color.White;
            btnDiscount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDiscount.IconSize = 21;
            btnDiscount.ImageAlign = ContentAlignment.MiddleLeft;
            btnDiscount.Location = new Point(684, 368);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(134, 38);
            btnDiscount.TabIndex = 81;
            btnDiscount.Text = "DISCOUNT";
            btnDiscount.TextAlign = ContentAlignment.MiddleRight;
            btnDiscount.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDiscount.UseVisualStyleBackColor = false;
            btnDiscount.Click += btnDiscount_Click;
            // 
            // dgProducts
            // 
            dgProducts.AllowUserToResizeColumns = false;
            dgProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(247, 248, 251);
            dgProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgProducts.BackgroundColor = Color.White;
            dgProducts.BorderStyle = BorderStyle.None;
            dgProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(34, 33, 74);
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(34, 33, 74);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(237, 233, 254);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(34, 33, 74);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgProducts.DefaultCellStyle = dataGridViewCellStyle6;
            dgProducts.EnableHeadersVisualStyles = false;
            dgProducts.GridColor = Color.FromArgb(230, 232, 238);
            dgProducts.Location = new Point(14, 125);
            dgProducts.Margin = new Padding(3, 2, 3, 2);
            dgProducts.Name = "dgProducts";
            dgProducts.RowHeadersVisible = false;
            dgProducts.RowHeadersWidth = 51;
            dgProducts.RowTemplate.Height = 32;
            dgProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProducts.Size = new Size(493, 398);
            dgProducts.TabIndex = 57;
            dgProducts.CellDoubleClick += dgProducts_CellDoubleClick;
            dgProducts.KeyDown += dgProducts_KeyDown;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(34, 33, 74);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnSearch.IconColor = Color.White;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 26;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnSearch.Location = new Point(353, 42);
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
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 14F);
            txtSearch.ForeColor = Color.FromArgb(34, 33, 74);
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            txtSearch.Location = new Point(59, 46);
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
            Text = "Point of Sales";
            Load += POS_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgViewReceipt).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQty).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private DataGridView dgProducts;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnDiscount;
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
        private Label lblHomexia;
        private Label label1;
        private Label lblQty;
        private NumericUpDown nudQty;
        private Label lblShortcuts;
    }
}