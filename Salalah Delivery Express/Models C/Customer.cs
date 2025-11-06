using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salalah_Delivery_Express.Models_C
{
    class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Customer(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Customer: {Name}, Address: {Address}");
        }
    }
}