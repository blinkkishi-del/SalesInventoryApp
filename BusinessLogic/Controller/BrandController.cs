using BusinessLogic.Repository;
using Model;

namespace BusinessLogic.Controller
{
    public class BrandController
    {
        private readonly BrandRepository brandRepository;

        public BrandController()
        {
            brandRepository = new BrandRepository();
        }

        public List<BrandModel> GetAllBrands() => brandRepository.GetAll();

        public List<string> GetBrandNames() => brandRepository.GetAll().Select(c => c.BrandName).ToList();

        public void Add(string brandName)
        {
            if (string.IsNullOrWhiteSpace(brandName)) throw new Exception("Brand name cannot be empty.");
            brandRepository.AddBrand(brandName.Trim());
        }

        public void Update(int brandId, string newName)
        {
            if (string.IsNullOrWhiteSpace(newName)) throw new Exception("Brand name cannot be empty.");
            brandRepository.UpdateBrand(brandId, newName.Trim());
        }

        public void Delete(int brandId) => brandRepository.DeleteBrand(brandId);
    }
}
