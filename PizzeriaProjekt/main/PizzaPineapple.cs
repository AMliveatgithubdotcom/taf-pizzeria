using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaProjekt.main
{
    public class PineapplePizza
    {
        private string name = "Pineapple Pizza";
        private double price = 5.00;
        Dictionary<string, double> ingredients = new Dictionary<string, double>()
                {
                    { "pineapple", 0.50 }
                };
        public PineapplePizza(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public PineapplePizza(string name, double price, Dictionary<string, double> ingredients)
        {
            this.name = name + "with ";
            this.price = price;
            foreach (KeyValuePair<string, double> ingredient in ingredients)
            {
                this.name += ingredient.Key;
                this.price += ingredient.Value;
            }
        }
    }
}
