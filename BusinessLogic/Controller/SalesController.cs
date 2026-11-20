using BusinessLogic.Repository;
using System.Data;

namespace BusinessLogic.Controller
{
    public class SalesController
    {
        private readonly SalesRepository salesRepository;

        public SalesController() => salesRepository = new SalesRepository();

        public DataTable GetAllSales() => salesRepository.GetAllSales();

        public DataTable GetSalesByDate(DateTime date) => salesRepository.GetSalesByDate(date);

        public decimal GetTotalSalesByDate(DateTime date) => salesRepository.GetTotalSalesByDate(date);

        public decimal GetTotalSalesToday() => salesRepository.GetTotalSalesByDate(DateTime.Today);

        public void Checkout(IEnumerable<(string ProductId, int Quantity, decimal Price)> lines)
            => salesRepository.Checkout(DateTime.Now, lines);

        public void DeleteSale(int salesId) => salesRepository.DeleteSale(salesId);

        public DataTable GetTop5Sellers() => salesRepository.GetTop5Sellers();

        public DataTable GetLast7DaysSales() => salesRepository.GetLast7DaysSales();

        public DataTable SearchSales(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword)) return GetAllSales();
            return salesRepository.SearchSalesByProductName(keyword);
        }
    }
}
