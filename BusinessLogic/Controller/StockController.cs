using BusinessLogic.Repository;
using System.Data;

namespace BusinessLogic.Controller
{
    public class StockController
    {
        private readonly StockRepository repo = new StockRepository();

        public const int LowStockThreshold = 10;

        public DataTable GetRecentMovements(int count = 5) => repo.GetRecentMovements(count);

        public DataTable GetInventoryList() => repo.GetInventoryList(LowStockThreshold, criticalOnly: false);

        public DataTable GetCriticalStocks() => repo.GetInventoryList(LowStockThreshold, criticalOnly: true);
    }
}
