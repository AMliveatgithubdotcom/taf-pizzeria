using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaProjekt.main
{
    public class Food
    {
        private string name;
        private double price;
        Dictionary<string, double> ingredients = new Dictionary<string, double>();
        public Food(string name, double price) 
        {
            this.name = name;
            this.price = price;
        }
        public Food(string name, double price, Dictionary<string, double> ingredients)
        {
            this.name = name + " with ";
            this.price = price;
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