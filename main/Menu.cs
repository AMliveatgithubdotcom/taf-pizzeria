using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaProjekt.main
{
    class Menu
    {
        Dictionary<string, double> ingredients = new Dictionary<string, double>() {
        { "cheese", 0.50 },
        { "mushroom", 0.50 },
        { "tomato", 0.50 },
        { "pineapple", 1.00 },
        { "salami", 1.50 },

    };
        public class Pizza
        {
            private string name = "Pizza";
            private double price = 5.00;
            Dictionary<string, double> ingredients = new Dictionary<string, double>();
            public Pizza(string name, double price)
            {
                this.name = name;
                this.price = price;
            }
            public Pizza(string name, double price, Dictionary<string, double> ingredients)
            {
                this.name = name + "with ";
                this.price = price;
                foreach(KeyValuePair<string, double> ingredient in ingredients)
                {
                    this.name += ingredient.Key;
                    this.price += ingredient.Value;
                }
            }
            
        }

        public class MushroomPizza:Pizza
        {
            private string name = "Mushroom Pizza";
            private double price = 5.50;
        }
    }
}
