using System;
using System.Collections.Generic;

namespace PizzaProject1.Context.Data
{
    public partial class Address
    {
        public Address()
        {
            Customer = new HashSet<Customer>();
            Restaurant = new HashSet<Restaurant>();
        }

        public int AddressId { get; set; }
        public string StreetOne { get; set; }
        public string StreetTwo { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zipcode { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<Restaurant> Restaurant { get; set; }
    }
}
