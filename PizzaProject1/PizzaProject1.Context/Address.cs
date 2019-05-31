using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject1.Library
{
    public class Address
    {
        public int AddressId { get; set; }
        public string StreetOne { get; set; }
        public string StreetTwo { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zipcode { get; set; }

        public string sOne
        {
            get => StreetOne; set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Street One cannot be empty.");
                }
                StreetOne = value;
            }
        }
        public string city
        {
            get => City; set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("City cannot be empty.");
                }
                City = value;
            }
        }

        public string state
        {
            get => State; set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("State cannot be empty.");
                }
                State = value;
            }
        }

        public string country
        {
            get => Country; set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Country cannot be empty.");
                }
                Country = value;
            }
        }

        public string zip
        {
            get => Zipcode; set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Zipcode cannot be empty.");
                }
                Zipcode = value;
            }
        }

        public string GetAddress(string sone, string stwo, string c, string s, string ct, string z)
        {
            return $"{sone} {stwo} {c} {s} {ct} {z}";
        }

    }
}
