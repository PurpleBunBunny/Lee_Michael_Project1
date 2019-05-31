using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PizzaProject1.Models
{
    public class Customer
    {

        [DisplayName("Username")]
        [Required(ErrorMessage = "Username required")]
        public string Username { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Password required")]
        public string Password { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "First name required")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last name required")]
        public string LastName { get; set; }

        //public int AddressId { get; set; }
        //public int RestaurantId { get; set; }
    }
}
