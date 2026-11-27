using BusinessLogic.Controller;
using Model;
using System.Data;

namespace UI
{
    public partial class StockAdjustment : Form
    {
        private const string AddAction = "Add to Inventory";
        private const string RemoveAction = "Remove from Inventory";

        private readonly ProductController productController = new ProductController();
        private readonly StockAdjustmentController adjustmentController = new StockAdjustmentController();
        private readonly string adjustedBy;

        private List<ProductDetailsModel> allProducts = new List<ProductDetailsModel>();
        private ProductDetailsModel? selectedProduct;

        public StockAdjustment(string username)
        {
            InitializeComponent();
            adjustedBy = username;
            GridFormatHelper.ApplyModernStyle(dgProducts);

            reportAdjustments.ReportTitle = "Stock Adjustment History";
            reportAdjustments.LoadData = adjustmentController.GetHistory;
            reportAdjustments.FormatGrid = grid =>
            {
                GridFormatHelper.SetHeaders(grid, ("ReferenceNo", "Reference No"), ("AdjustmentDate", "Date"),
                    ("ProductId", "Product ID"), ("ProductName", "Product"), ("Quantity", "Qty"),
                    ("AdjustedBy", "Adjusted By"));
                GridFormatHelper.FormatDateColumns(grid, "AdjustmentDate");
                GridFormatHelper.SetColumnFillWeights(grid, ("ReferenceNo", 14), ("AdjustmentDate", 14), ("ProductId", 9),
                    ("ProductName", 20), ("Action", 8), ("Quantity", 6), ("Reason", 12), ("Remarks", 10), ("AdjustedBy", 8));
            };
            reportAdjustments.Summary = dt => new[]
            {
                $"Added: {SumQuantity(dt, "Add"):N0}",
                $"Removed: {SumQuantity(dt, "Remove"):N0}"
            };
        }

        private static int SumQuantity(DataTable dt, string action) =>
            dt.AsEnumerable()
                .Where(r => r.Field<string>("Action") == action)
                .Sum(r => r.Field<int>("Quantity"));

        private void StockAdjustment_Load(object sender, EventArgs e)
        {
            lblAdjustedByValue.Text = string.IsNullOrWhiteSpace(adjustedBy) ? "N/A" : adjustedBy;

            cmbAction.Items.AddRange(new object[] { AddAction, RemoveAction });
            cmbReason.Items.AddRange(StockAdjustmentController.Reasons);

            LoadProducts();
            ClearSelection();
        }

        private void LoadProducts()
        {
            allProducts = productController.GetProductsOrderedByStock();
            BindProducts();
        }

        private void BindProducts()
        {
            string keyword = txtSearch.Text.Trim();
            var products = keyword.Length == 0
                ? allProducts
                : allProducts.Where(p =>
                        (p.ProductName ?? "").Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                        (p.Model ?? "").Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                        (p.Brand ?? "").Contains(keyword, StringComparison.OrdinalIgnoreCase))
                    .ToList();

            dgProducts.DataSource = null;
            dgProducts.DataSource = products;
            GridFormatHelper.HideColumns(dgProducts, "Category", "Supplier", "Amount");
            GridFormatHelper.SetHeaders(dgProducts, ("ProductId", "ID"), ("ProductName", "Product"), ("Quantity", "Stock"));
            GridFormatHelper.SetColumnFillWeight(dgProducts, "ProductId", 13);
            GridFormatHelper.SetColumnFillWeight(dgProducts, "ProductName", 41);
            GridFormatHelper.SetColumnFillWeight(dgProducts, "Model", 16);
            GridFormatHelper.SetColumnFillWeight(dgProducts, "Brand", 18);
            GridFormatHelper.SetColumnFillWeight(dgProducts, "Quantity", 12);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) => BindProducts();

        private void dgProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgProducts.Rows[e.RowIndex].DataBoundItem is not ProductDetailsModel product)
                return;

            selectedProduct = product;
            lblSelectedValue.Text = $"{product.ProductName} ({product.Model})";
            lblCurrentStockValue.Text = product.Quantity.ToString();
            btnSave.Enabled = true;
        }

        private void ClearSelection()
        {
            selectedProduct = null;
            lblSelectedValue.Text = "Select a product from the list";
            lblCurrentStockValue.Text = "-";
            cmbAction.SelectedIndex = -1;
            cmbReason.SelectedIndex = -1;
            nudQty.Value = 1;
            txtRemarks.Clear();
            btnSave.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearSelection();

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedProduct == null)
            {
                MessageBox.Show("Please select a product.", "Stock Adjustment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbAction.SelectedItem == null)
            {
                MessageBox.Show("Please choose whether to add or remove stock.", "Stock Adjustment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool add = (string)cmbAction.SelectedItem == AddAction;
            int qty = (int)nudQty.Value;

            if (!add && qty > selectedProduct.Quantity)
            {
                MessageBox.Show($"Cannot remove {qty}. Only {selectedProduct.Quantity} in stock.",
                    "Stock Adjustment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string verb = add ? "Add" : "Remove";
            if (MessageBox.Show($"{verb} {qty} unit(s) {(add ? "to" : "from")} {selectedProduct.ProductName}?",
                    "Confirm Adjustment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                string referenceNo = adjustmentController.Save(selectedProduct.ProductId, add, qty,
                    cmbReason.SelectedItem?.ToString(), txtRemarks.Text, adjustedBy);

                MessageBox.Show($"Stock adjusted.\nReference No: {referenceNo}", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearSelection();
                LoadProducts();
                reportAdjustments.Reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adjustment failed. Nothing was saved.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
