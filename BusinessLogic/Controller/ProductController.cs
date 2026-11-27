using BusinessLogic.Repository;
using Model;


namespace BusinessLogic.Controller
{
    public class ProductController
    {

        private readonly ProductRepository productRepository;

        public ProductController()
        {
            productRepository = new ProductRepository();
        }

        public string Add(ProductDetailsModel model)
        {
            if (model == null) throw new Exception("Missing parameter: model");
            return productRepository.AddProduct(model);
        }

        public string GetNextProductId() => productRepository.GetNextProductId();

        public void Update(ProductDetailsModel model)
        {
            if (model == null) throw new Exception("Missing parameter: model");
            productRepository.UpdateProduct(model);
        }

        public List<ProductDetailsModel> GetAllProducts() => productRepository.GetAll();

        public List<ProductDetailsModel> SearchProducts(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword)) return productRepository.GetAll();
            return productRepository.SearchProducts(keyword);
        }

        public ProductDetailsModel? GetById(string productId)
        {
            if (string.IsNullOrEmpty(productId)) throw new Exception("Invalid product Id");
            return productRepository.GetAll().FirstOrDefault(p => p.ProductId == productId);
        }

        public List<ProductDetailsModel> GetProductsOrderedByStock() => productRepository.GetProductsOrderedByStock();

        public int GetTotalInventory() => productRepository.GetTotalInventory();

        public List<ProductDetailsModel> GetLowStockProducts(int threshold = 10) => productRepository.GetLowStockProducts(threshold);
    }
}
