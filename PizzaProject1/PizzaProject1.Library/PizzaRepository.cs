using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PizzaProject1.Library;
using PizzaProject1.Context.Data;

namespace PizzaProject1.Context
{
    public class PizzaRepository : IPizzaRepository
    {

        private readonly StoreContext _db;
        public PizzaRepository(StoreContext db)
        {
            _db = db;
        }

        public void AddPizza(Library.Pizza pizza)
        {
            _db.Pizza.Add(PizzaMapper.Map(pizza));
        }

        public void DeletePizza(int pizzaId)
        {
            _db.Pizza.Remove(_db.Pizza.Find(pizzaId));
        }

        public void EditPizza(Library.Pizza pizza)
        {
            if (_db.Pizza.Find(pizza.PizzaId) != null)
                _db.Pizza.Update(PizzaMapper.Map(pizza));
        }

        public Library.Pizza GetPizzaByPizzaId(int id)
        {
            var Pizza = _db.Pizza.Where(x => x.PizzaId == id).FirstOrDefault();
            return PizzaMapper.Map(Pizza);
        }

        public IEnumerable<Library.Pizza> GetPizza()
        {
            return _db.Pizza.Select(x => PizzaMapper.Map(x));
        }

        public void Save()
        {
            _db.SaveChanges();
        }

    }
}
