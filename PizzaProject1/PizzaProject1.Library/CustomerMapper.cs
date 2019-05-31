using System;
using System.Collections.Generic;
using System.Text;
using PizzaProject1.Library;

namespace PizzaProject1.Context
{
    public static class CustomerMapper
    {
        public static PizzaProject1.Context.Data.Customer Map(PizzaProject1.Library.Customer dmCustomer)
        {
            PizzaProject1.Context.Data.Customer deCustomer = new PizzaProject1.Context.Data.Customer();
            //deCustomer.CustomerId = dmCustomer.CustomerId;
            deCustomer.FirstName = dmCustomer.FirstName;
            deCustomer.LastName = dmCustomer.LastName;
            deCustomer.Username = dmCustomer.Username;
            deCustomer.Password = dmCustomer.Password;
            //deCustomer.RestaurantId = dmCustomer.RestaurantId;
            //deCustomer.AddressId = dmCustomer.AddressId;

            return deCustomer;
        }
        public static PizzaProject1.Library.Customer Map(PizzaProject1.Context.Data.Customer deCustomer) => new PizzaProject1.Library.Customer
        {
            CustomerId = deCustomer.CustomerId,
            FirstName = deCustomer.FirstName,
            LastName = deCustomer.LastName,
            Username = deCustomer.Username,
            Password = deCustomer.Password,
            AddressId = deCustomer.AddressId,
            RestaurantId = deCustomer.RestaurantId,

        };

    }
}
