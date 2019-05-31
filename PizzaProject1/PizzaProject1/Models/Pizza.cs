using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PizzaProject1.Models
{
    public class Topping
    {
        [DisplayName("#")]
        public int Num { get; set; } = 0;

        [DisplayName("Topping Name")]
        public string ToppingName { get; set; }

        [DisplayName("Amount of topping")]
        public int? Count { get; set; }
    }

    public class Pizza
    {
        [Display(Name = "#")]
        public int Num { get; set; } = 0;

        [Display(Name = "Pizza Toppings")]
        public List<string> PizzaToppings { get; set; }

        [DisplayName("Pizza Size")]
        [Required(ErrorMessage = "Size cannot be blank")]
        public int Size { get; set; }

        [DisplayName("Crust Type")]
        [Required(ErrorMessage = "Crust type cannot be blank")]
        public int Crust { get; set; }

        [DisplayName("Cost")]
        public decimal? Cost { get; set; }
    }
}


