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
            txtsearch = new TextBox();
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
            lbCategory = new ListBox();
            lbSupplier = new ListBox();
            txtProductID = new TextBox();
            btnSalesreport = new Button();
            btnStockreport = new Button();
            btnHome = new Button();
            lblInventoryManagement = new Label();
            lblAmount = new Label();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ControlDark;
            btnDelete.Font = new Font("Californian FB", 10.8F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1231, 16);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 37);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(254, 73);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(125, 27);
            txtsearch.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ControlDark;
            btnAdd.Font = new Font("Californian FB", 10.8F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(1031, 16);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 37);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Red;
            btnUpdate.Font = new Font("Californian FB", 10.8F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(1131, 16);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 37);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Red;
            btnSave.Font = new Font("Californian FB", 10.8F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(1131, 284);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 39);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ControlDark;
            btnCancel.Font = new Font("Californian FB", 10.8F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(1231, 284);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 39);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ControlDarkDark;
            btnSearch.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(401, 64);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(101, 43);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Californian FB", 10.8F, FontStyle.Bold);
            lblQuantity.Location = new Point(673, 221);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(77, 20);
            lblQuantity.TabIndex = 18;
            lblQuantity.Text = "Quantity";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Californian FB", 10.8F, FontStyle.Bold);
            lblCategory.Location = new Point(673, 135);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(78, 20);
            lblCategory.TabIndex = 19;
            lblCategory.Text = "Category";
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProducts.Location = new Point(254, 301);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(84, 23);
            lblProducts.TabIndex = 20;
            lblProducts.Text = "Products";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(670, 246);
            txtQuantity.Multiline = true;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(248, 36);
            txtQuantity.TabIndex = 21;
            // 
            // dgProducts
            // 
            dgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProducts.Location = new Point(254, 329);
            dgProducts.Name = "dgProducts";
            dgProducts.RowHeadersWidth = 51;
            dgProducts.Size = new Size(1062, 389);
            dgProducts.TabIndex = 22;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(254, 246);
            txtProductName.Multiline = true;
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(248, 36);
            txtProductName.TabIndex = 25;
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Font = new Font("Californian FB", 10.8F, FontStyle.Bold);
            lblProductID.Location = new Point(254, 131);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(93, 20);
            lblProductID.TabIndex = 26;
            lblProductID.Text = "Product ID";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Californian FB", 10.8F, FontStyle.Bold);
            lblProductName.Location = new Point(254, 223);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(119, 20);
            lblProductName.TabIndex = 27;
            lblProductName.Text = "Product Name";
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("Californian FB", 10.8F, FontStyle.Bold);
            lblSupplier.Location = new Point(1077, 131);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(74, 20);
            lblSupplier.TabIndex = 28;
            lblSupplier.Text = "Supplier";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(1077, 245);
            txtAmount.Multiline = true;
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(248, 37);
            txtAmount.TabIndex = 31;
            // 
            // lbCategory
            // 
            lbCategory.FormattingEnabled = true;
            lbCategory.Location = new Point(673, 158);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(248, 44);
            lbCategory.TabIndex = 32;
            // 
            // lbSupplier
            // 
            lbSupplier.FormattingEnabled = true;
            lbSupplier.Location = new Point(1077, 158);
            lbSupplier.Name = "lbSupplier";
            lbSupplier.Size = new Size(248, 44);
            lbSupplier.TabIndex = 33;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(254, 158);
            txtProductID.Multiline = true;
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(248, 36);
            txtProductID.TabIndex = 34;
            // 
            // btnSalesreport
            // 
            btnSalesreport.BackColor = SystemColors.WindowFrame;
            btnSalesreport.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalesreport.ForeColor = SystemColors.ButtonHighlight;
            btnSalesreport.Location = new Point(23, 205);
            btnSalesreport.Margin = new Padding(2);
            btnSalesreport.Name = "btnSalesreport";
            btnSalesreport.Size = new Size(183, 48);
            btnSalesreport.TabIndex = 35;
            btnSalesreport.Text = "Sales Report";
            btnSalesreport.UseVisualStyleBackColor = false;
            // 
            // btnStockreport
            // 
            btnStockreport.BackColor = SystemColors.WindowFrame;
            btnStockreport.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStockreport.ForeColor = SystemColors.ButtonHighlight;
            btnStockreport.Location = new Point(23, 119);
            btnStockreport.Margin = new Padding(2);
            btnStockreport.Name = "btnStockreport";
            btnStockreport.Size = new Size(183, 48);
            btnStockreport.TabIndex = 36;
            btnStockreport.Text = "Stock Report";
            btnStockreport.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.WindowFrame;
            btnHome.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = SystemColors.ButtonHighlight;
            btnHome.Location = new Point(23, 43);
            btnHome.Margin = new Padding(2);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(183, 48);
            btnHome.TabIndex = 37;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // lblInventoryManagement
            // 
            lblInventoryManagement.AutoSize = true;
            lblInventoryManagement.Font = new Font("Californian FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventoryManagement.Location = new Point(245, 9);
            lblInventoryManagement.Name = "lblInventoryManagement";
            lblInventoryManagement.Size = new Size(269, 32);
            lblInventoryManagement.TabIndex = 38;
            lblInventoryManagement.Text = "Inventory Mnagement";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Californian FB", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAmount.Location = new Point(1079, 221);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(72, 21);
            lblAmount.TabIndex = 39;
            lblAmount.Text = "Amount";
            // 
            // InventoryManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 730);
            Controls.Add(lblAmount);
            Controls.Add(lblInventoryManagement);
            Controls.Add(btnHome);
            Controls.Add(btnStockreport);
            Controls.Add(btnSalesreport);
            Controls.Add(txtProductID);
            Controls.Add(lbSupplier);
            Controls.Add(lbCategory);
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
            Controls.Add(txtsearch);
            Controls.Add(btnDelete);
            Name = "InventoryManagement";
            Text = "InventoryManagement";
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
        private TextBox txtsearch;
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
        private ListBox lbCategory;
        private ListBox lbSupplier;
        private TextBox txtProductID;
        private Button btnSalesreport;
        private Button btnStockreport;
        private Label lblInventoryManagement;
        private Label lblAmount;
    }
}