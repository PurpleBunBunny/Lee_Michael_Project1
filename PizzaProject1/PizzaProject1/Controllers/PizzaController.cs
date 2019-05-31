using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaProject1.Library;

namespace PizzaProject1.Controllers
{
    public class PizzaController : Controller
    {

        private readonly IPizzaRepository db;
        private readonly IToppingRepository db1;

        public PizzaController(IPizzaRepository db)
        {
            this.db = db;
        }

        public PizzaController(IToppingRepository db1)
        {
            this.db1 = db1;
        }

        Models.Pizza p;
        Models.Topping t;

        List<Models.Pizza> pizzaList = new List<Models.Pizza>();
        List<Models.Topping> toppingList = new List<Models.Topping>();



        // GET: Pizza
        public ActionResult PizzaIndex()
        {
            var pizzas = db.GetPizza();
            foreach (var pizza in pizzas)
            {
                p = new Models.Pizza();
                p.PizzaToppings = pizza.PizzaTopping;
                p.Size = pizza.Size;
                p.Crust = pizza.Crust;
                p.Cost = pizza.Cost;

                pizzaList.Add(p);
            }

            return View(pizzaList);
        }

        // GET: Toppings
        public ActionResult ToppingIndex()
        {
            var toppings = db1.GetTopping();
            foreach (var topping in toppings)
            {
                t = new Models.Topping();
                t.ToppingName = topping.ToppingName;
                t.Count = topping.Count;
             
                toppingList.Add(t);
            }

            return View(toppingList);
        }

        // GET: Pizza/Details/5
        public ActionResult PizzaDetails(int id)
        {
            var pizza = db.GetPizzaByPizzaId(id);
            p = new Models.Pizza();
            p.PizzaToppings = pizza.PizzaTopping;
            p.Size = pizza.Size;
            p.Crust = pizza.Crust;
            p.Cost = pizza.Cost;

            return View(p);
        }

        // GET: Topping/Details/5
        public ActionResult ToppingDetails(int id)
        {
            var topping = db1.GetToppingByToppingId(id);
            t = new Models.Topping();
            t.ToppingName = topping.ToppingName;
            t.Count = topping.Count;

            toppingList.Add(t);

            return View(t);
        }

        // GET: Pizza/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pizza/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                //return RedirectToAction(nameof(Index));
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Pizza/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pizza/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                //return RedirectToAction(nameof(Index));
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Pizza/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pizza/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                //return RedirectToAction(nameof(Index));
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}