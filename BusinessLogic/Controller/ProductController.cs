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

        public void Add(ProductDetailsModel model)
        {
            if (model == null) throw new Exception("Missing parameter: model");
            productRepository.AddProduct(model);
        }

        public void Update(ProductDetailsModel model)
        {
            if (model == null) throw new Exception("Missing parameter: model");
            productRepository.UpdateProduct(model);
        }

        public void Delete(string productId)
        {
            if (string.IsNullOrEmpty(productId)) throw new Exception("Invalid product Id");
            productRepository.DeleteProduct(productId);
        }

        public List<ProductDetailsModel> GetAllProducts() => productRepository.GetAll();

        public List<ProductDetailsModel> SearchProducts(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword)) return productRepository.GetAll();
            return productRepository.SearchProducts(keyword);
        }

    }
}
