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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tabInventoryManagement = new TabControl();
            tabInventory = new TabPage();
            lblFilter = new Label();
            cmbFilter = new ComboBox();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            btnSearch = new FontAwesome.Sharp.IconButton();
            btnUpdate = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            btnAdd = new FontAwesome.Sharp.IconButton();
            txtSearch = new TextBox();
            dgProducts = new DataGridView();
            tabAdd = new TabPage();
            panel3 = new Panel();
            cmbSupplier = new ComboBox();
            lblSupplier = new Label();
            cmbCategory = new ComboBox();
            txtAmount = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            txtProductID = new TextBox();
            lblProductID = new Label();
            lblProductName = new Label();
            lblAmount = new Label();
            lblCategory = new Label();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            txtProductName = new TextBox();
            panel2 = new Panel();
            lblAdding = new Label();
            tabInventoryManagement.SuspendLayout();
            tabInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
            tabAdd.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabInventoryManagement
            // 
            tabInventoryManagement.Controls.Add(tabInventory);
            tabInventoryManagement.Controls.Add(tabAdd);
            tabInventoryManagement.Location = new Point(0, -26);
            tabInventoryManagement.Name = "tabInventoryManagement";
            tabInventoryManagement.SelectedIndex = 0;
            tabInventoryManagement.Size = new Size(1104, 663);
            tabInventoryManagement.TabIndex = 46;
            // 
            // tabInventory
            // 
            tabInventory.BackColor = Color.FromArgb(34, 33, 74);
            tabInventory.Controls.Add(lblFilter);
            tabInventory.Controls.Add(cmbFilter);
            tabInventory.Controls.Add(btnRefresh);
            tabInventory.Controls.Add(btnSearch);
            tabInventory.Controls.Add(btnUpdate);
            tabInventory.Controls.Add(btnDelete);
            tabInventory.Controls.Add(btnAdd);
            tabInventory.Controls.Add(txtSearch);
            tabInventory.Controls.Add(dgProducts);
            tabInventory.ForeColor = Color.Black;
            tabInventory.Location = new Point(4, 24);
            tabInventory.Name = "tabInventory";
            tabInventory.Padding = new Padding(3);
            tabInventory.Size = new Size(1096, 635);
            tabInventory.TabIndex = 0;
            tabInventory.Text = "tabInventory";
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            lblFilter.ForeColor = Color.White;
            lblFilter.Location = new Point(332, 17);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(46, 18);
            lblFilter.TabIndex = 58;
            lblFilter.Text = "Filter";
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Location = new Point(332, 37);
            cmbFilter.Margin = new Padding(3, 2, 3, 2);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(156, 23);
            cmbFilter.TabIndex = 57;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.Silver;
            btnRefresh.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            btnRefresh.IconColor = Color.Black;
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.IconSize = 23;
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(523, 22);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(107, 38);
            btnRefresh.TabIndex = 56;
            btnRefresh.Text = "REFRESH";
            btnRefresh.TextAlign = ContentAlignment.MiddleRight;
            btnRefresh.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Silver;
            btnSearch.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.Black;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnSearch.IconColor = Color.Black;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 23;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(209, 22);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(117, 38);
            btnSearch.TabIndex = 55;
            btnSearch.Text = "SEARCH";
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(0, 192, 192);
            btnUpdate.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            btnUpdate.IconColor = Color.Black;
            btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUpdate.IconSize = 23;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(796, 22);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(96, 38);
            btnUpdate.TabIndex = 54;
            btnUpdate.Text = "MODIFY";
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdate.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.OrangeRed;
            btnDelete.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            btnDelete.IconColor = Color.Black;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.IconSize = 23;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(898, 22);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(93, 38);
            btnDelete.TabIndex = 53;
            btnDelete.Text = "DELETE";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.MediumSeaGreen;
            btnAdd.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Black;
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            btnAdd.IconColor = Color.Black;
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.IconSize = 23;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(683, 22);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 38);
            btnAdd.TabIndex = 52;
            btnAdd.Text = "ADD NEW";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.Location = new Point(8, 33);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Items Here";
            txtSearch.Size = new Size(195, 27);
            txtSearch.TabIndex = 50;
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
            dgProducts.Location = new Point(8, 65);
            dgProducts.Margin = new Padding(3, 2, 3, 2);
            dgProducts.Name = "dgProducts";
            dgProducts.RowHeadersWidth = 51;
            dgProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProducts.Size = new Size(983, 476);
            dgProducts.TabIndex = 51;
            // 
            // tabAdd
            // 
            tabAdd.BackColor = Color.FromArgb(34, 33, 74);
            tabAdd.Controls.Add(panel3);
            tabAdd.Controls.Add(panel2);
            tabAdd.ForeColor = Color.FromArgb(34, 33, 74);
            tabAdd.Location = new Point(4, 24);
            tabAdd.Name = "tabAdd";
            tabAdd.Padding = new Padding(3);
            tabAdd.Size = new Size(1096, 635);
            tabAdd.TabIndex = 1;
            tabAdd.Text = "tabAdd";
            // 
            // panel3
            // 
            panel3.Controls.Add(cmbSupplier);
            panel3.Controls.Add(lblSupplier);
            panel3.Controls.Add(cmbCategory);
            panel3.Controls.Add(txtAmount);
            panel3.Controls.Add(btnCancel);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(txtProductID);
            panel3.Controls.Add(lblProductID);
            panel3.Controls.Add(lblProductName);
            panel3.Controls.Add(lblAmount);
            panel3.Controls.Add(lblCategory);
            panel3.Controls.Add(lblQuantity);
            panel3.Controls.Add(txtQuantity);
            panel3.Controls.Add(txtProductName);
            panel3.Location = new Point(3, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(1004, 485);
            panel3.TabIndex = 48;
            // 
            // cmbSupplier
            // 
            cmbSupplier.Font = new Font("Arial", 16.25F);
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(41, 360);
            cmbSupplier.Margin = new Padding(3, 2, 3, 2);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(344, 33);
            cmbSupplier.TabIndex = 54;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblSupplier.ForeColor = Color.White;
            lblSupplier.Location = new Point(41, 308);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(99, 25);
            lblSupplier.TabIndex = 50;
            lblSupplier.Text = "Supplier";
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Arial", 16.25F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(337, 248);
            cmbCategory.Margin = new Padding(3, 2, 3, 2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(344, 33);
            cmbCategory.TabIndex = 55;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Arial", 16.25F);
            txtAmount.Location = new Point(660, 100);
            txtAmount.Margin = new Padding(3, 2, 3, 2);
            txtAmount.Multiline = true;
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(243, 37);
            txtAmount.TabIndex = 51;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ControlDark;
            btnCancel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(700, 350);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(98, 38);
            btnCancel.TabIndex = 43;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.ForestGreen;
            btnSave.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(516, 344);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 49);
            btnSave.TabIndex = 42;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtProductID
            // 
            txtProductID.Font = new Font("Arial", 16.25F);
            txtProductID.Location = new Point(41, 100);
            txtProductID.Margin = new Padding(3, 2, 3, 2);
            txtProductID.Multiline = true;
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(243, 37);
            txtProductID.TabIndex = 52;
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblProductID.ForeColor = Color.White;
            lblProductID.Location = new Point(41, 50);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(122, 25);
            lblProductID.TabIndex = 48;
            lblProductID.Text = "Product ID";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblProductName.ForeColor = Color.White;
            lblProductName.Location = new Point(31, 182);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(160, 25);
            lblProductName.TabIndex = 49;
            lblProductName.Text = "Product Name";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblAmount.ForeColor = Color.White;
            lblAmount.Location = new Point(660, 50);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(91, 25);
            lblAmount.TabIndex = 53;
            lblAmount.Text = "Amount";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblCategory.ForeColor = Color.White;
            lblCategory.Location = new Point(337, 182);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(107, 25);
            lblCategory.TabIndex = 45;
            lblCategory.Text = "Category";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblQuantity.ForeColor = Color.White;
            lblQuantity.Location = new Point(337, 50);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(100, 25);
            lblQuantity.TabIndex = 44;
            lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Arial", 16.25F);
            txtQuantity.Location = new Point(337, 100);
            txtQuantity.Margin = new Padding(3, 2, 3, 2);
            txtQuantity.Multiline = true;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(243, 37);
            txtQuantity.TabIndex = 46;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Arial", 16.25F);
            txtProductName.Location = new Point(41, 248);
            txtProductName.Margin = new Padding(3, 2, 3, 2);
            txtProductName.Multiline = true;
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(243, 37);
            txtProductName.TabIndex = 47;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblAdding);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1090, 70);
            panel2.TabIndex = 47;
            // 
            // lblAdding
            // 
            lblAdding.AutoSize = true;
            lblAdding.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdding.ForeColor = Color.White;
            lblAdding.Location = new Point(18, 21);
            lblAdding.Name = "lblAdding";
            lblAdding.Size = new Size(245, 29);
            lblAdding.TabIndex = 0;
            lblAdding.Text = "ADDING PRODUCT :";
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
            Text = "InventoryManagement";
            Load += InventoryManagement_Load;
            tabInventoryManagement.ResumeLayout(false);
            tabInventory.ResumeLayout(false);
            tabInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgProducts).EndInit();
            tabAdd.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private DataGridView dataGridView1;
        private TextBox txtRestocks;
        private TextBox txtSupplier;
        private Label lblAmmount;
        private TabControl tabInventoryManagement;
        private TabPage tabInventory;
        private TabPage tabAdd;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnAdd;
        private TextBox txtSearch;
        private DataGridView dgProducts;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private Label lblFilter;
        private ComboBox cmbFilter;
        private Label lblAdding;
        private Panel panel3;
        private ComboBox cmbSupplier;
        private Label lblSupplier;
        private ComboBox cmbCategory;
        private TextBox txtAmount;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtProductID;
        private Label lblProductID;
        private Label lblProductName;
        private Label lblAmount;
        private Label lblCategory;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private TextBox txtProductName;
    }
}