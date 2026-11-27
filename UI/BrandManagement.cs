using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class BrandManagement : Form
    {
        private readonly BrandController brandController;
        private bool isAdd = true;
        private List<BrandModel> brandList = new List<BrandModel>();
        private BrandModel? selectedBrand;

        public BrandManagement()
        {
            InitializeComponent();
            brandController = new BrandController();
            GridFormatHelper.ApplyModernStyle(dgBrands);
            dgBrands.RowTemplate.Height = 32;
        }

        private void BrandManagement_Load(object sender, EventArgs e) => LoadData();

        private void LoadData()
        {
            brandList = brandController.GetAllBrands();
            BindGrid();
        }

        private void BindGrid()
        {
            string keyword = txtSearch.Text.Trim();
            var rows = brandList
                .Where(c => keyword.Length == 0 || c.BrandName.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();

            dgBrands.DataSource = null;
            dgBrands.DataSource = rows;

            GridFormatHelper.SetHeaders(dgBrands, ("BrandId", "Brand ID"), ("BrandName", "Brand Name"));
            GridFormatHelper.SetColumnFillWeights(dgBrands, ("BrandId", 20), ("BrandName", 80));

            lblCount.Text = rows.Count == brandList.Count
                ? $"{rows.Count:N0} brands"
                : $"Showing {rows.Count:N0} of {brandList.Count:N0} brands";

            selectedBrand = rows.FirstOrDefault();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) => BindGrid();

        private void dgBrands_SelectionChanged(object sender, EventArgs e)
        {
            selectedBrand = dgBrands.CurrentRow?.DataBoundItem as BrandModel;
        }

        private void dgBrands_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) btnUpdate_Click(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAdd = true;
            lblAdding.Text = "ADD NEW BRAND";
            lblBrandIdValue.Text = "Assigned when saved";
            txtBrandName.Text = "";
            tabBrandManagement.SelectedTab = tabAdd;
            txtBrandName.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedBrand == null)
            {
                MessageBox.Show("Please select a brand to modify.", "Brand Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            isAdd = false;
            lblAdding.Text = $"MODIFY BRAND : {selectedBrand.BrandName}";
            lblBrandIdValue.Text = selectedBrand.BrandId.ToString();
            txtBrandName.Text = selectedBrand.BrandName;
            tabBrandManagement.SelectedTab = tabAdd;
            txtBrandName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedBrand == null)
            {
                MessageBox.Show("Please select a brand to delete.", "Brand Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Are you sure you want to delete '{selectedBrand.BrandName}'?", "Delete Brand",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            try
            {
                brandController.Delete(selectedBrand.BrandId);
                LoadData();
                MessageBox.Show("Brand deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtBrandName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Brand Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (isAdd)
                {
                    brandController.Add(name);
                    MessageBox.Show("Brand added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    brandController.Update(selectedBrand!.BrandId, name);
                    MessageBox.Show("Brand updated successfully! Products in this brand were updated too.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                tabBrandManagement.SelectedTab = tabList;
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tabBrandManagement.SelectedTab = tabList;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadData();
        }
    }
}
