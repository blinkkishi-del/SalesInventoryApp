namespace UI
{
    partial class InventoryManagement
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
            tabInventoryManagement = new TabControl();
            tabInventory = new TabPage();
            dgProducts = new DataGridView();
            panelFooter = new Panel();
            lblCount = new Label();
            lblLowStockNote = new Label();
            panelToolbar = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblFilter = new Label();
            cmbFilter = new ComboBox();
            btnAdd = new FontAwesome.Sharp.IconButton();
            btnUpdate = new FontAwesome.Sharp.IconButton();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            tabAdd = new TabPage();
            panelCard = new Panel();
            tableFields = new TableLayoutPanel();
            lblProductID = new Label();
            lblProductIdValue = new Label();
            lblProductName = new Label();
            txtProductName = new TextBox();
            lblModel = new Label();
            txtModel = new TextBox();
            lblBrand = new Label();
            cmbBrand = new ComboBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblSupplier = new Label();
            cmbSupplier = new ComboBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            lblAmount = new Label();
            txtAmount = new TextBox();
            lblHint = new Label();
            flowButtons = new FlowLayoutPanel();
            btnSave = new FontAwesome.Sharp.IconButton();
            btnCancel = new FontAwesome.Sharp.IconButton();
            panelHeader = new Panel();
            lblAdding = new Label();
            tabInventoryManagement.SuspendLayout();
            tabInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
            panelFooter.SuspendLayout();
            panelToolbar.SuspendLayout();
            tabAdd.SuspendLayout();
            panelCard.SuspendLayout();
            tableFields.SuspendLayout();
            flowButtons.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            //
            // tabInventoryManagement
            //
            tabInventoryManagement.Appearance = TabAppearance.FlatButtons;
            tabInventoryManagement.Controls.Add(tabInventory);
            tabInventoryManagement.Controls.Add(tabAdd);
            tabInventoryManagement.Dock = DockStyle.Fill;
            tabInventoryManagement.ItemSize = new Size(0, 1);
            tabInventoryManagement.Location = new Point(0, 0);
            tabInventoryManagement.Name = "tabInventoryManagement";
            tabInventoryManagement.SelectedIndex = 0;
            tabInventoryManagement.Size = new Size(1007, 550);
            tabInventoryManagement.SizeMode = TabSizeMode.Fixed;
            tabInventoryManagement.TabIndex = 0;
            tabInventoryManagement.TabStop = false;
            //
            // tabInventory
            //
            tabInventory.BackColor = Color.FromArgb(34, 33, 74);
            tabInventory.Controls.Add(dgProducts);
            tabInventory.Controls.Add(panelFooter);
            tabInventory.Controls.Add(panelToolbar);
            tabInventory.Location = new Point(4, 5);
            tabInventory.Name = "tabInventory";
            tabInventory.Padding = new Padding(16, 8, 16, 8);
            tabInventory.Size = new Size(999, 541);
            tabInventory.TabIndex = 0;
            tabInventory.Text = "Products";
            //
            // panelToolbar
            //
            panelToolbar.Controls.Add(lblSearch);
            panelToolbar.Controls.Add(txtSearch);
            panelToolbar.Controls.Add(lblFilter);
            panelToolbar.Controls.Add(cmbFilter);
            panelToolbar.Controls.Add(btnAdd);
            panelToolbar.Controls.Add(btnUpdate);
            panelToolbar.Controls.Add(btnRefresh);
            panelToolbar.Dock = DockStyle.Top;
            panelToolbar.Location = new Point(16, 8);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Size = new Size(967, 66);
            panelToolbar.TabIndex = 0;
            //
            // lblSearch
            //
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSearch.ForeColor = Color.Gainsboro;
            lblSearch.Location = new Point(0, 4);
            lblSearch.Name = "lblSearch";
            lblSearch.Text = "Search";
            //
            // txtSearch
            //
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.Location = new Point(0, 28);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "ID, name, model, brand or supplier";
            txtSearch.Size = new Size(300, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += Filters_Changed;
            //
            // lblFilter
            //
            lblFilter.AutoSize = true;
            lblFilter.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblFilter.ForeColor = Color.Gainsboro;
            lblFilter.Location = new Point(316, 4);
            lblFilter.Name = "lblFilter";
            lblFilter.Text = "Category";
            //
            // cmbFilter
            //
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Font = new Font("Segoe UI", 11F);
            cmbFilter.Location = new Point(316, 27);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(220, 28);
            cmbFilter.TabIndex = 1;
            cmbFilter.SelectedIndexChanged += Filters_Changed;
            //
            // btnAdd
            //
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.MediumSeaGreen;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            btnAdd.IconColor = Color.White;
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.IconSize = 22;
            btnAdd.Location = new Point(613, 22);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(118, 38);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "ADD NEW";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            //
            // btnUpdate
            //
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(24, 161, 251);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            btnUpdate.IconColor = Color.White;
            btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUpdate.IconSize = 22;
            btnUpdate.Location = new Point(737, 22);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(108, 38);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "MODIFY";
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            //
            // btnRefresh
            //
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(108, 117, 125);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            btnRefresh.IconColor = Color.White;
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.IconSize = 22;
            btnRefresh.Location = new Point(851, 22);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(116, 38);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "REFRESH";
            btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            //
            // dgProducts
            //
            dgProducts.Dock = DockStyle.Fill;
            dgProducts.Location = new Point(16, 74);
            dgProducts.Name = "dgProducts";
            dgProducts.Size = new Size(967, 423);
            dgProducts.TabIndex = 5;
            dgProducts.SelectionChanged += dgProducts_SelectionChanged;
            dgProducts.CellDoubleClick += dgProducts_CellDoubleClick;
            //
            // panelFooter
            //
            panelFooter.Controls.Add(lblLowStockNote);
            panelFooter.Controls.Add(lblCount);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(16, 497);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(967, 36);
            panelFooter.TabIndex = 6;
            //
            // lblCount
            //
            lblCount.Dock = DockStyle.Left;
            lblCount.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblCount.ForeColor = Color.FromArgb(111, 207, 151);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(400, 36);
            lblCount.Text = "0 products";
            lblCount.TextAlign = ContentAlignment.MiddleLeft;
            //
            // lblLowStockNote
            //
            lblLowStockNote.Dock = DockStyle.Fill;
            lblLowStockNote.Font = new Font("Segoe UI", 10F);
            lblLowStockNote.ForeColor = Color.Silver;
            lblLowStockNote.Name = "lblLowStockNote";
            lblLowStockNote.Size = new Size(400, 36);
            lblLowStockNote.Text = "Stock shown in red is low (10 or less). Double-click a row to modify.";
            lblLowStockNote.TextAlign = ContentAlignment.MiddleRight;
            //
            // tabAdd
            //
            tabAdd.AutoScroll = true;
            tabAdd.BackColor = Color.FromArgb(34, 33, 74);
            tabAdd.Controls.Add(panelCard);
            tabAdd.Controls.Add(panelHeader);
            tabAdd.Location = new Point(4, 5);
            tabAdd.Name = "tabAdd";
            tabAdd.Size = new Size(999, 541);
            tabAdd.TabIndex = 1;
            tabAdd.Text = "Add / Modify";
            //
            // panelHeader
            //
            panelHeader.Controls.Add(lblAdding);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(24, 0, 0, 0);
            panelHeader.Size = new Size(999, 64);
            panelHeader.TabIndex = 0;
            //
            // lblAdding
            //
            lblAdding.Dock = DockStyle.Fill;
            lblAdding.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblAdding.ForeColor = Color.White;
            lblAdding.Name = "lblAdding";
            lblAdding.Text = "ADD NEW PRODUCT";
            lblAdding.TextAlign = ContentAlignment.MiddleLeft;
            //
            // panelCard
            //
            panelCard.Anchor = AnchorStyles.Top;
            panelCard.BackColor = Color.FromArgb(44, 43, 92);
            panelCard.Controls.Add(tableFields);
            panelCard.Location = new Point(70, 76);
            panelCard.Name = "panelCard";
            panelCard.Padding = new Padding(24, 20, 24, 16);
            panelCard.Size = new Size(860, 440);
            panelCard.TabIndex = 1;
            //
            // tableFields
            //
            tableFields.ColumnCount = 3;
            tableFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tableFields.Controls.Add(lblProductID, 0, 0);
            tableFields.Controls.Add(lblProductName, 1, 0);
            tableFields.Controls.Add(lblProductIdValue, 0, 1);
            tableFields.Controls.Add(txtProductName, 1, 1);
            tableFields.Controls.Add(lblModel, 0, 2);
            tableFields.Controls.Add(lblBrand, 1, 2);
            tableFields.Controls.Add(lblCategory, 2, 2);
            tableFields.Controls.Add(txtModel, 0, 3);
            tableFields.Controls.Add(cmbBrand, 1, 3);
            tableFields.Controls.Add(cmbCategory, 2, 3);
            tableFields.Controls.Add(lblSupplier, 0, 4);
            tableFields.Controls.Add(lblQuantity, 1, 4);
            tableFields.Controls.Add(lblAmount, 2, 4);
            tableFields.Controls.Add(cmbSupplier, 0, 5);
            tableFields.Controls.Add(txtQuantity, 1, 5);
            tableFields.Controls.Add(txtAmount, 2, 5);
            tableFields.Controls.Add(lblHint, 0, 6);
            tableFields.Controls.Add(flowButtons, 0, 7);
            tableFields.Dock = DockStyle.Fill;
            tableFields.Name = "tableFields";
            tableFields.RowCount = 8;
            tableFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableFields.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableFields.TabIndex = 0;
            tableFields.SetColumnSpan(txtProductName, 2);
            tableFields.SetColumnSpan(lblProductName, 2);
            tableFields.SetColumnSpan(lblHint, 3);
            tableFields.SetColumnSpan(flowButtons, 3);
            //
            // lblProductID
            //
            lblProductID.Dock = DockStyle.Fill;
            lblProductID.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblProductID.ForeColor = Color.Silver;
            lblProductID.Name = "lblProductID";
            lblProductID.Text = "Product ID (next in sequence)";
            lblProductID.TextAlign = ContentAlignment.BottomLeft;
            //
            // lblProductIdValue
            //
            lblProductIdValue.BackColor = Color.FromArgb(60, 59, 110);
            lblProductIdValue.Dock = DockStyle.Fill;
            lblProductIdValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblProductIdValue.ForeColor = Color.White;
            lblProductIdValue.Margin = new Padding(3, 4, 12, 12);
            lblProductIdValue.Name = "lblProductIdValue";
            lblProductIdValue.Padding = new Padding(8, 0, 0, 0);
            lblProductIdValue.Text = "-";
            lblProductIdValue.TextAlign = ContentAlignment.MiddleLeft;
            //
            // lblProductName
            //
            lblProductName.Dock = DockStyle.Fill;
            lblProductName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblProductName.ForeColor = Color.Silver;
            lblProductName.Name = "lblProductName";
            lblProductName.Text = "Product Name *";
            lblProductName.TextAlign = ContentAlignment.BottomLeft;
            //
            // txtProductName
            //
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.Dock = DockStyle.Fill;
            txtProductName.Font = new Font("Segoe UI", 12F);
            txtProductName.Margin = new Padding(3, 4, 12, 12);
            txtProductName.MaxLength = 100;
            txtProductName.Name = "txtProductName";
            txtProductName.TabIndex = 0;
            //
            // lblModel
            //
            lblModel.Dock = DockStyle.Fill;
            lblModel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblModel.ForeColor = Color.Silver;
            lblModel.Name = "lblModel";
            lblModel.Text = "Model No. *";
            lblModel.TextAlign = ContentAlignment.BottomLeft;
            //
            // txtModel
            //
            txtModel.BorderStyle = BorderStyle.FixedSingle;
            txtModel.CharacterCasing = CharacterCasing.Upper;
            txtModel.Dock = DockStyle.Fill;
            txtModel.Font = new Font("Segoe UI", 12F);
            txtModel.Margin = new Padding(3, 4, 12, 12);
            txtModel.MaxLength = 50;
            txtModel.Name = "txtModel";
            txtModel.TabIndex = 1;
            //
            // lblBrand
            //
            lblBrand.Dock = DockStyle.Fill;
            lblBrand.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblBrand.ForeColor = Color.Silver;
            lblBrand.Name = "lblBrand";
            lblBrand.Text = "Brand *";
            lblBrand.TextAlign = ContentAlignment.BottomLeft;
            //
            // cmbBrand
            //
            cmbBrand.Dock = DockStyle.Fill;
            cmbBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBrand.Font = new Font("Segoe UI", 12F);
            cmbBrand.Margin = new Padding(3, 4, 12, 12);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.TabIndex = 2;
            //
            // lblCategory
            //
            lblCategory.Dock = DockStyle.Fill;
            lblCategory.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblCategory.ForeColor = Color.Silver;
            lblCategory.Name = "lblCategory";
            lblCategory.Text = "Category *";
            lblCategory.TextAlign = ContentAlignment.BottomLeft;
            //
            // cmbCategory
            //
            cmbCategory.Dock = DockStyle.Fill;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 12F);
            cmbCategory.Margin = new Padding(3, 4, 12, 12);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.TabIndex = 3;
            //
            // lblSupplier
            //
            lblSupplier.Dock = DockStyle.Fill;
            lblSupplier.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSupplier.ForeColor = Color.Silver;
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Text = "Supplier *";
            lblSupplier.TextAlign = ContentAlignment.BottomLeft;
            //
            // cmbSupplier
            //
            cmbSupplier.Dock = DockStyle.Fill;
            cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSupplier.Font = new Font("Segoe UI", 12F);
            cmbSupplier.Margin = new Padding(3, 4, 12, 12);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.TabIndex = 4;
            //
            // lblQuantity
            //
            lblQuantity.Dock = DockStyle.Fill;
            lblQuantity.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblQuantity.ForeColor = Color.Silver;
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Text = "Quantity *";
            lblQuantity.TextAlign = ContentAlignment.BottomLeft;
            //
            // txtQuantity
            //
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Dock = DockStyle.Fill;
            txtQuantity.Font = new Font("Segoe UI", 12F);
            txtQuantity.Margin = new Padding(3, 4, 12, 12);
            txtQuantity.MaxLength = 9;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.TabIndex = 5;
            txtQuantity.TextAlign = HorizontalAlignment.Right;
            //
            // lblAmount
            //
            lblAmount.Dock = DockStyle.Fill;
            lblAmount.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblAmount.ForeColor = Color.Silver;
            lblAmount.Name = "lblAmount";
            lblAmount.Text = "Price (₱) *";
            lblAmount.TextAlign = ContentAlignment.BottomLeft;
            //
            // txtAmount
            //
            txtAmount.BorderStyle = BorderStyle.FixedSingle;
            txtAmount.Dock = DockStyle.Fill;
            txtAmount.Font = new Font("Segoe UI", 12F);
            txtAmount.Margin = new Padding(3, 4, 12, 12);
            txtAmount.MaxLength = 15;
            txtAmount.Name = "txtAmount";
            txtAmount.TabIndex = 6;
            txtAmount.TextAlign = HorizontalAlignment.Right;
            //
            // lblHint
            //
            lblHint.Dock = DockStyle.Fill;
            lblHint.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            lblHint.ForeColor = Color.Silver;
            lblHint.Name = "lblHint";
            lblHint.Text = "Brand, Category and Supplier come from their own screens. Adding a product with the same name and model merges it into the existing stock.";
            lblHint.TextAlign = ContentAlignment.TopLeft;
            //
            // flowButtons
            //
            flowButtons.Controls.Add(btnCancel);
            flowButtons.Controls.Add(btnSave);
            flowButtons.Dock = DockStyle.Fill;
            flowButtons.FlowDirection = FlowDirection.RightToLeft;
            flowButtons.Name = "flowButtons";
            flowButtons.TabIndex = 7;
            //
            // btnCancel
            //
            btnCancel.BackColor = Color.FromArgb(108, 117, 125);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnCancel.IconColor = Color.White;
            btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancel.IconSize = 22;
            btnCancel.Margin = new Padding(8, 8, 12, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 44);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "CANCEL";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            //
            // btnSave
            //
            btnSave.BackColor = Color.ForestGreen;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnSave.IconColor = Color.White;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.IconSize = 22;
            btnSave.Margin = new Padding(8, 8, 0, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 44);
            btnSave.TabIndex = 7;
            btnSave.Text = "SAVE";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            //
            // InventoryManagement
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1007, 550);
            Controls.Add(tabInventoryManagement);
            Margin = new Padding(3, 2, 3, 2);
            Name = "InventoryManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Management";
            Load += InventoryManagement_Load;
            tabInventoryManagement.ResumeLayout(false);
            tabInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgProducts).EndInit();
            panelFooter.ResumeLayout(false);
            panelToolbar.ResumeLayout(false);
            panelToolbar.PerformLayout();
            tabAdd.ResumeLayout(false);
            panelCard.ResumeLayout(false);
            tableFields.ResumeLayout(false);
            tableFields.PerformLayout();
            flowButtons.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabInventoryManagement;
        private TabPage tabInventory;
        private TabPage tabAdd;
        private Panel panelToolbar;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblFilter;
        private ComboBox cmbFilter;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private DataGridView dgProducts;
        private Panel panelFooter;
        private Label lblCount;
        private Label lblLowStockNote;
        private Panel panelHeader;
        private Label lblAdding;
        private Panel panelCard;
        private TableLayoutPanel tableFields;
        private Label lblProductID;
        private Label lblProductIdValue;
        private Label lblProductName;
        private TextBox txtProductName;
        private Label lblModel;
        private TextBox txtModel;
        private Label lblBrand;
        private ComboBox cmbBrand;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblSupplier;
        private ComboBox cmbSupplier;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Label lblAmount;
        private TextBox txtAmount;
        private Label lblHint;
        private FlowLayoutPanel flowButtons;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnCancel;
    }
}
