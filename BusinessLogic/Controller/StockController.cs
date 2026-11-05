using BusinessLogic.Repository;
using System.Data;

namespace BusinessLogic.Controller
{
    public class StockController
    {
        private readonly StockRepository repo = new StockRepository();

        public DataTable LoadStockData()
        {
            return repo.GetTopProducts();
        }

        public int GetTotalInventory()
        {
            return repo.GetTotalInventory();
        }

        public int GetLowStockCount()
        {
            return repo.GetLowStockCount();
        }

        public DataTable GetStockByProductId(string productId)
        {
            return repo.GetStockByProductId(productId);
        }

    }
}
