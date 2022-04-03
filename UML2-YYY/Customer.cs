using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2_YYY
{
        public class Customer //objects
    { 
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public int Order { get; set; }

        public string Address { get; set; }

        public Customer(string Name, int PhoneNumber, int Order, string Address)
        {
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
            this.Order = Order;
            this.Address = Address;
        }

        public override string ToString()
        {
            return $"Name: {Name} PhoneNumber: {PhoneNumber} Order: {Order} Address: {Address}";
        }
    }
}
