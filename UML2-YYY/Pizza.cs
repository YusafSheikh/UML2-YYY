using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2_YYY
{
    public class Pizza
    {
        //methods
        public string Name { get; set; }
        public string Toppings { get; set; }
        public double Price { get; set; }
        public int Id { get; set; }

        public Pizza(string Name, string Toppings, double Price, int Id)
        //constructor in order to make pizza and store interact
        {
            this.Name = Name;
            this.Price = Price;
            this.Id = Id;
            this.Toppings = Toppings;
        }

        public override string ToString()
            // so we can redefine each object with our own value/name
        {
            return $"Name: {Name} Price: {Price} Id: {Id} Toppings: {Toppings}";
        }
   
        internal static bool pizzas(KeyValuePair<int, Pizza> arg)
        {
            throw new NotImplementedException();
        }
      }
    }

