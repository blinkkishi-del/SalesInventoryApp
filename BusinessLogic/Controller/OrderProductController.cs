using BusinessLogic.Repository;
using Model;

namespace BusinessLogic.Controller
{
    public class OrderProductController
    {
        private readonly ProductOrderRepository _repository;

        public OrderProductController()
        {
            _repository = new ProductOrderRepository();
        }
        public void AddOrder(OrderProductModel order)
        {
            if (order == null || string.IsNullOrWhiteSpace(order.ItemName))
                return;

            _repository.AddOrUpdate(order);
        }
        public List<OrderProductModel> GetOrders()
        {
            return _repository.GetAll();
        }
        public void RemoveOrder(string itemName)
        {
            if (!string.IsNullOrWhiteSpace(itemName))
                _repository.Delete(itemName);
        }

        public void ClearAllOrders()
        {
            _repository.ClearAll();
        }
    }
}
