using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhofar_Car_Rental.Models_A
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public Customer(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Customer: {Name} - Phone: {Phone}");
        }
    }
}
