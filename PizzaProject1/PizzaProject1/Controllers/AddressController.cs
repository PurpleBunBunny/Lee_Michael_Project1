using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaProject1.Library;

namespace PizzaProject1.Controllers
{
    public class AddressController : Controller
    {

        private readonly IAddressRepository db;

        public AddressController(IAddressRepository db)
        {
            this.db = db;
        }

        Models.Address c;

        List<Models.Address> addressList = new List<Models.Address>();

        // GET: Address
        public ActionResult Index()
        {
            var addresses = db.GetAddress();
            foreach (var address in addresses)
            {
                c = new Models.Address();

                c.FullAddress = address.GetAddress(address.StreetOne, address.StreetTwo, address.City, address.State, address.Country, address.Zipcode);
                c.StreetOne = address.StreetOne;
                c.StreetTwo = address.StreetTwo;
                c.City = address.City;
                c.State = address.State;
                c.Country = address.Country;
                c.Zipcode = address.Zipcode;
                addressList.Add(c);
            }

            return View(addressList);
        }

        // GET: Address/Details/5
        public ActionResult Details(int id)
        {

            var address = db.GetAddressByAddressId(id);
            c = new Models.Address();

            c.FullAddress = address.GetAddress(address.StreetOne, address.StreetTwo, address.City, address.State, address.Country, address.Zipcode);
            c.StreetOne = address.StreetOne;
            c.StreetTwo = address.StreetTwo;
            c.City = address.City;
            c.State = address.State;
            c.Country = address.Country;
            c.Zipcode = address.Zipcode;
            return View(c);
        }

        public ActionResult Log()
        {
            return RedirectToAction("Login", "Customer");
        }

        // GET: Address/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Address/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Models.Address address)
        {

            PizzaProject1.Library.Address dmc = new Address();
            dmc.StreetOne = address.StreetOne;
            dmc.StreetTwo = address.StreetTwo;
            dmc.City = address.City;
            dmc.State = address.State;
            dmc.Country = address.Country;
            dmc.Zipcode = address.Zipcode;

            try
            {
                // TODO: Add insert logic here
                db.AddAddress(dmc);
                db.Save();
                return RedirectToAction("Login", "Customer");
            }
            catch
            {
                return View();
            }
        }

        // GET: Address/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Address/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Address/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Address/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}