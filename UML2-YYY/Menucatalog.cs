using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2_YYY
{
        class Menucatalog
        { //Dictonary
        Dictionary<int, Pizza> pizzas;
        
        public Menucatalog()
        {
            pizzas = new Dictionary<int, Pizza>();
        }
        
        public void CreatePizza(Pizza pizza) // Create
        {
            pizzas.Add(pizza.Id, pizza);
        }
        
        public Pizza ReadPizza(int pizzaId) // Read
        {
            return pizzas[pizzaId];
        }

        public void UpdatePizza(Pizza pizza) // Update
        {
            Pizza p = ReadPizza(pizza.Id);
            p.Name = pizza.Name;
            p.Price = pizza.Price;
        }

        public void DeletePizza(Pizza pizza) // Delete
        {
            pizzas.Remove(pizza.Id);
        }

        public void PrintMenu()
        {
            foreach (var p in pizzas)
            {
                Console.WriteLine($"{p.Value.Id} {p.Value.Name} {p.Value.Price}");
            }
        }
    }
}
