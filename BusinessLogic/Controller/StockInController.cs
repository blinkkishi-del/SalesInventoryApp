using BusinessLogic.Repository;
using Model;
using System.Data;

namespace BusinessLogic.Controller
{
    public class StockInController
    {
        private readonly StockInRepository stockInRepository;

        public StockInController()
        {
            stockInRepository = new StockInRepository();
        }

        public string SaveStockIn(string supplierId, string stockInBy, IEnumerable<StockInLineModel> lines)
        {
            if (string.IsNullOrWhiteSpace(supplierId)) throw new Exception("Please select a supplier.");
            var items = lines?.ToList() ?? new List<StockInLineModel>();
            if (items.Count == 0) throw new Exception("Add at least one product to the entry list.");
            if (items.Any(l => l.Quantity <= 0)) throw new Exception("Every quantity must be greater than zero.");

            return stockInRepository.SaveStockIn(supplierId, stockInBy, items);
        }

        public DataTable GetHistory(DateTime from, DateTime to) => stockInRepository.GetHistory(from, to);
    }
}
