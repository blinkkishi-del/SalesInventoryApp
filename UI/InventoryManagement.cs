using BusinessLogic.Controller;
using Model;
using System.Data;


namespace UI
{
    public partial class InventoryManagement : Form
    {

        private readonly ProductController productController;
        private bool isAdd = true;
        private List<ProductDetailsModel> productList = new List<ProductDetailsModel>();


        public InventoryManagement()
        {
            InitializeComponent();
            productController = new ProductController();
        }


        private void LoadCategories()
        {
            List<string> categories = new List<string>()
         {
                 "Pencil","NoteBooks"
         };
            cmbCategory.Items.Clear();
            cmbFilter.Items.Clear();

            cmbCategory.Items.AddRange(categories.ToArray());
            cmbFilter.Items.AddRange(categories.ToArray());


        }

        private void InitialState()
        {
            LoadData();
            EnableControls(false);

            if (dgProducts.Rows.Count > 0)
            {
                dgProducts.Rows[0].Selected = true;
                DisplaySelectedProduct(0);
            }
        }



        private void DisplaySelectedProduct(int index)
        {
            if (index >= 0 && index < productList.Count)
            {
                var product = productList[index];
                txtProductID.Text = product.ProductId.ToString();
                txtProductName.Text = product.ProductName;

                if (!cmbCategory.Items.Contains(product.Category))
                    cmbCategory.Items.Add(product.Category);
                cmbCategory.SelectedItem = product.Category;

                if (!cmbSupplier.Items.Contains(product.Supplier))
                    cmbSupplier.Items.Add(product.Supplier);
                cmbSupplier.SelectedItem = product.Supplier;

                txtQuantity.Text = product.Quantity.ToString();
                txtAmount.Text = product.Amount.ToString("F2");
            }
        }





        private string GenerateRandomProductId()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();
        }


        private void LoadData()
        {
            productList = productController.GetAllProducts();
            dgProducts.DataSource = null;
            dgProducts.DataSource = productList;
            ExpandColumns(dgProducts, true);

            cmbCategory.Items.Clear();
            cmbSupplier.Items.Clear();

            var categories = productList.Select(p => p.Category).Distinct().ToList();
            var suppliers = productList.Select(p => p.Supplier).Distinct().ToList();

            cmbCategory.Items.AddRange(categories.ToArray());
            cmbSupplier.Items.AddRange(suppliers.ToArray());

        }

        public void ExpandColumns(DataGridView source, bool sizable = true)
        {
            foreach (DataGridViewColumn col in source.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }


        private void EnableControls(bool enabled)
        {
            btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnRefresh.Enabled = !enabled;
            btnSave.Enabled = btnCancel.Enabled = enabled;

            foreach (Control control in dgProducts.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (textBox.Name == "txtProductID")
                        textBox.ReadOnly = true;
                    else
                        textBox.ReadOnly = !enabled;
                }
                else if (control is ComboBox comboBox)
                    comboBox.Enabled = enabled;
                else if (control is DateTimePicker dtp)
                    dtp.Enabled = enabled;
            }
        }


        private void ClearFields()
        {
            txtProductName.Text = "";
            cmbCategory.SelectedIndex = -1;
            cmbSupplier.SelectedIndex = -1;
            txtQuantity.Text = "";
            txtAmount.Text = "";
        }



        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboardForm = new AdminDashboard();
            adminDashboardForm.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearFields();
            dgProducts.ClearSelection();
            EnableControls(true);
            isAdd = true;

            string randomId = GenerateRandomProductId();
            txtProductID.Text = randomId;
            txtProductName.Focus();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductID.Text))
            {
                MessageBox.Show("Please select a product to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EnableControls(true);
            isAdd = false;
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductID.Text))
            {
                MessageBox.Show("Please select a product to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Are you sure you want to delete this product?", "Warning",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                string productId = txtProductID.Text.Trim();
                productController.Delete(productId);

                LoadData();
                ClearFields();
                MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtProductName.Text.Trim();
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Product Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string category = cmbCategory.Text.Trim();
                string supplier = cmbSupplier.Text.Trim();

                if (!int.TryParse(txtQuantity.Text.Trim(), out int quantity) || quantity < 0)
                {
                    MessageBox.Show("Invalid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtAmount.Text.Trim(), out decimal amount) || amount < 0)
                {
                    MessageBox.Show("Invalid amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var product = new ProductDetailsModel
                {
                    ProductName = name,
                    Category = category,
                    Supplier = supplier,
                    Quantity = quantity,
                    Amount = amount
                };

                if (isAdd)
                {
                    productController.Add(product);
                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    product.ProductId = txtProductID.Text;
                    productController.Update(product);
                    MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                InitialState();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            InitialState();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            InitialState();
        }

        private void InventoryManagement_Load(object sender, EventArgs e)
        {
            InitialState();
            LoadCategories();
            dgProducts.AutoGenerateColumns = true;
            dgProducts.CellClick += dgProducts_CellClick;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
        }

        private void dgProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplaySelectedProduct(e.RowIndex);
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilter.SelectedItem == null)
                return;

            string selectedCategory = cmbFilter.SelectedItem.ToString();


            var filteredList = productList
                .Where(p => p.Category == selectedCategory)
                .ToList();

            dgProducts.DataSource = null;
            dgProducts.DataSource = filteredList;
            ExpandColumns(dgProducts, true);

            if (filteredList.Count > 0)
            {
                dgProducts.Rows[0].Selected = true;
                DisplaySelectedProduct(0);
            }
            else
            {
                ClearFields();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtSearch.Text.Trim();
                productList = productController.SearchProducts(keyword);

                dgProducts.DataSource = null;
                dgProducts.DataSource = productList;
                ExpandColumns(dgProducts, true);

                if (productList.Count > 0)
                {
                    dgProducts.Rows[0].Selected = true;
                    DisplaySelectedProduct(0);
                }
                else
                {
                    ClearFields();
                    MessageBox.Show("No products found matching your search.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during search: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtSearch.Text = "";
        }
    }
}
