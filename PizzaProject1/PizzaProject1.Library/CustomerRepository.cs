using System;
using System.Collections.Generic;
using System.Linq;
using PizzaProject1.Library;
using PizzaProject1.Context.Data;


namespace PizzaProject1.Context
{
    public class CustomerRepository : ICustomerRepository
    {

        private readonly StoreContext _db;
        public CustomerRepository(StoreContext db)
        {
            _db = db;
        }

        public void AddCustomer(Library.Customer customer)
        {
            _db.Customer.Add(CustomerMapper.Map(customer));
        }

        public void DeleteCustomer(int CustomerId)
        {
            _db.Customer.Remove(_db.Customer.Find(CustomerId));
        }

        public void EditCustomer(Library.Customer customer)
        {
            if (_db.Customer.Find(customer.CustomerId) != null)
                _db.Customer.Update(CustomerMapper.Map(customer));
        }

        public Library.Customer GetCustomerByName(string name)
        {
            var element = _db.Customer.Where(a => a.FirstName.Contains(name) || a.LastName.Contains(name)).FirstOrDefault();

            if (element != null)
                return CustomerMapper.Map(element);
            else
                return null;
        }

        public Library.Customer GetCustomerByUsername(string name)
        {
            var element = _db.Customer.Where(a => a.Username.Contains(name)).FirstOrDefault();

            if (element != null)
                return CustomerMapper.Map(element);
            else
                return null;
        }

        public Library.Customer GetCustomerByCustomerId(int id)
        {
            var customer = _db.Customer.Where(x => x.CustomerId == id).FirstOrDefault();
            return CustomerMapper.Map(customer);
        }

        //public Library.Customer GetCustomerByCustomerUser(string user)
        //{
        //    var customer = _db.Customer.Where(x => x.Username == user).FirstOrDefault();
        //    if (customer != null)
        //        return CustomerMapper.Map(customer);
        //    else
        //        return null;
        //}

        //public Library.Customer GetCustomerByCustomerPass(string pass)
        //{
        //    var customer = _db.Customer.Where(x => x.Password == pass).FirstOrDefault();
        //    if (customer != null)
        //        return CustomerMapper.Map(customer);
        //    else
        //        return null;
        //}


        public IEnumerable<Library.Customer> GetCustomer()
        {
            return _db.Customer.Select(x => CustomerMapper.Map(x));
        }

        public void Save()
        {
            _db.SaveChanges();
        }

    }
}
