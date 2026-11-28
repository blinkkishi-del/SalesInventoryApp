using BusinessLogic.Controller;
using Model;
using System.ComponentModel;

namespace UI
{
    public partial class StockEntry : Form
    {
        private readonly ProductController productController = new ProductController();
        private readonly SupplierController supplierController = new SupplierController();
        private readonly StockInController stockInController = new StockInController();
        private readonly string stockInBy;

        private readonly string? reorderProductId;
        private readonly string? reorderSupplierName;

        private List<ProductDetailsModel> allProducts = new List<ProductDetailsModel>();
        private List<SupplierModel> suppliers = new List<SupplierModel>();
        private readonly BindingList<StockInLineModel> entryLines = new BindingList<StockInLineModel>();

        public StockEntry(string username)
        {
            InitializeComponent();
            stockInBy = username;
            GridFormatHelper.ApplyModernStyle(dgProducts);
            GridFormatHelper.ApplyModernStyle(dgEntry);
            dgProducts.CellFormatting += dgProducts_CellFormatting;
        }

        private void dgProducts_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || dgProducts.Columns[e.ColumnIndex].DataPropertyName != "Quantity") return;
            if (e.Value is int stock && stock <= StockController.LowStockThreshold)
            {
                e.CellStyle.ForeColor = Color.Red;
                e.CellStyle.Font = new Font(dgProducts.Font, FontStyle.Bold);
            }
        }

        public StockEntry(string username, string productId, string supplierName) : this(username)
        {
            reorderProductId = productId;
            reorderSupplierName = supplierName;
        }

        private void StockEntry_Load(object sender, EventArgs e)
        {
            lblStockInByValue.Text = string.IsNullOrWhiteSpace(stockInBy) ? "N/A" : stockInBy;
            lblDateValue.Text = DateTime.Now.ToString("MMMM dd, yyyy");

            LoadSuppliers();
            LoadProducts();

            dgEntry.DataSource = entryLines;
            GridFormatHelper.SetHeaders(dgEntry, ("ProductId", "Product ID"), ("ProductName", "Product"), ("Quantity", "Qty"));
            GridFormatHelper.SetColumnFillWeight(dgEntry, "ProductId", 20);
            GridFormatHelper.SetColumnFillWeight(dgEntry, "ProductName", 45);
            GridFormatHelper.SetColumnFillWeight(dgEntry, "Model", 20);
            GridFormatHelper.SetColumnFillWeight(dgEntry, "Quantity", 15);

            if (reorderProductId != null) PreselectReorder();
        }

        private void PreselectReorder()
        {
            var supplier = suppliers.FirstOrDefault(s => s.SupplierName == reorderSupplierName);
            if (supplier != null) cmbSupplier.SelectedItem = supplier;

            foreach (DataGridViewRow row in dgProducts.Rows)
            {
                if (row.DataBoundItem is ProductDetailsModel p && p.ProductId == reorderProductId)
                {
                    dgProducts.CurrentCell = row.Cells[dgProducts.Columns["ProductName"].Index];
                    row.Selected = true;
                    break;
                }
            }
            BeginInvoke(() => { nudQty.Focus(); nudQty.Select(0, nudQty.Text.Length); });
        }

        private void LoadSuppliers()
        {
            suppliers = supplierController.GetAllSuppliers();
            cmbSupplier.DataSource = suppliers;
            cmbSupplier.DisplayMember = "SupplierName";
            cmbSupplier.ValueMember = "SupplierId";
            cmbSupplier.SelectedIndex = -1;
            lblSupplierInfo.Text = "";
        }

        private void LoadProducts()
        {
            allProducts = productController.GetProductsOrderedByStock();
            BindProducts(FilterProducts(txtSearch.Text));
        }

        private List<ProductDetailsModel> FilterProducts(string keyword)
        {
            keyword = keyword?.Trim() ?? "";
            if (keyword.Length == 0) return allProducts;
            return allProducts.Where(p =>
                    (p.ProductName ?? "").Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                    (p.Model ?? "").Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                    (p.Brand ?? "").Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        private void BindProducts(List<ProductDetailsModel> products)
        {
            dgProducts.DataSource = null;
            dgProducts.DataSource = products;
            GridFormatHelper.HideColumns(dgProducts, "Category", "Supplier", "Amount");
            GridFormatHelper.SetHeaders(dgProducts, ("ProductId", "ID"), ("ProductName", "Product"), ("Quantity", "Stock"));
            foreach (string column in new[] { "ProductId", "Model", "Brand", "Quantity" })
                if (dgProducts.Columns[column] is DataGridViewColumn fit)
                    fit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            if (dgProducts.Columns["ProductName"] is DataGridViewColumn name)
            {
                name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                name.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
            dgProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BindProducts(FilterProducts(txtSearch.Text));
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSupplier.SelectedItem is SupplierModel supplier)
                lblSupplierInfo.Text = $"Contact: {supplier.ContactPerson}   |   Address: {supplier.Address}";
            else
                lblSupplierInfo.Text = "";
        }

        private void AddSelectedProductToList()
        {
            if (dgProducts.CurrentRow?.DataBoundItem is not ProductDetailsModel product)
            {
                MessageBox.Show("Please select a product first.", "Stock Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int qty = (int)nudQty.Value;
            var existing = entryLines.FirstOrDefault(l => l.ProductId == product.ProductId);
            if (existing != null)
            {
                existing.Quantity += qty;
                entryLines.ResetBindings();
            }
            else
            {
                entryLines.Add(new StockInLineModel
                {
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    Model = product.Model,
                    Quantity = qty
                });
            }
            nudQty.Value = 1;
        }

        private void btnAddToList_Click(object sender, EventArgs e) => AddSelectedProductToList();

        private void dgProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) AddSelectedProductToList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgEntry.CurrentRow?.DataBoundItem is StockInLineModel line)
                entryLines.Remove(line);
            else
                MessageBox.Show("Please select an item in the entry list to remove.", "Stock Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearEntry();
        }

        private void ClearEntry()
        {
            entryLines.Clear();
            cmbSupplier.SelectedIndex = -1;
            cmbSupplier.SelectedIndex = -1;
            nudQty.Value = 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbSupplier.SelectedValue is not string supplierId)
            {
                MessageBox.Show("Please select a supplier.", "Stock Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (entryLines.Count == 0)
            {
                MessageBox.Show("Add at least one product to the entry list.", "Stock Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int totalQty = entryLines.Sum(l => l.Quantity);
            if (MessageBox.Show($"Save this stock entry?\n\n{entryLines.Count} product(s), {totalQty} unit(s) from {cmbSupplier.Text}.",
                    "Confirm Stock Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                string referenceNo = stockInController.SaveStockIn(supplierId, stockInBy, entryLines);
                MessageBox.Show($"Stock entry saved.\nReference No: {referenceNo}", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearEntry();
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stock entry failed. Nothing was saved.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
