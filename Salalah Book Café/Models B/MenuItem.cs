using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salalah_Book_Café.Models_B
{
    internal class MenuItem
    {
        
            public string Name { get; set; }
            public DrinkType Type { get; set; }
            public decimal Price { get; set; }

            public MenuItem(string name, DrinkType type, decimal price)
            {
                Name = name;
                Type = type;
                Price = price;
            }

            public void PrintInfo()
            {
                Console.WriteLine($"{Name} ({Type}) - ${Price}");
            }
        
    }
}
