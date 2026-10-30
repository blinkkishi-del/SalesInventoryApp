using BusinessLogic.Repository;
using System.Data;


namespace BusinessLogic.Controller
{
    public class SalesController
    {
        private readonly SalesRepository salesRepository;
        private readonly ProductController productController;

        public SalesController()
        {
            salesRepository = new SalesRepository();
            productController = new ProductController();
        }

        public DataTable GetAllSales() => salesRepository.GetAllSales();

        public DataTable GetSalesByDate(DateTime date) => salesRepository.GetSalesByDate(date);

        public decimal GetTotalSalesByDate(DateTime date) => salesRepository.GetTotalSalesByDate(date);

        public void AddSale(string productId, int quantity, decimal unitPrice)
        {
            if (quantity <= 0) return;

            decimal totalPrice = quantity * unitPrice;

            int salesId = salesRepository.InsertSale(DateTime.Now, totalPrice);

            salesRepository.InsertSaleDetail(salesId, productId, quantity, totalPrice);

            productController.UpdateProductQuantity(productId, quantity);
        }

        public void DeleteSale(int salesId) => salesRepository.DeleteSale(salesId);

        public decimal GetTotalSalesToday() => salesRepository.GetTotalSalesByDate(DateTime.Today);

        public DataTable SearchSales(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword)) return GetAllSales();
            return salesRepository.SearchSalesByProductName(keyword);
        }
    }
}
