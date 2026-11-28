using BusinessLogic.Repository;
using System.Data;

namespace BusinessLogic.Controller
{
    public class SalesController
    {
        private readonly SalesRepository salesRepository;

        public SalesController() => salesRepository = new SalesRepository();

        public DataTable GetSoldItemsSummary(DateTime from, DateTime to) => salesRepository.GetSoldItemsSummary(from, to);

        public DataTable GetTopSelling(DateTime from, DateTime to) => salesRepository.GetTopSelling(from, to);

        public int GetSalesCountByDate(DateTime date) => salesRepository.GetSalesCountByDate(date);

        public DataTable GetRecentSales(int count = 5) => salesRepository.GetRecentSales(count);

        public decimal GetOrderDiscountTotal(DateTime from, DateTime to) => salesRepository.GetOrderDiscountTotal(from, to);

        public DataTable GetSalesHistory(DateTime from, DateTime to, string cashier, string keyword)
        {
            if (from.Date > to.Date) (from, to) = (to, from);
            return salesRepository.GetSalesHistory(from, to, cashier, keyword?.Trim());
        }

        public decimal GetTotalSalesToday() => salesRepository.GetTotalSalesByDate(DateTime.Today);

        public string GetNextReceiptNo() => salesRepository.GetNextReceiptNo();

        public string Checkout(IEnumerable<(string ProductId, int Quantity, decimal Price, decimal DiscountAmount)> lines,
            string cashierUsername = null, decimal orderDiscountPercent = 0)
        {
            if (orderDiscountPercent < 0 || orderDiscountPercent > 100) throw new Exception("Discount must be between 0% and 100%.");
            return salesRepository.Checkout(DateTime.Now, lines, cashierUsername, orderDiscountPercent);
        }

        public DataTable GetLast7DaysSales() => salesRepository.GetLast7DaysSales();
    }
}
