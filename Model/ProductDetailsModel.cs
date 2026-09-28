using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    internal class ProductDetailsModel
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string Supplier { get; set; }
        public int Quantity { get; set; }   
        public decimal Amount { get; set; }
    }
}
