using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PizzaProject1.Library;
using PizzaProject1.Context.Data;

namespace PizzaProject1.Context
{
    public class AddressRepository : IAddressRepository
    {

        private readonly StoreContext _db;
        public AddressRepository(StoreContext db)
        {
            _db = db;
        }

        public void AddAddress(Library.Address address)
        {
            _db.Address.Add(AddressMapper.Map(address));
        }

        public void DeleteAddress(int addressId)
        {
            _db.Address.Remove(_db.Address.Find(addressId));
        }

        public void EditAddress(Library.Address address)
        {
            if (_db.Address.Find(address.AddressId) != null)
                _db.Address.Update(AddressMapper.Map(address));
        }

        public Library.Address GetAddressByAddressId(int id)
        {
            var Address = _db.Address.Where(x => x.AddressId == id).FirstOrDefault();
            return AddressMapper.Map(Address);
        }

        public IEnumerable<Library.Address> GetAddress()
        {
            return _db.Address.Select(x => AddressMapper.Map(x));
        }

        public void Save()
        {
            _db.SaveChanges();
        }

    }
}
