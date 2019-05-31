using System;
using System.Collections.Generic;

namespace PizzaProject1.Context.Data
{
    public partial class Restaurant
    {
        public Restaurant()
        {
            Customer = new HashSet<Customer>();
            Inventory = new HashSet<Inventory>();
            Orders = new HashSet<Orders>();
        }

        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public int AddressId { get; set; }

        public virtual Address Address { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<Inventory> Inventory { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
