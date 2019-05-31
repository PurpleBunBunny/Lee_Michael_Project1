using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject1.Library
{
    public class Order
    {
        public int OrderId { get; set; }
        public int RestaurantId { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalCost { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}
