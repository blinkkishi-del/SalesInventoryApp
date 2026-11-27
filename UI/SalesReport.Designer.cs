namespace UI
{
    partial class SalesReport
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
            lblFrom = new Label();
            dtpFrom = new DateTimePicker();
            lblTo = new Label();
            dtpTo = new DateTimePicker();
            lblCashier = new Label();
            cmbCashier = new ComboBox();
            txtSearch = new TextBox();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            btnPrint = new FontAwesome.Sharp.IconButton();
            dgList = new DataGridView();
            lblCount = new Label();
            lblCountValue = new Label();
            lblDiscount = new Label();
            lblDiscountValue = new Label();
            lblTotal = new Label();
            lblTotalValue = new Label();
            ((System.ComponentModel.ISupportInitialize)dgList).BeginInit();
            SuspendLayout();
            //
            // lblFrom
            //
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblFrom.ForeColor = Color.Gainsboro;
            lblFrom.Location = new Point(12, 8);
            lblFrom.Name = "lblFrom";
            lblFrom.Text = "From";
            //
            // dtpFrom
            //
            dtpFrom.Font = new Font("Segoe UI", 11F);
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(12, 30);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(150, 27);
            dtpFrom.TabIndex = 0;
            dtpFrom.ValueChanged += Filter_Changed;
            //
            // lblTo
            //
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTo.ForeColor = Color.Gainsboro;
            lblTo.Location = new Point(175, 8);
            lblTo.Name = "lblTo";
            lblTo.Text = "To";
            //
            // dtpTo
            //
            dtpTo.Font = new Font("Segoe UI", 11F);
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(175, 30);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(150, 27);
            dtpTo.TabIndex = 1;
            dtpTo.ValueChanged += Filter_Changed;
            //
            // lblCashier
            //
            lblCashier.AutoSize = true;
            lblCashier.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblCashier.ForeColor = Color.Gainsboro;
            lblCashier.Location = new Point(338, 8);
            lblCashier.Name = "lblCashier";
            lblCashier.Text = "Cashier";
            //
            // cmbCashier
            //
            cmbCashier.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCashier.Font = new Font("Segoe UI", 11F);
            cmbCashier.Location = new Point(338, 30);
            cmbCashier.Name = "cmbCashier";
            cmbCashier.Size = new Size(170, 28);
            cmbCashier.TabIndex = 2;
            cmbCashier.SelectedIndexChanged += Filter_Changed;
            //
            // txtSearch
            //
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.Location = new Point(522, 30);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search product";
            txtSearch.Size = new Size(195, 27);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += Filter_Changed;
            //
            // btnRefresh
            //
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.IconSize = 23;
            btnRefresh.Location = new Point(752, 24);
            btnRefresh.BackColor = Color.FromArgb(108,117,125);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.IconColor = Color.White;
            btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(107, 38);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "REFRESH";
            btnRefresh.Click += btnRefresh_Click;
            //
            // btnPrint
            //
            btnPrint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            btnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPrint.IconSize = 23;
            btnPrint.Location = new Point(877, 24);
            btnPrint.BackColor = Color.FromArgb(124,58,237);
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnPrint.ForeColor = Color.White;
            btnPrint.IconColor = Color.White;
            btnPrint.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(107, 38);
            btnPrint.TabIndex = 5;
            btnPrint.Text = "PRINT";
            btnPrint.Click += btnPrint_Click;
            //
            // dgList
            //
            dgList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgList.Location = new Point(12, 72);
            dgList.Name = "dgList";
            dgList.Size = new Size(984, 422);
            dgList.TabIndex = 6;
            //
            // lblCount
            //
            lblCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 11F);
            lblCount.ForeColor = Color.Silver;
            lblCount.Location = new Point(12, 510);
            lblCount.Name = "lblCount";
            lblCount.Text = "Items sold:";
            //
            // lblCountValue
            //
            lblCountValue.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCountValue.AutoSize = true;
            lblCountValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCountValue.ForeColor = Color.White;
            lblCountValue.Location = new Point(95, 508);
            lblCountValue.Name = "lblCountValue";
            lblCountValue.Text = "0";
            //
            // lblDiscount
            //
            lblDiscount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Segoe UI", 11F);
            lblDiscount.ForeColor = Color.Silver;
            lblDiscount.Location = new Point(470, 510);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Text = "Total Discount:";
            //
            // lblDiscountValue
            //
            lblDiscountValue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblDiscountValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblDiscountValue.ForeColor = Color.FromArgb(253, 138, 114);
            lblDiscountValue.Location = new Point(580, 506);
            lblDiscountValue.Name = "lblDiscountValue";
            lblDiscountValue.Size = new Size(130, 28);
            lblDiscountValue.Text = "₱0.00";
            lblDiscountValue.TextAlign = ContentAlignment.MiddleRight;
            //
            // lblTotal
            //
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 11F);
            lblTotal.ForeColor = Color.Silver;
            lblTotal.Location = new Point(740, 510);
            lblTotal.Name = "lblTotal";
            lblTotal.Text = "Total Sales:";
            //
            // lblTotalValue
            //
            lblTotalValue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalValue.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblTotalValue.ForeColor = Color.FromArgb(111, 207, 151);
            lblTotalValue.Location = new Point(826, 504);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(170, 32);
            lblTotalValue.Text = "₱0.00";
            lblTotalValue.TextAlign = ContentAlignment.MiddleRight;
            //
            // SalesReport
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1007, 554);
            Controls.Add(lblFrom);
            Controls.Add(dtpFrom);
            Controls.Add(lblTo);
            Controls.Add(dtpTo);
            Controls.Add(lblCashier);
            Controls.Add(cmbCashier);
            Controls.Add(txtSearch);
            Controls.Add(btnRefresh);
            Controls.Add(btnPrint);
            Controls.Add(dgList);
            Controls.Add(lblCount);
            Controls.Add(lblCountValue);
            Controls.Add(lblDiscount);
            Controls.Add(lblDiscountValue);
            Controls.Add(lblTotal);
            Controls.Add(lblTotalValue);
            ForeColor = Color.Black;
            Name = "SalesReport";
            Text = "Sales History";
            Load += SalesReport_Load;
            ((System.ComponentModel.ISupportInitialize)dgList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFrom;
        private DateTimePicker dtpFrom;
        private Label lblTo;
        private DateTimePicker dtpTo;
        private Label lblCashier;
        private ComboBox cmbCashier;
        private TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private FontAwesome.Sharp.IconButton btnPrint;
        private DataGridView dgList;
        private Label lblCount;
        private Label lblCountValue;
        private Label lblDiscount;
        private Label lblDiscountValue;
        private Label lblTotal;
        private Label lblTotalValue;
    }
}
