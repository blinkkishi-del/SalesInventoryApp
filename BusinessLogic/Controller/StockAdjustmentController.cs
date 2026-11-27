using BusinessLogic.Repository;
using System.Data;

namespace BusinessLogic.Controller
{
    public class StockAdjustmentController
    {
        public static readonly string[] Reasons =
            { "Damaged", "Lost/Stolen", "Count Correction", "Customer Return", "Other" };

        private readonly StockAdjustmentRepository repository = new StockAdjustmentRepository();

        public string Save(string productId, bool addToStock, int quantity, string reason, string remarks, string adjustedBy)
        {
            if (string.IsNullOrWhiteSpace(productId)) throw new Exception("Please select a product.");
            if (quantity <= 0) throw new Exception("Quantity must be greater than zero.");
            if (string.IsNullOrWhiteSpace(reason)) throw new Exception("Please select a reason.");
            if (reason == "Other" && string.IsNullOrWhiteSpace(remarks))
                throw new Exception("Please describe the reason in Remarks when choosing 'Other'.");

            return repository.SaveAdjustment(productId, addToStock ? "Add" : "Remove", quantity,
                                             reason, remarks?.Trim(), adjustedBy);
        }

        public DataTable GetHistory(DateTime from, DateTime to) => repository.GetHistory(from, to);
    }
}
