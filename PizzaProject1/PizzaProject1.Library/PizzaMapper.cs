using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject1.Context
{
    public static class PizzaMapper
    {
        public static PizzaProject1.Context.Data.Pizza Map(PizzaProject1.Library.Pizza dmPizza)
        {
            PizzaProject1.Context.Data.Pizza dePizza = new PizzaProject1.Context.Data.Pizza();
            //dePizza.PizzaId = dmPizza.PizzaId;
            dePizza.OrderId = dmPizza.OrderId;
            dePizza.Size = dmPizza.Size;
            dePizza.Crust = dmPizza.Crust;
            dePizza.ToppingAmount = dmPizza.ToppingAmount;
            dePizza.Cost = dmPizza.Cost;


            return dePizza;
        }
        public static PizzaProject1.Library.Pizza Map(PizzaProject1.Context.Data.Pizza dePizza) => new PizzaProject1.Library.Pizza
        {
            PizzaId = dePizza.PizzaId,
            OrderId = dePizza.OrderId,
            Size = dePizza.Size,
            Crust = dePizza.Crust,
            ToppingAmount = dePizza.ToppingAmount,
            Cost = dePizza.Cost,


        };

    }
}
