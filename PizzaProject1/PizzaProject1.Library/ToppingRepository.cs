using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PizzaProject1.Library;
using PizzaProject1.Context.Data;

namespace PizzaProject1.Context
{
    public class ToppingRepository : IToppingRepository
    {

        private readonly StoreContext _db;
        public ToppingRepository(StoreContext db)
        {
            _db = db;
        }

        public void AddTopping(Library.Topping topping)
        {
            _db.Topping.Add(ToppingMapper.Map(topping));
        }

        public void DeleteTopping(int toppingId)
        {
            _db.Topping.Remove(_db.Topping.Find(toppingId));
        }

        public void EditTopping(Library.Topping topping)
        {
            if (_db.Topping.Find(topping.ToppingId) != null)
                _db.Topping.Update(ToppingMapper.Map(topping));
        }

        public Library.Topping GetToppingByToppingId(int id)
        {
            var Topping = _db.Topping.Where(x => x.ToppingId == id).FirstOrDefault();
            return ToppingMapper.Map(Topping);
        }

        public IEnumerable<Library.Topping> GetTopping()
        {
            return _db.Topping.Select(x => ToppingMapper.Map(x));
        }

        public void Save()
        {
            _db.SaveChanges();
        }

    }
}
