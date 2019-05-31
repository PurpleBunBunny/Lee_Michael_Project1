using System;
using System.Collections.Generic;

namespace PizzaProject1.Context.Data
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Orders>();
        }

        public int CustomerId { get; set; }
        public int? RestaurantId { get; set; }
        public int? AddressId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual Address Address { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
