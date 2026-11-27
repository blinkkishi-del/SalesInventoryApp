namespace UI
{
    partial class StockEntry
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblSupplier = new Label();
            cmbSupplier = new ComboBox();
            lblStockInBy = new Label();
            lblStockInByValue = new Label();
            lblDate = new Label();
            lblDateValue = new Label();
            lblSupplierInfo = new Label();
            lblProducts = new Label();
            txtSearch = new TextBox();
            dgProducts = new DataGridView();
            lblQty = new Label();
            nudQty = new NumericUpDown();
            btnAddToList = new FontAwesome.Sharp.IconButton();
            lblEntry = new Label();
            dgEntry = new DataGridView();
            btnRemove = new FontAwesome.Sharp.IconButton();
            btnClear = new FontAwesome.Sharp.IconButton();
            btnSave = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgEntry).BeginInit();
            SuspendLayout();
            //
            // lblSupplier
            //
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblSupplier.ForeColor = Color.Gainsboro;
            lblSupplier.Location = new Point(15, 12);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Text = "Supplier";
            //
            // cmbSupplier
            //
            cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSupplier.Font = new Font("Segoe UI", 11F);
            cmbSupplier.Location = new Point(15, 38);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(320, 28);
            cmbSupplier.TabIndex = 0;
            cmbSupplier.SelectedIndexChanged += cmbSupplier_SelectedIndexChanged;
            //
            // lblStockInBy
            //
            lblStockInBy.AutoSize = true;
            lblStockInBy.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblStockInBy.ForeColor = Color.Gainsboro;
            lblStockInBy.Location = new Point(360, 12);
            lblStockInBy.Name = "lblStockInBy";
            lblStockInBy.Text = "Stocked In By";
            //
            // lblStockInByValue
            //
            lblStockInByValue.AutoSize = true;
            lblStockInByValue.Font = new Font("Segoe UI", 12F);
            lblStockInByValue.ForeColor = Color.White;
            lblStockInByValue.Location = new Point(360, 40);
            lblStockInByValue.Name = "lblStockInByValue";
            lblStockInByValue.Text = "-";
            //
            // lblDate
            //
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblDate.ForeColor = Color.Gainsboro;
            lblDate.Location = new Point(600, 12);
            lblDate.Name = "lblDate";
            lblDate.Text = "Date";
            //
            // lblDateValue
            //
            lblDateValue.AutoSize = true;
            lblDateValue.Font = new Font("Segoe UI", 12F);
            lblDateValue.ForeColor = Color.White;
            lblDateValue.Location = new Point(600, 40);
            lblDateValue.Name = "lblDateValue";
            lblDateValue.Text = "-";
            //
            // lblSupplierInfo
            //
            lblSupplierInfo.AutoSize = true;
            lblSupplierInfo.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblSupplierInfo.ForeColor = Color.Silver;
            lblSupplierInfo.Location = new Point(15, 75);
            lblSupplierInfo.Name = "lblSupplierInfo";
            //
            // lblProducts
            //
            lblProducts.AutoSize = true;
            lblProducts.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblProducts.ForeColor = Color.Gainsboro;
            lblProducts.Location = new Point(15, 106);
            lblProducts.Name = "lblProducts";
            lblProducts.Text = "Products  (double-click to add)";
            //
            // txtSearch
            //
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            txtSearch.Location = new Point(15, 134);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search product, model or brand";
            txtSearch.Size = new Size(470, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            //
            // dgProducts
            //
            dgProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgProducts.Location = new Point(15, 168);
            dgProducts.Name = "dgProducts";
            dgProducts.Size = new Size(470, 290);
            dgProducts.TabIndex = 2;
            dgProducts.CellDoubleClick += dgProducts_CellDoubleClick;
            //
            // lblQty
            //
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblQty.ForeColor = Color.Gainsboro;
            lblQty.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblQty.Location = new Point(15, 472);
            lblQty.Name = "lblQty";
            lblQty.Text = "Qty";
            //
            // nudQty
            //
            nudQty.Font = new Font("Segoe UI", 11F);
            nudQty.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nudQty.Location = new Point(60, 470);
            nudQty.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQty.Name = "nudQty";
            nudQty.Size = new Size(80, 27);
            nudQty.TabIndex = 3;
            nudQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //
            // btnAddToList
            //
            btnAddToList.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            btnAddToList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddToList.IconSize = 23;
            btnAddToList.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddToList.Location = new Point(155, 466);
            btnAddToList.BackColor = Color.FromArgb(60,179,113);
            btnAddToList.Cursor = Cursors.Hand;
            btnAddToList.FlatAppearance.BorderSize = 0;
            btnAddToList.FlatStyle = FlatStyle.Flat;
            btnAddToList.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAddToList.ForeColor = Color.White;
            btnAddToList.IconColor = Color.White;
            btnAddToList.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddToList.UseVisualStyleBackColor = false;
            btnAddToList.Name = "btnAddToList";
            btnAddToList.Size = new Size(170, 36);
            btnAddToList.TabIndex = 4;
            btnAddToList.Text = "ADD TO LIST";
            btnAddToList.Click += btnAddToList_Click;
            //
            // lblEntry
            //
            lblEntry.AutoSize = true;
            lblEntry.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblEntry.ForeColor = Color.Gainsboro;
            lblEntry.Location = new Point(510, 106);
            lblEntry.Name = "lblEntry";
            lblEntry.Text = "Entry List";
            //
            // dgEntry
            //
            dgEntry.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgEntry.Location = new Point(510, 134);
            dgEntry.Name = "dgEntry";
            dgEntry.Size = new Size(482, 324);
            dgEntry.TabIndex = 5;
            //
            // btnRemove
            //
            btnRemove.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            btnRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRemove.IconSize = 23;
            btnRemove.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRemove.Location = new Point(510, 466);
            btnRemove.BackColor = Color.FromArgb(220,53,69);
            btnRemove.Cursor = Cursors.Hand;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnRemove.ForeColor = Color.White;
            btnRemove.IconColor = Color.White;
            btnRemove.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(120, 36);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "REMOVE";
            btnRemove.Click += btnRemove_Click;
            //
            // btnClear
            //
            btnClear.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClear.IconSize = 23;
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClear.Location = new Point(640, 466);
            btnClear.BackColor = Color.FromArgb(108,117,125);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.IconColor = Color.White;
            btnClear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 36);
            btnClear.TabIndex = 7;
            btnClear.Text = "CLEAR";
            btnClear.Click += btnClear_Click;
            //
            // btnSave
            //
            btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.IconSize = 26;
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(832, 462);
            btnSave.BackColor = Color.FromArgb(34,139,34);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.IconColor = Color.White;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 42);
            btnSave.TabIndex = 8;
            btnSave.Text = "SAVE ENTRY";
            btnSave.Click += btnSave_Click;
            //
            // StockEntry
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1007, 550);
            Controls.Add(lblSupplier);
            Controls.Add(cmbSupplier);
            Controls.Add(lblStockInBy);
            Controls.Add(lblStockInByValue);
            Controls.Add(lblDate);
            Controls.Add(lblDateValue);
            Controls.Add(lblSupplierInfo);
            Controls.Add(lblProducts);
            Controls.Add(txtSearch);
            Controls.Add(dgProducts);
            Controls.Add(lblQty);
            Controls.Add(nudQty);
            Controls.Add(btnAddToList);
            Controls.Add(lblEntry);
            Controls.Add(dgEntry);
            Controls.Add(btnRemove);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Name = "StockEntry";
            Text = "Stock Entry";
            Load += StockEntry_Load;
            ((System.ComponentModel.ISupportInitialize)dgProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgEntry).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSupplier;
        private ComboBox cmbSupplier;
        private Label lblStockInBy;
        private Label lblStockInByValue;
        private Label lblDate;
        private Label lblDateValue;
        private Label lblSupplierInfo;
        private Label lblProducts;
        private TextBox txtSearch;
        private DataGridView dgProducts;
        private Label lblQty;
        private NumericUpDown nudQty;
        private FontAwesome.Sharp.IconButton btnAddToList;
        private Label lblEntry;
        private DataGridView dgEntry;
        private FontAwesome.Sharp.IconButton btnRemove;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton btnSave;
    }
}
