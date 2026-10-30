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


        public ProductDetailsModel GetById(string productId)
        {
            if (string.IsNullOrEmpty(productId)) throw new Exception("Invalid product Id");
            return productRepository.GetAll().FirstOrDefault(p => p.ProductId == productId);
        }



        public void UpdateProductQuantity(string productId, int quantityToDeduct)
        {
            var product = GetById(productId);
            if (product == null) throw new Exception("Product not found.");

            int newQuantity = product.Quantity - quantityToDeduct;
            if (newQuantity < 0) newQuantity = 0;

            productRepository.UpdateProductQuantity(productId, newQuantity);
            product.Quantity = newQuantity;
        }

        public List<ProductDetailsModel> SearchByProductName(string productName)
        {
            if (string.IsNullOrWhiteSpace(productName))
                return productRepository.GetAll();

            return productRepository.SearchByProductName(productName);
        }
        public List<ProductDetailsModel> GetProductsOrderedByStock()
        {
            return productRepository.GetProductsOrderedByStock();
        }

    }
}
