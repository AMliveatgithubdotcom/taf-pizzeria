using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaProjekt.main
{
    public class Pizza
    {
        private string name = "Pizza";
        private double price = 5.00;
        Dictionary<string, double> ingredients = new Dictionary<string, double>();
        public Pizza() { }
        public Pizza(Dictionary<string, double> ingredients)
        {
            this.name = name + "with ";
            foreach (KeyValuePair<string, double> ingredient in ingredients)
            {
                this.name += ingredient.Key + ", ";
                this.price += ingredient.Value;
            }
            this.name += -2;
        }
        public string ReturnName()
        {
            return this.name;
        }
    }
}