using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class InventoryManagement : Form
    {
        private const string AllCategories = "All Categories";
        private const int LowStockThreshold = StockController.LowStockThreshold;

        private readonly ProductController productController;
        private bool isAdd = true;
        private List<ProductDetailsModel> productList = new List<ProductDetailsModel>();
        private ProductDetailsModel? selectedProduct;
        private readonly Font lowStockFont = new Font("Segoe UI", 10F, FontStyle.Bold);

        public InventoryManagement()
        {
            InitializeComponent();
            productController = new ProductController();
            GridFormatHelper.ApplyModernStyle(dgProducts);
            dgProducts.RowTemplate.Height = 32;
            dgProducts.CellFormatting += dgProducts_CellFormatting;
        }

        private void InventoryManagement_Load(object sender, EventArgs e)
        {
            LoadLookups();
            LoadData();
        }

        private void LoadLookups()
        {
            var categories = new CategoryController().GetCategoryNames();

            cmbFilter.Items.Clear();
            cmbFilter.Items.Add(AllCategories);
            cmbFilter.Items.AddRange(categories.ToArray());
            cmbFilter.SelectedIndex = 0;

            cmbCategory.Items.Clear();
            cmbCategory.Items.AddRange(categories.ToArray());

            cmbBrand.Items.Clear();
            cmbBrand.Items.AddRange(new BrandController().GetBrandNames().ToArray());

            cmbSupplier.Items.Clear();
            cmbSupplier.Items.AddRange(new SupplierController().GetAllSuppliers()
                .Select(s => s.SupplierName).OrderBy(n => n).ToArray());
        }

        private void LoadData()
        {
            productList = productController.GetAllProducts();
            BindGrid();
        }

        private void BindGrid()
        {
            string keyword = txtSearch.Text.Trim();
            string category = cmbFilter.SelectedItem as string ?? AllCategories;

            var rows = productList
                .Where(p => category == AllCategories || p.Category == category)
                .Where(p => keyword.Length == 0
                    || Has(p.ProductId, keyword) || Has(p.ProductName, keyword) || Has(p.Model, keyword)
                    || Has(p.Brand, keyword) || Has(p.Supplier, keyword))
                .ToList();

            dgProducts.DataSource = null;
            dgProducts.DataSource = rows;

            GridFormatHelper.SetHeaders(dgProducts, ("ProductId", "ID"), ("ProductName", "Product"),
                ("Quantity", "Stock"), ("Amount", "Price"));
            GridFormatHelper.FormatCurrencyColumns(dgProducts, "Amount");
            GridFormatHelper.SetColumnFillWeights(dgProducts, ("ProductId", 8), ("ProductName", 26), ("Model", 12),
                ("Brand", 10), ("Category", 14), ("Supplier", 18), ("Quantity", 6), ("Amount", 10));
            if (dgProducts.Columns.Contains("Quantity"))
                dgProducts.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            lblCount.Text = rows.Count == productList.Count
                ? $"{rows.Count:N0} products"
                : $"Showing {rows.Count:N0} of {productList.Count:N0} products";

            selectedProduct = rows.FirstOrDefault();
        }

        private static bool Has(string? value, string keyword) =>
            (value ?? "").Contains(keyword, StringComparison.OrdinalIgnoreCase);

        private void Filters_Changed(object sender, EventArgs e) => BindGrid();

        private void dgProducts_SelectionChanged(object sender, EventArgs e)
        {
            selectedProduct = dgProducts.CurrentRow?.DataBoundItem as ProductDetailsModel;
        }

        private void dgProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) btnUpdate_Click(sender, e);
        }

        private void dgProducts_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgProducts.Columns[e.ColumnIndex].Name == "Quantity" && e.Value is int qty && qty <= LowStockThreshold)
            {
                e.CellStyle.ForeColor = Color.Red;
                e.CellStyle.Font = lowStockFont;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAdd = true;
            ClearFields();
            lblAdding.Text = "ADD NEW PRODUCT";
            lblProductID.Text = "Product ID (next in sequence)";
            lblProductIdValue.Text = productController.GetNextProductId();
            SetQuantityLocked(false);
            tabInventoryManagement.SelectedTab = tabAdd;
            txtProductName.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedProduct == null)
            {
                MessageBox.Show("Please select a product to modify.", "Product Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            isAdd = false;
            var p = selectedProduct;
            lblAdding.Text = $"MODIFY PRODUCT : {p.ProductName}";
            lblProductID.Text = "Product ID";
            lblProductIdValue.Text = p.ProductId;
            txtProductName.Text = p.ProductName;
            txtModel.Text = p.Model;
            SelectOrAdd(cmbBrand, p.Brand);
            SelectOrAdd(cmbCategory, p.Category);
            SelectOrAdd(cmbSupplier, p.Supplier);
            txtQuantity.Text = p.Quantity.ToString();
            txtAmount.Text = p.Amount.ToString("F2");

            SetQuantityLocked(true);
            tabInventoryManagement.SelectedTab = tabAdd;
            txtProductName.Focus();
        }

        private static void SelectOrAdd(ComboBox combo, string? value)
        {
            if (string.IsNullOrEmpty(value)) { combo.SelectedIndex = -1; return; }
            if (!combo.Items.Contains(value)) combo.Items.Add(value);
            combo.SelectedItem = value;
        }

        private void SetQuantityLocked(bool locked)
        {
            txtQuantity.ReadOnly = locked;
            txtQuantity.TabStop = !locked;
            txtQuantity.BackColor = locked ? Color.FromArgb(60, 59, 110) : SystemColors.Window;
            txtQuantity.ForeColor = locked ? Color.White : SystemColors.WindowText;
            lblQuantity.Text = locked ? "Quantity (use Stock Entry / Adjustment)" : "Quantity *";
        }

        private void ClearFields()
        {
            lblProductIdValue.Text = "-";
            txtProductName.Text = "";
            txtModel.Text = "";
            cmbBrand.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
            cmbSupplier.SelectedIndex = -1;
            txtQuantity.Text = "";
            txtAmount.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtProductName.Text.Trim();
            string model = txtModel.Text.Trim();
            string? brand = cmbBrand.SelectedItem as string;
            string? category = cmbCategory.SelectedItem as string;
            string? supplier = cmbSupplier.SelectedItem as string;

            string? error =
                name.Length == 0 ? "Product Name cannot be empty." :
                model.Length == 0 ? "Model cannot be empty." :
                brand == null ? "Please select a brand." :
                category == null ? "Please select a category." :
                supplier == null ? "Please select a supplier." :
                !int.TryParse(txtQuantity.Text.Trim(), out int quantity) || quantity < 0 ? "Quantity must be a whole number of 0 or more." :
                !decimal.TryParse(txtAmount.Text.Trim(), out decimal amount) || amount < 0 ? "Price must be a number of 0 or more." :
                null;

            if (error != null)
            {
                MessageBox.Show(error, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var product = new ProductDetailsModel
            {
                ProductName = name,
                Model = model,
                Brand = brand,
                Category = category,
                Supplier = supplier,
                Quantity = int.Parse(txtQuantity.Text.Trim()),
                Amount = decimal.Parse(txtAmount.Text.Trim())
            };

            try
            {
                if (isAdd)
                {
                    string newId = productController.Add(product);
                    string saved = string.IsNullOrEmpty(newId) ? "Product saved." : $"Product saved as {newId}.";
                    MessageBox.Show(saved + "\n(If the same name and model already existed, the stock was added to it.)",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    product.ProductId = selectedProduct!.ProductId;
                    productController.Update(product);
                    MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                tabInventoryManagement.SelectedTab = tabInventory;
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tabInventoryManagement.SelectedTab = tabInventory;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadLookups();
            LoadData();
        }
    }
}
