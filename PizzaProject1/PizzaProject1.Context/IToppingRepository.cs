using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject1.Library
{
    public interface IToppingRepository
    {
        void AddTopping(Topping topping);
        void EditTopping(Topping topping);
        void DeleteTopping(int toppingId);
        IEnumerable<Topping> GetTopping();
        Topping GetToppingByToppingId(int id);
        void Save();
    }
}
