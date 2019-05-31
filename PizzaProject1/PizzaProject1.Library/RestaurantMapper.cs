using System;
using System.Collections.Generic;
using System.Text;
using PizzaProject1.Library;

namespace PizzaProject1.Context
{
    class RestaurantMapper
    {
        public static PizzaProject1.Context.Data.Restaurant Map(PizzaProject1.Library.Restaurant dmRestaurant)
        {
            PizzaProject1.Context.Data.Restaurant deRestaurant = new PizzaProject1.Context.Data.Restaurant();
            //deRestaurant.RestaurantId = dmRestaurant.RestaurantId;
            deRestaurant.RestaurantName = dmRestaurant.RestaurantName;
            //deRestaurant.AddressId = dmRestaurant.AddressId;

            return deRestaurant;
        }
        public static PizzaProject1.Library.Restaurant Map(PizzaProject1.Context.Data.Restaurant deRestaurant) => new PizzaProject1.Library.Restaurant
        {
            RestaurantId = deRestaurant.RestaurantId,
            RestaurantName = deRestaurant.RestaurantName,
            //LastName = deRestaurant.LastName,
            //Username = deRestaurant.Username,
            //Password = deRestaurant.Password,
            //AddressId = deRestaurant.AddressId,
            //RestaurantId = deRestaurant.RestaurantId,

        };
    }
}
