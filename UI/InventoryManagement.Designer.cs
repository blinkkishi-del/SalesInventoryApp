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
            btnDelete = new Button();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            btnSearch = new Button();
            lblQuantity = new Label();
            lblCategory = new Label();
            lblProducts = new Label();
            txtQuantity = new TextBox();
            dgProducts = new DataGridView();
            txtProductName = new TextBox();
            lblProductID = new Label();
            lblProductName = new Label();
            lblSupplier = new Label();
            txtAmount = new TextBox();
            txtProductID = new TextBox();
            btnSalesreport = new Button();
            btnStockreport = new Button();
            btnHome = new Button();
            lblInventoryManagement = new Label();
            lblAmount = new Label();
            cmbSupplier = new ComboBox();
            cmbCategory = new ComboBox();
            btnRefresh = new Button();
            cmbFilter = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ControlDark;
            btnDelete.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1077, 12);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 28);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(222, 55);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(110, 23);
            txtSearch.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ControlDark;
            btnAdd.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(902, 12);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 28);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Red;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(990, 12);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 28);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Red;
            btnSave.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(990, 213);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 29);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ControlDark;
            btnCancel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(1077, 213);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 29);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ControlDarkDark;
            btnSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(351, 48);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(88, 32);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            lblQuantity.Location = new Point(589, 166);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(70, 18);
            lblQuantity.TabIndex = 18;
            lblQuantity.Text = "Quantity";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            lblCategory.Location = new Point(589, 101);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(76, 18);
            lblCategory.TabIndex = 19;
            lblCategory.Text = "Category";
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProducts.Location = new Point(222, 226);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(80, 20);
            lblProducts.TabIndex = 20;
            lblProducts.Text = "Products";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(586, 184);
            txtQuantity.Margin = new Padding(3, 2, 3, 2);
            txtQuantity.Multiline = true;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(218, 28);
            txtQuantity.TabIndex = 21;
            // 
            // dgProducts
            // 
            dgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProducts.Location = new Point(222, 247);
            dgProducts.Margin = new Padding(3, 2, 3, 2);
            dgProducts.Name = "dgProducts";
            dgProducts.RowHeadersWidth = 51;
            dgProducts.Size = new Size(929, 292);
            dgProducts.TabIndex = 22;
            dgProducts.CellClick += dgProducts_CellClick;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(222, 184);
            txtProductName.Margin = new Padding(3, 2, 3, 2);
            txtProductName.Multiline = true;
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(218, 28);
            txtProductName.TabIndex = 25;
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            lblProductID.Location = new Point(222, 98);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(88, 18);
            lblProductID.TabIndex = 26;
            lblProductID.Text = "Product ID";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            lblProductName.Location = new Point(222, 167);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(116, 18);
            lblProductName.TabIndex = 27;
            lblProductName.Text = "Product Name";
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            lblSupplier.Location = new Point(942, 98);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(69, 18);
            lblSupplier.TabIndex = 28;
            lblSupplier.Text = "Supplier";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(942, 184);
            txtAmount.Margin = new Padding(3, 2, 3, 2);
            txtAmount.Multiline = true;
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(218, 29);
            txtAmount.TabIndex = 31;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(222, 118);
            txtProductID.Margin = new Padding(3, 2, 3, 2);
            txtProductID.Multiline = true;
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(218, 28);
            txtProductID.TabIndex = 34;
            // 
            // btnSalesreport
            // 
            btnSalesreport.BackColor = SystemColors.WindowFrame;
            btnSalesreport.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalesreport.ForeColor = SystemColors.ButtonHighlight;
            btnSalesreport.Location = new Point(20, 154);
            btnSalesreport.Margin = new Padding(2);
            btnSalesreport.Name = "btnSalesreport";
            btnSalesreport.Size = new Size(160, 36);
            btnSalesreport.TabIndex = 35;
            btnSalesreport.Text = "Sales Report";
            btnSalesreport.UseVisualStyleBackColor = false;
            // 
            // btnStockreport
            // 
            btnStockreport.BackColor = SystemColors.WindowFrame;
            btnStockreport.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStockreport.ForeColor = SystemColors.ButtonHighlight;
            btnStockreport.Location = new Point(20, 89);
            btnStockreport.Margin = new Padding(2);
            btnStockreport.Name = "btnStockreport";
            btnStockreport.Size = new Size(160, 36);
            btnStockreport.TabIndex = 36;
            btnStockreport.Text = "Stock Report";
            btnStockreport.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.WindowFrame;
            btnHome.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = SystemColors.ButtonHighlight;
            btnHome.Location = new Point(20, 32);
            btnHome.Margin = new Padding(2);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(160, 36);
            btnHome.TabIndex = 37;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // lblInventoryManagement
            // 
            lblInventoryManagement.AutoSize = true;
            lblInventoryManagement.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventoryManagement.Location = new Point(214, 7);
            lblInventoryManagement.Name = "lblInventoryManagement";
            lblInventoryManagement.Size = new Size(241, 26);
            lblInventoryManagement.TabIndex = 38;
            lblInventoryManagement.Text = "Inventory Mnagement";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAmount.Location = new Point(944, 166);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(59, 18);
            lblAmount.TabIndex = 39;
            lblAmount.Text = "Amount";
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(940, 118);
            cmbSupplier.Margin = new Padding(3, 2, 3, 2);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(220, 23);
            cmbSupplier.TabIndex = 40;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(586, 118);
            cmbCategory.Margin = new Padding(3, 2, 3, 2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(218, 23);
            cmbCategory.TabIndex = 41;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ControlDarkDark;
            btnRefresh.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(469, 210);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(88, 32);
            btnRefresh.TabIndex = 42;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Location = new Point(504, 52);
            cmbFilter.Margin = new Padding(3, 2, 3, 2);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(179, 23);
            cmbFilter.TabIndex = 43;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label1.Location = new Point(504, 32);
            label1.Name = "label1";
            label1.Size = new Size(46, 18);
            label1.TabIndex = 44;
            label1.Text = "Filter";
            // 
            // InventoryManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 548);
            Controls.Add(label1);
            Controls.Add(cmbFilter);
            Controls.Add(btnRefresh);
            Controls.Add(cmbCategory);
            Controls.Add(cmbSupplier);
            Controls.Add(lblAmount);
            Controls.Add(lblInventoryManagement);
            Controls.Add(btnHome);
            Controls.Add(btnStockreport);
            Controls.Add(btnSalesreport);
            Controls.Add(txtProductID);
            Controls.Add(txtAmount);
            Controls.Add(lblSupplier);
            Controls.Add(lblProductName);
            Controls.Add(lblProductID);
            Controls.Add(txtProductName);
            Controls.Add(dgProducts);
            Controls.Add(txtQuantity);
            Controls.Add(lblProducts);
            Controls.Add(lblCategory);
            Controls.Add(lblQuantity);
            Controls.Add(btnSearch);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Margin = new Padding(3, 2, 3, 2);
            Name = "InventoryManagement";
            Text = "InventoryManagement";
            Load += InventoryManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button btnDelete;
        private DataGridView dataGridView1;
        private TextBox txtSearch;
        private TextBox textBox2;
        private TextBox txtRestocks;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnSave;
        private Button btnCancel;
        private Button btnHome;
        private Button btnSearch;
        private Label lblQuantity;
        private Label lblCategory;
        private Label lblProducts;
        private TextBox txtQuantity;
        private DataGridView dgProducts;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox txtProductName;
        private Label lblProductID;
        private Label lblProductName;
        private Label lblSupplier;
        private TextBox txtSupplier;
        private Label lblAmmount;
        private TextBox txtAmount;
        private TextBox txtProductID;
        private Button btnSalesreport;
        private Button btnStockreport;
        private Label lblInventoryManagement;
        private Label lblAmount;
        private ComboBox cmbSupplier;
        private ComboBox cmbCategory;
        private Button btnRefresh;
        private ComboBox cmbFilter;
        private Label label1;
    }
}