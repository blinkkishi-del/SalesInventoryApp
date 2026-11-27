using BusinessLogic.Repository;
using Model;

namespace BusinessLogic.Controller
{
    public class OrderProductController
    {
        private readonly ProductOrderRepository _repository;
        private readonly string _cashier;

        public OrderProductController(string cashierUsername)
        {
            if (string.IsNullOrWhiteSpace(cashierUsername))
                throw new ArgumentException("A cashier must be logged in to use the cart.", nameof(cashierUsername));
            _repository = new ProductOrderRepository();
            _cashier = cashierUsername;
        }

        public void AddOrder(OrderProductModel order)
        {
            if (order == null || string.IsNullOrWhiteSpace(order.ItemName))
                return;

            _repository.AddOrUpdate(order, _cashier);
        }

        public List<OrderProductModel> GetOrders()
        {
            return _repository.GetAll(_cashier);
        }

        public void RemoveOrder(string itemName)
        {
            if (!string.IsNullOrWhiteSpace(itemName))
                _repository.Delete(itemName, _cashier);
        }

        public void SetDiscount(string itemName, decimal discountPercent)
        {
            if (string.IsNullOrWhiteSpace(itemName)) throw new Exception("Please select an item.");
            if (discountPercent < 0 || discountPercent > 100) throw new Exception("Discount must be between 0% and 100%.");
            _repository.SetDiscount(itemName, discountPercent, _cashier);
        }

        public void ClearAllOrders()
        {
            _repository.ClearAll(_cashier);
        }
    }
}
