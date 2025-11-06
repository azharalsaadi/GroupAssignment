using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Salalah_Delivery_Express.Models_C
{
    class Driver
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public List<Delivery> Deliveries { get; set; } = new List<Delivery>();

        public Driver(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }

        public void AssignDelivery(Delivery delivery)
        {
            Deliveries.Add(delivery);
        }

        public void PrintDeliveries()
        {
            Console.WriteLine($"Driver: {Name} Deliveries:");
            foreach (var d in Deliveries)
            {
                Console.WriteLine($"- Customer: {d.Customer.Name}, Status: {d.Status}");
            }
        }
    }
}
