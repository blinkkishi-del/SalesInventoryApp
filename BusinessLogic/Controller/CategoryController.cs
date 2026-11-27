using BusinessLogic.Repository;
using Model;

namespace BusinessLogic.Controller
{
    public class CategoryController
    {
        private readonly CategoryRepository categoryRepository;

        public CategoryController()
        {
            categoryRepository = new CategoryRepository();
        }

        public List<CategoryModel> GetAllCategories() => categoryRepository.GetAll();

        public List<string> GetCategoryNames() => categoryRepository.GetAll().Select(c => c.CategoryName).ToList();

        public void Add(string categoryName)
        {
            if (string.IsNullOrWhiteSpace(categoryName)) throw new Exception("Category name cannot be empty.");
            categoryRepository.AddCategory(categoryName.Trim());
        }

        public void Update(int categoryId, string newName)
        {
            if (string.IsNullOrWhiteSpace(newName)) throw new Exception("Category name cannot be empty.");
            categoryRepository.UpdateCategory(categoryId, newName.Trim());
        }

        public void Delete(int categoryId) => categoryRepository.DeleteCategory(categoryId);
    }
}
