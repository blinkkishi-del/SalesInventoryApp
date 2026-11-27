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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            lblQty = new Label();
            nudQty = new NumericUpDown();
            lblShortcuts = new Label();
            lblHomexia = new Label();
            lblTotalReceipt = new Label();
            lblChange = new Label();
            dgViewReceipt = new DataGridView();
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
            label3 = new Label();
            lblPayy = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgViewReceipt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(244, 245, 249);
            panel1.Controls.Add(lblPayy);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblQty);
            panel1.Controls.Add(nudQty);
            panel1.Controls.Add(lblShortcuts);
            panel1.Controls.Add(lblHomexia);
            panel1.Controls.Add(lblTotalReceipt);
            panel1.Controls.Add(lblChange);
            panel1.Controls.Add(dgViewReceipt);
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
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.5F, FontStyle.Italic);
            label1.ForeColor = Color.FromArgb(107, 114, 128);
            label1.Location = new Point(30, 103);
            label1.Name = "label1";
            label1.Size = new Size(196, 17);
            label1.TabIndex = 80;
            label1.Text = "Double-click or press Enter to add";
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblQty.ForeColor = Color.FromArgb(34, 33, 74);
            lblQty.Location = new Point(330, 101);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(32, 19);
            lblQty.TabIndex = 81;
            lblQty.Text = "Qty";
            // 
            // nudQty
            // 
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
            lblShortcuts.Size = new Size(343, 15);
            lblShortcuts.TabIndex = 83;
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
            lblTotalReceipt.Location = new Point(664, 428);
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
            lblChange.Location = new Point(664, 502);
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
            dataGridViewCellStyle7.BackColor = Color.FromArgb(247, 248, 251);
            dgViewReceipt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgViewReceipt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgViewReceipt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgViewReceipt.BackgroundColor = Color.White;
            dgViewReceipt.BorderStyle = BorderStyle.None;
            dgViewReceipt.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(34, 33, 74);
            dataGridViewCellStyle8.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(34, 33, 74);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgViewReceipt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgViewReceipt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(237, 233, 254);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(34, 33, 74);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgViewReceipt.DefaultCellStyle = dataGridViewCellStyle9;
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
            btnPay.Location = new Point(840, 456);
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
            dataGridViewCellStyle10.BackColor = Color.FromArgb(247, 248, 251);
            dgProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dgProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgProducts.BackgroundColor = Color.White;
            dgProducts.BorderStyle = BorderStyle.None;
            dgProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(34, 33, 74);
            dataGridViewCellStyle11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(34, 33, 74);
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(237, 233, 254);
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(34, 33, 74);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgProducts.DefaultCellStyle = dataGridViewCellStyle12;
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
            txtSearch.Location = new Point(59, 46);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Items Here";
            txtSearch.Size = new Size(275, 32);
            txtSearch.TabIndex = 51;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(124, 58, 237);
            label3.Location = new Point(487, 265);
            label3.Name = "label3";
            label3.Size = new Size(32, 25);
            label3.TabIndex = 84;
            label3.Text = "00";
            // 
            // lblPayy
            // 
            lblPayy.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPayy.AutoSize = true;
            lblPayy.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblPayy.ForeColor = Color.FromArgb(124, 58, 237);
            lblPayy.Location = new Point(664, 463);
            lblPayy.Name = "lblPayy";
            lblPayy.Size = new Size(32, 25);
            lblPayy.TabIndex = 84;
            lblPayy.Text = "00";
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
            ((System.ComponentModel.ISupportInitialize)nudQty).EndInit();
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
        private DataGridView dgViewReceipt;
        private Label lblTotalReceipt;
        private Label lblChange;
        private Label lblHomexia;
        private Label label1;
        private Label lblQty;
        private NumericUpDown nudQty;
        private Label lblShortcuts;
        private Label lblPayy;
        private Label label3;
    }
}