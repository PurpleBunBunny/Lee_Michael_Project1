using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject1.Library
{
    public interface IAddressRepository
    {
        void AddAddress(Address address);
        void EditAddress(Address address);
        void DeleteAddress(int AddressId);
        IEnumerable<Address> GetAddress();
        Address GetAddressByAddressId(int id);
        void Save();
    }
}
