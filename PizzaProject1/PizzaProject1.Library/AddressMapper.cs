using System;
using System.Collections.Generic;
using System.Text;
using PizzaProject1.Library;

namespace PizzaProject1.Context
{
    public static class AddressMapper
    {
        public static PizzaProject1.Context.Data.Address Map(PizzaProject1.Library.Address dmAddress)
        {
            PizzaProject1.Context.Data.Address deAddress = new PizzaProject1.Context.Data.Address();
            //deAddress.AddressId = dmAddress.AddressId;
            deAddress.StreetOne = dmAddress.StreetOne;
            deAddress.StreetTwo = dmAddress.StreetTwo;
            deAddress.City = dmAddress.City;
            deAddress.State = dmAddress.State;
            deAddress.Country = dmAddress.Country;
            deAddress.Zipcode = dmAddress.Zipcode;

            return deAddress;
        }
        public static PizzaProject1.Library.Address Map(PizzaProject1.Context.Data.Address deAddress) => new PizzaProject1.Library.Address
        {
            AddressId = deAddress.AddressId,
            StreetOne = deAddress.StreetOne,
            StreetTwo = deAddress.StreetTwo,
            City = deAddress.City,
            State = deAddress.State,
            Country = deAddress.Country,
            Zipcode = deAddress.Zipcode,

        };

    }
}
