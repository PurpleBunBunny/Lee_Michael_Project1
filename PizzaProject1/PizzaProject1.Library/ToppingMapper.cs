using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject1.Context
{
    public static class ToppingMapper
    {
        public static PizzaProject1.Context.Data.Topping Map(PizzaProject1.Library.Topping dmTopping)
        {
            PizzaProject1.Context.Data.Topping deTopping = new PizzaProject1.Context.Data.Topping();
            //deTopping.ToppingId = dmTopping.ToppingId;
            deTopping.ToppingName = dmTopping.ToppingName;
            deTopping.Count = dmTopping.Count;
            

            return deTopping;
        }
        public static PizzaProject1.Library.Topping Map(PizzaProject1.Context.Data.Topping deTopping) => new PizzaProject1.Library.Topping
        {
            ToppingId = deTopping.ToppingId,
            ToppingName = deTopping.ToppingName,
            Count = deTopping.Count,
            

        };

    }
}
