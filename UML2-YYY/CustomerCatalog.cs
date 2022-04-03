using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2_YYY
{
    class CustomerCatalog
    {
        Dictionary<int, Customer> customers;

        public CustomerCatalog()
        {
            customers = new Dictionary<int, Customer>();
        }

        public void CreateCustomer(Customer customer) //Create
        {
            customers.Add(customer.Order, customer);
        }

        public Customer ReadCustomer(int Order) // Read
        {
            return customers[Order];
        }
    }
}