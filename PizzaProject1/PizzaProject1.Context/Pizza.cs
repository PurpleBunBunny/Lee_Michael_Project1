using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject1.Library
{
    public class Pizza
    {
        public int PizzaId { get; set; }
        public int OrderId { get; set; }
        public int Size { get; set; }
        public int Crust { get; set; }
        public int? ToppingAmount { get; set; }
        public decimal? Cost { get; set; }
        public List<string> PizzaTopping { get; set; }
    }
}
