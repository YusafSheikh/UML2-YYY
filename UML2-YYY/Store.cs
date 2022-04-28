using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2_YYY
{
    public class Store
    {
        Pizza Pizza1 = new Pizza("Salatpizza", "Ekstra salat", 65, 1);
        Pizza Pizza2 = new Pizza("Sheikhs favorite", "Ekstra kebab", 69, 2);
        Pizza Pizza3 = new Pizza("Chili Punjabi Mix", "Minus løg", 80, 2);
        Pizza Pizza4 = new Pizza("Mozeralla", "Oste bombe", 55, 3);

        public void Start()
        {
            //Test();
            UserDialog();
        }

        public void UserDialog()
        {
                bool exit = false;
                Menucatalog menuCat = new Menucatalog();
                menuCat.CreatePizza(Pizza1);
                menuCat.CreatePizza(Pizza2);

                while (!exit)
                {
                    Console.WriteLine("Skriv nr på valg");
                    Console.WriteLine("1. PrintMenu");
                    Console.WriteLine("2. Test");
                    Console.WriteLine("3. Exit");
                    Console.WriteLine("4. Another Pizza");
                
                    switch (Console.ReadLine())
                    {
                        case "1":
                            menuCat.PrintMenu();
                            break;
                            case "2":
                            Test();
                            break;
                            case "3":
                            exit = true;
                            return;
                            case "4":
                            {
                            Pizza p = new Pizza("MyPizzaXXL","",45,43);
                            
                            menuCat.CreatePizza(p);

                             }
                            break;
                            default:
                            Console.WriteLine("Findes ikke" + "Prøv igen");
                            break;
                    }
}
            }

        public void Test()

        { 
            //Catalogs (Dictionarys)
            Menucatalog catalog = new Menucatalog();
            CustomerCatalog customerCatalog = new CustomerCatalog();

            //Pizzas
            /*Pizza Pizza1 = new Pizza("Salatpizza","Ekstra salat",  65, 1);
            Pizza Pizza2 = new Pizza("Sheikhs favorite","Ekstra kebab",  69, 2);
            Pizza Pizza3 = new Pizza("Chili Punjabi Mix","Minus løg", 80, 2);
            Pizza Pizza4 = new Pizza("Mozeralla", "Oste bombe", 55, 3);*/

            //Customers
            Customer customer1 = new Customer("Jonas Nielsen", 32364354, 1, "Langby torv 90 tv.");
            Customer customer2 = new Customer("Yusaf Sheikh", 93940686, 2, "Soltorv vej 53 th."); 
            

            // CRUD operation
            
            catalog.CreatePizza(Pizza1);
            catalog.CreatePizza(Pizza2);
            customerCatalog.CreateCustomer(customer1);
            customerCatalog.CreateCustomer(customer2);

            //Create
            Console.WriteLine("________________________________________________");
            Console.WriteLine("Pizza orders created");
            Console.WriteLine(Pizza1);
            Console.WriteLine(Pizza2);
            Console.WriteLine(Pizza3);
            Console.WriteLine(Pizza4);
            Console.WriteLine("________________________________________________");
            Console.WriteLine("Customers waiting to recieve orders: ");
            Console.WriteLine(customer1);
            Console.WriteLine(customer2);

            //Read
            Console.WriteLine("________________________________________________");
            Console.WriteLine("Reading current pizza order:");
   
            //Update & Delete
            catalog.UpdatePizza(Pizza3);
            Console.WriteLine(catalog.ReadPizza(1));
            catalog.DeletePizza(Pizza1);
            try
            {
                Console.WriteLine(catalog.ReadPizza(1));
            } catch

            {
                Console.WriteLine("________________________________________________");
                Console.WriteLine("Your old pizza order, was replaced with your updated order: ");
                Console.WriteLine("Customer name: " + customer2.Name + "" + " Phone Number: " + customer2.PhoneNumber);
            }

            //Print Menu
            catalog.PrintMenu();
            
            
        }
    }

}
