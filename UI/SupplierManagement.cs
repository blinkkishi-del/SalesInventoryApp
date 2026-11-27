using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class SupplierManagement : Form
    {
        private readonly SupplierController supplierController;
        private bool isAdd = true;
        private List<SupplierModel> supplierList = new List<SupplierModel>();
        private SupplierModel? selectedSupplier;

        public SupplierManagement()
        {
            InitializeComponent();
            supplierController = new SupplierController();
            GridFormatHelper.ApplyModernStyle(dgSuppliers);
            dgSuppliers.RowTemplate.Height = 32;
        }

        private void SupplierManagement_Load(object sender, EventArgs e) => LoadData();

        private void LoadData()
        {
            supplierList = supplierController.GetAllSuppliers();
            BindGrid();
        }

        private void BindGrid()
        {
            string keyword = txtSearch.Text.Trim();
            var rows = supplierList
                .Where(s => keyword.Length == 0
                    || Has(s.SupplierId, keyword) || Has(s.SupplierName, keyword) || Has(s.ContactPerson, keyword)
                    || Has(s.PhoneNumber, keyword) || Has(s.EmailAddress, keyword) || Has(s.Address, keyword))
                .ToList();

            dgSuppliers.DataSource = null;
            dgSuppliers.DataSource = rows;

            GridFormatHelper.SetHeaders(dgSuppliers, ("SupplierId", "ID"), ("SupplierName", "Supplier"),
                ("ContactPerson", "Contact Person"), ("PhoneNumber", "Phone"), ("EmailAddress", "Email"));
            GridFormatHelper.SetColumnFillWeights(dgSuppliers, ("SupplierId", 8), ("SupplierName", 21),
                ("Address", 24), ("ContactPerson", 13), ("PhoneNumber", 14), ("EmailAddress", 19));

            lblCount.Text = rows.Count == supplierList.Count
                ? $"{rows.Count:N0} suppliers"
                : $"Showing {rows.Count:N0} of {supplierList.Count:N0} suppliers";

            selectedSupplier = rows.FirstOrDefault();
        }

        private static bool Has(string? value, string keyword) =>
            (value ?? "").Contains(keyword, StringComparison.OrdinalIgnoreCase);

        private void txtSearch_TextChanged(object sender, EventArgs e) => BindGrid();

        private void dgSuppliers_SelectionChanged(object sender, EventArgs e)
        {
            selectedSupplier = dgSuppliers.CurrentRow?.DataBoundItem as SupplierModel;
        }

        private void dgSuppliers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) btnUpdate_Click(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAdd = true;
            ClearFields();
            lblAdding.Text = "ADD NEW SUPPLIER";
            lblSupplierIdValue.Text = "Assigned when saved";
            tabSupplierManagement.SelectedTab = tabAdd;
            txtSupplierName.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedSupplier == null)
            {
                MessageBox.Show("Please select a supplier to modify.", "Supplier Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            isAdd = false;
            var s = selectedSupplier;
            lblAdding.Text = $"MODIFY SUPPLIER : {s.SupplierName}";
            lblSupplierIdValue.Text = s.SupplierId;
            txtSupplierName.Text = s.SupplierName;
            txtContactPerson.Text = s.ContactPerson;
            txtPhoneNumber.Text = s.PhoneNumber;
            txtEmailAddress.Text = s.EmailAddress;
            txtAddress.Text = s.Address;
            tabSupplierManagement.SelectedTab = tabAdd;
            txtSupplierName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedSupplier == null)
            {
                MessageBox.Show("Please select a supplier to delete.", "Supplier Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Are you sure you want to delete '{selectedSupplier.SupplierName}'?", "Delete Supplier",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            try
            {
                supplierController.Delete(selectedSupplier.SupplierId);
                LoadData();
                MessageBox.Show("Supplier deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            lblSupplierIdValue.Text = "-";
            txtSupplierName.Text = "";
            txtContactPerson.Text = "";
            txtPhoneNumber.Text = "";
            txtEmailAddress.Text = "";
            txtAddress.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtSupplierName.Text.Trim();
            string email = txtEmailAddress.Text.Trim();

            string? error =
                name.Length == 0 ? "Supplier Name cannot be empty." :
                email.Length > 0 && (!email.Contains('@') || !email.Contains('.')) ? "Please enter a valid email address." :
                null;
            if (error != null)
            {
                MessageBox.Show(error, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var supplier = new SupplierModel
            {
                SupplierName = name,
                Address = txtAddress.Text.Trim(),
                ContactPerson = txtContactPerson.Text.Trim(),
                PhoneNumber = txtPhoneNumber.Text.Trim(),
                EmailAddress = email
            };

            try
            {
                if (isAdd)
                {
                    supplierController.Add(supplier);
                    MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    supplier.SupplierId = selectedSupplier!.SupplierId;
                    supplierController.Update(supplier);
                    MessageBox.Show("Supplier updated successfully! Products from this supplier were updated too.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                tabSupplierManagement.SelectedTab = tabList;
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tabSupplierManagement.SelectedTab = tabList;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadData();
        }
    }
}
