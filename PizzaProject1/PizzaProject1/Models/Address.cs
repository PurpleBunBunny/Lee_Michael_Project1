using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PizzaProject1.Models
{
    public class Address
    {

        [DisplayName("Full Address")]
        public string FullAddress { get; set; }

        [DisplayName("Street One")]
        [Required(ErrorMessage = "Street one required")]
        public string StreetOne { get; set; }

        [DisplayName("Street Two")]
        public string StreetTwo { get; set; }

        [DisplayName("City")]
        [Required(ErrorMessage = "Street one required")]
        public string City { get; set; }

        [DisplayName("State")]
        [Required(ErrorMessage = "State name required")]
        public string State { get; set; }

        [DisplayName("Country")]
        [Required(ErrorMessage = "Country required")]
        public string Country { get; set; }

        [DisplayName("Zipcode")]
        [Required(ErrorMessage = "Zipcode required")]
        public string Zipcode { get; set; }

    }
}
