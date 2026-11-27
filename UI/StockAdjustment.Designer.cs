namespace UI
{
    partial class StockAdjustment
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
            tabMain = new TabControl();
            tabAdjust = new TabPage();
            tabHistory = new TabPage();
            reportAdjustments = new ReportTab();
            lblProducts = new Label();
            txtSearch = new TextBox();
            dgProducts = new DataGridView();
            panelAdjust = new Panel();
            lblAdjustTitle = new Label();
            lblSelected = new Label();
            lblSelectedValue = new Label();
            lblCurrentStock = new Label();
            lblCurrentStockValue = new Label();
            lblAction = new Label();
            cmbAction = new ComboBox();
            lblQty = new Label();
            nudQty = new NumericUpDown();
            lblReason = new Label();
            cmbReason = new ComboBox();
            lblRemarks = new Label();
            txtRemarks = new TextBox();
            lblAdjustedBy = new Label();
            lblAdjustedByValue = new Label();
            btnClear = new FontAwesome.Sharp.IconButton();
            btnSave = new FontAwesome.Sharp.IconButton();
            tabMain.SuspendLayout();
            tabAdjust.SuspendLayout();
            tabHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
            panelAdjust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQty).BeginInit();
            SuspendLayout();
            //
            // tabMain
            //
            tabMain.Controls.Add(tabAdjust);
            tabMain.Controls.Add(tabHistory);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            tabMain.Name = "tabMain";
            tabMain.Padding = new Point(14, 5);
            tabMain.SelectedIndex = 0;
            tabMain.TabIndex = 0;
            //
            // tabAdjust
            //
            tabAdjust.BackColor = Color.FromArgb(34, 33, 74);
            tabAdjust.Controls.Add(lblProducts);
            tabAdjust.Controls.Add(txtSearch);
            tabAdjust.Controls.Add(dgProducts);
            tabAdjust.Controls.Add(panelAdjust);
            tabAdjust.Name = "tabAdjust";
            tabAdjust.Size = new Size(999, 512);
            tabAdjust.Text = "Adjust Stock";
            //
            // tabHistory
            //
            tabHistory.BackColor = Color.FromArgb(34, 33, 74);
            tabHistory.Controls.Add(reportAdjustments);
            tabHistory.Name = "tabHistory";
            tabHistory.Text = "Adjustment History";
            //
            // reportAdjustments
            //
            reportAdjustments.Dock = DockStyle.Fill;
            reportAdjustments.Name = "reportAdjustments";
            //
            // lblProducts
            //
            lblProducts.AutoSize = true;
            lblProducts.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblProducts.ForeColor = Color.Gainsboro;
            lblProducts.Location = new Point(15, 12);
            lblProducts.Name = "lblProducts";
            lblProducts.Text = "Products  (click one to adjust)";
            //
            // txtSearch
            //
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.Location = new Point(15, 40);
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search product, model or brand";
            txtSearch.Size = new Size(560, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            //
            // dgProducts
            //
            dgProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgProducts.Location = new Point(15, 75);
            dgProducts.Name = "dgProducts";
            dgProducts.Size = new Size(560, 422);
            dgProducts.TabIndex = 1;
            dgProducts.CellClick += dgProducts_CellClick;
            //
            // panelAdjust
            //
            panelAdjust.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelAdjust.BackColor = Color.FromArgb(44, 43, 92);
            panelAdjust.Controls.Add(lblAdjustTitle);
            panelAdjust.Controls.Add(lblSelected);
            panelAdjust.Controls.Add(lblSelectedValue);
            panelAdjust.Controls.Add(lblCurrentStock);
            panelAdjust.Controls.Add(lblCurrentStockValue);
            panelAdjust.Controls.Add(lblAction);
            panelAdjust.Controls.Add(cmbAction);
            panelAdjust.Controls.Add(lblQty);
            panelAdjust.Controls.Add(nudQty);
            panelAdjust.Controls.Add(lblReason);
            panelAdjust.Controls.Add(cmbReason);
            panelAdjust.Controls.Add(lblRemarks);
            panelAdjust.Controls.Add(txtRemarks);
            panelAdjust.Controls.Add(lblAdjustedBy);
            panelAdjust.Controls.Add(lblAdjustedByValue);
            panelAdjust.Controls.Add(btnClear);
            panelAdjust.Controls.Add(btnSave);
            panelAdjust.Location = new Point(595, 12);
            panelAdjust.Name = "panelAdjust";
            panelAdjust.Size = new Size(397, 485);
            panelAdjust.TabIndex = 2;
            //
            // lblAdjustTitle
            //
            lblAdjustTitle.AutoSize = true;
            lblAdjustTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblAdjustTitle.ForeColor = Color.White;
            lblAdjustTitle.Location = new Point(18, 14);
            lblAdjustTitle.Name = "lblAdjustTitle";
            lblAdjustTitle.Text = "ADJUST STOCK";
            //
            // lblSelected
            //
            lblSelected.AutoSize = true;
            lblSelected.Font = new Font("Segoe UI", 10F);
            lblSelected.ForeColor = Color.Silver;
            lblSelected.Location = new Point(18, 56);
            lblSelected.Name = "lblSelected";
            lblSelected.Text = "Product";
            //
            // lblSelectedValue
            //
            lblSelectedValue.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblSelectedValue.ForeColor = Color.White;
            lblSelectedValue.Location = new Point(18, 76);
            lblSelectedValue.Name = "lblSelectedValue";
            lblSelectedValue.Size = new Size(360, 44);
            //
            // lblCurrentStock
            //
            lblCurrentStock.AutoSize = true;
            lblCurrentStock.Font = new Font("Segoe UI", 10F);
            lblCurrentStock.ForeColor = Color.Silver;
            lblCurrentStock.Location = new Point(18, 124);
            lblCurrentStock.Name = "lblCurrentStock";
            lblCurrentStock.Text = "Current Stock";
            //
            // lblCurrentStockValue
            //
            lblCurrentStockValue.AutoSize = true;
            lblCurrentStockValue.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblCurrentStockValue.ForeColor = Color.FromArgb(111, 207, 151);
            lblCurrentStockValue.Location = new Point(140, 120);
            lblCurrentStockValue.Name = "lblCurrentStockValue";
            lblCurrentStockValue.Text = "-";
            //
            // lblAction
            //
            lblAction.AutoSize = true;
            lblAction.Font = new Font("Segoe UI", 10F);
            lblAction.ForeColor = Color.Silver;
            lblAction.Location = new Point(18, 164);
            lblAction.Name = "lblAction";
            lblAction.Text = "Action";
            //
            // cmbAction
            //
            cmbAction.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAction.Font = new Font("Segoe UI", 11F);
            cmbAction.Location = new Point(18, 186);
            cmbAction.Name = "cmbAction";
            cmbAction.Size = new Size(240, 28);
            cmbAction.TabIndex = 3;
            //
            // lblQty
            //
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Segoe UI", 10F);
            lblQty.ForeColor = Color.Silver;
            lblQty.Location = new Point(275, 164);
            lblQty.Name = "lblQty";
            lblQty.Text = "Quantity";
            //
            // nudQty
            //
            nudQty.Font = new Font("Segoe UI", 11F);
            nudQty.Location = new Point(275, 187);
            nudQty.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQty.Name = "nudQty";
            nudQty.Size = new Size(103, 27);
            nudQty.TabIndex = 4;
            nudQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //
            // lblReason
            //
            lblReason.AutoSize = true;
            lblReason.Font = new Font("Segoe UI", 10F);
            lblReason.ForeColor = Color.Silver;
            lblReason.Location = new Point(18, 228);
            lblReason.Name = "lblReason";
            lblReason.Text = "Reason";
            //
            // cmbReason
            //
            cmbReason.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReason.Font = new Font("Segoe UI", 11F);
            cmbReason.Location = new Point(18, 250);
            cmbReason.Name = "cmbReason";
            cmbReason.Size = new Size(360, 28);
            cmbReason.TabIndex = 5;
            //
            // lblRemarks
            //
            lblRemarks.AutoSize = true;
            lblRemarks.Font = new Font("Segoe UI", 10F);
            lblRemarks.ForeColor = Color.Silver;
            lblRemarks.Location = new Point(18, 292);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Text = "Remarks (required for \"Other\")";
            //
            // txtRemarks
            //
            txtRemarks.BorderStyle = BorderStyle.FixedSingle;
            txtRemarks.Font = new Font("Segoe UI", 11F);
            txtRemarks.Location = new Point(18, 314);
            txtRemarks.MaxLength = 200;
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(360, 70);
            txtRemarks.TabIndex = 6;
            //
            // lblAdjustedBy
            //
            lblAdjustedBy.AutoSize = true;
            lblAdjustedBy.Font = new Font("Segoe UI", 10F);
            lblAdjustedBy.ForeColor = Color.Silver;
            lblAdjustedBy.Location = new Point(18, 398);
            lblAdjustedBy.Name = "lblAdjustedBy";
            lblAdjustedBy.Text = "Adjusted By";
            //
            // lblAdjustedByValue
            //
            lblAdjustedByValue.AutoSize = true;
            lblAdjustedByValue.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblAdjustedByValue.ForeColor = Color.White;
            lblAdjustedByValue.Location = new Point(120, 396);
            lblAdjustedByValue.Name = "lblAdjustedByValue";
            lblAdjustedByValue.Text = "-";
            //
            // btnClear
            //
            btnClear.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClear.IconSize = 23;
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClear.Location = new Point(18, 428);
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
            btnClear.Size = new Size(120, 42);
            btnClear.TabIndex = 8;
            btnClear.Text = "CLEAR";
            btnClear.Click += btnClear_Click;
            //
            // btnSave
            //
            btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.IconSize = 26;
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(198, 428);
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
            btnSave.Size = new Size(180, 42);
            btnSave.TabIndex = 7;
            btnSave.Text = "SAVE";
            btnSave.Click += btnSave_Click;
            //
            // StockAdjustment
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1007, 550);
            Controls.Add(tabMain);
            Name = "StockAdjustment";
            Text = "Stock Adjustment";
            Load += StockAdjustment_Load;
            tabMain.ResumeLayout(false);
            tabAdjust.ResumeLayout(false);
            tabAdjust.PerformLayout();
            tabHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgProducts).EndInit();
            panelAdjust.ResumeLayout(false);
            panelAdjust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabMain;
        private TabPage tabAdjust;
        private TabPage tabHistory;
        private ReportTab reportAdjustments;
        private Label lblProducts;
        private TextBox txtSearch;
        private DataGridView dgProducts;
        private Panel panelAdjust;
        private Label lblAdjustTitle;
        private Label lblSelected;
        private Label lblSelectedValue;
        private Label lblCurrentStock;
        private Label lblCurrentStockValue;
        private Label lblAction;
        private ComboBox cmbAction;
        private Label lblQty;
        private NumericUpDown nudQty;
        private Label lblReason;
        private ComboBox cmbReason;
        private Label lblRemarks;
        private TextBox txtRemarks;
        private Label lblAdjustedBy;
        private Label lblAdjustedByValue;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton btnSave;
    }
}
