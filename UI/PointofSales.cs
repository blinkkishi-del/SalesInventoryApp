using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class PointofSales : Form
    {

        private readonly OrderProductController orderController;
        private readonly ProductController productController;
        private List<ProductDetailsModel> productList;
        internal UserModel CurrentUser;



        public PointofSales()
        {
            InitializeComponent();
            orderController = new OrderProductController();
            productController = new ProductController();
            txtPay.TextChanged += txtPay_TextChanged;

        }

        private void POS_Load(object sender, EventArgs e)
        {
            LoadProducts();
            RefreshReceiptGrid();
            UpdateTotalAndChange();
            dgProducts.CellDoubleClick += dgProducts_CellDoubleClick;
            dgProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProducts.MultiSelect = false;
            dgProducts.ReadOnly = true;
        }

        private void LoadProducts()
        {
            try
            {
                productList = productController.GetProductsOrderedByStock();
                dgProducts.DataSource = null;
                dgProducts.DataSource = productList;
                FormatProductGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatProductGrid()
        {
            if (dgProducts.Columns.Contains("ProductId"))
                dgProducts.Columns["ProductId"].Visible = false;
            if (dgProducts.Columns.Contains("Supplier"))
                dgProducts.Columns["Supplier"].Visible = false;
            if (dgProducts.Columns.Contains("Category"))
                dgProducts.Columns["Category"].Visible = false;
            if (dgProducts.Columns.Contains("ProductName"))
                dgProducts.Columns["ProductName"].HeaderText = "Product";
            if (dgProducts.Columns.Contains("Quantity"))
                dgProducts.Columns["Quantity"].HeaderText = "Stock";
            if (dgProducts.Columns.Contains("Amount"))
                dgProducts.Columns["Amount"].HeaderText = "Price";
            dgProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= productList.Count)
                return;
            var selectedProduct = productList[e.RowIndex];
            AddProductToOrder(selectedProduct);
        }

        private void AddProductToOrder(ProductDetailsModel product)
        {
            if (product == null) return;
            if (product.Quantity <= 0)
            {
                MessageBox.Show($"'{product.ProductName}' is out of stock!", "Stock Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var order = new OrderProductModel
            {
                ItemName = product.ProductName,
                Quantity = 1,
                Price = product.Amount
            };
            orderController.AddOrder(order);
            RefreshReceiptGrid();
            UpdateTotalAndChange();
        }

        private void RefreshReceiptGrid()
        {
            dgViewReceipt.DataSource = null;
            dgViewReceipt.DataSource = orderController.GetOrders();
        }

        private void UpdateTotalAndChange()
        {
            decimal total = 0;
            var orders = orderController.GetOrders();
            foreach (var order in orders)
                total += order.TotalPrice;
            lblTotalReceipt.Text = "Total: ₱" + total.ToString("N2");
            if (decimal.TryParse(txtPay.Text, out decimal payment))
            {
                decimal change = payment - total;
                lblChange.Text = "Change: ₱" + change.ToString("N2");
            }
            else
            {
                lblChange.Text = "Change: ₱0.00";
            }
        }

        private void txtPay_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalAndChange();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchProducts();
        }

        private void SearchProducts()
        {
            try
            {
                string keyword = txtSearch.Text.Trim();
                if (string.IsNullOrEmpty(keyword))
                    productList = productController.GetAllProducts();
                else
                    productList = productController.SearchProducts(keyword);
                dgProducts.DataSource = null;
                dgProducts.DataSource = productList;
                FormatProductGrid();
                if (productList.Count == 0)
                {
                    MessageBox.Show("No products found matching '" + keyword + "'.", "Search Result",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    productList = productController.GetAllProducts();
                    dgProducts.DataSource = null;
                    dgProducts.DataSource = productList;
                    FormatProductGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgViewReceipt.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to delete.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string name = dgViewReceipt.SelectedRows[0].Cells["ItemName"].Value?.ToString();
            if (!string.IsNullOrEmpty(name))
            {
                orderController.RemoveOrder(name);
                RefreshReceiptGrid();
                UpdateTotalAndChange();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            orderController.ClearAllOrders();
            RefreshReceiptGrid();
            UpdateTotalAndChange();
            txtPay.Clear();
            lblChange.Text = "Change: ₱0.00";
            lblTotalReceipt.Text = "Total: ₱0.00";
        }

       

        }
    }

