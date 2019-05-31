using System;
using System.Collections.Generic;

namespace PizzaProject1.Library
{
    public interface ICustomerRepository
    {
        void AddCustomer(Customer customer);
        void EditCustomer(Customer customer);
        void DeleteCustomer(int CustomerId);
        IEnumerable<Customer> GetCustomer();
        Customer GetCustomerByName(string name);
        Customer GetCustomerByUsername(string name);
        Customer GetCustomerByCustomerId(int id);
        //Customer GetCustomerByCustomerUser(string user);
        void Save();
    }
}
