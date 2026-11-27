using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class CategoryManagement : Form
    {
        private readonly CategoryController categoryController;
        private bool isAdd = true;
        private List<CategoryModel> categoryList = new List<CategoryModel>();
        private CategoryModel? selectedCategory;

        public CategoryManagement()
        {
            InitializeComponent();
            categoryController = new CategoryController();
            GridFormatHelper.ApplyModernStyle(dgCategories);
            dgCategories.RowTemplate.Height = 32;
        }

        private void CategoryManagement_Load(object sender, EventArgs e) => LoadData();

        private void LoadData()
        {
            categoryList = categoryController.GetAllCategories();
            BindGrid();
        }

        private void BindGrid()
        {
            string keyword = txtSearch.Text.Trim();
            var rows = categoryList
                .Where(c => keyword.Length == 0 || c.CategoryName.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();

            dgCategories.DataSource = null;
            dgCategories.DataSource = rows;

            GridFormatHelper.SetHeaders(dgCategories, ("CategoryId", "Category ID"), ("CategoryName", "Category Name"));
            GridFormatHelper.SetColumnFillWeights(dgCategories, ("CategoryId", 20), ("CategoryName", 80));

            lblCount.Text = rows.Count == categoryList.Count
                ? $"{rows.Count:N0} categories"
                : $"Showing {rows.Count:N0} of {categoryList.Count:N0} categories";

            selectedCategory = rows.FirstOrDefault();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) => BindGrid();

        private void dgCategories_SelectionChanged(object sender, EventArgs e)
        {
            selectedCategory = dgCategories.CurrentRow?.DataBoundItem as CategoryModel;
        }

        private void dgCategories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) btnUpdate_Click(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAdd = true;
            lblAdding.Text = "ADD NEW CATEGORY";
            lblCategoryIdValue.Text = "Assigned when saved";
            txtCategoryName.Text = "";
            tabCategoryManagement.SelectedTab = tabAdd;
            txtCategoryName.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCategory == null)
            {
                MessageBox.Show("Please select a category to modify.", "Category Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            isAdd = false;
            lblAdding.Text = $"MODIFY CATEGORY : {selectedCategory.CategoryName}";
            lblCategoryIdValue.Text = selectedCategory.CategoryId.ToString();
            txtCategoryName.Text = selectedCategory.CategoryName;
            tabCategoryManagement.SelectedTab = tabAdd;
            txtCategoryName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCategory == null)
            {
                MessageBox.Show("Please select a category to delete.", "Category Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Are you sure you want to delete '{selectedCategory.CategoryName}'?", "Delete Category",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            try
            {
                categoryController.Delete(selectedCategory.CategoryId);
                LoadData();
                MessageBox.Show("Category deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtCategoryName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Category Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (isAdd)
                {
                    categoryController.Add(name);
                    MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    categoryController.Update(selectedCategory!.CategoryId, name);
                    MessageBox.Show("Category updated successfully! Products in this category were updated too.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                tabCategoryManagement.SelectedTab = tabList;
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tabCategoryManagement.SelectedTab = tabList;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadData();
        }
    }
}
