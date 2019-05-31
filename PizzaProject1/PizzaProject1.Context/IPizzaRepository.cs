using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject1.Library
{
    public interface IPizzaRepository
    {
        void AddPizza(Pizza pizza);
        void EditPizza(Pizza pizza);
        void DeletePizza(int pizzaId);
        IEnumerable<Pizza> GetPizza();
        Pizza GetPizzaByPizzaId(int id);
        void Save();
    }
}
