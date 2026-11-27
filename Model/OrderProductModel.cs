namespace Model
{
    public class OrderProductModel
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountAmount => Math.Round(Quantity * Price * DiscountPercent / 100m, 2);
        public decimal TotalPrice => Quantity * Price - DiscountAmount;
    }
}
