using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject1.Library
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public int? RestaurantId { get; set; }
        public int? AddressId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string UserName
        {
            get => Username; set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Username cannot be empty.");
                }
                Username = value;
            }
        }

        public string PassWord
        {
            get => Password; set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Password cannot be empty.");
                }
                Password = value;
            }
        }

        public string Name
        {
            get => FirstName; set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be empty.");
                }
                FirstName = value;
            }
        }
        public string SurName
        {
            get => LastName; set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name cannot be empty.");
                }
                LastName = value;
            }
        }

        public string GetName(string fName, string lName)
        {
            return $"{fName} {lName}";
        }

    }
}
