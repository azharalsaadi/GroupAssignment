using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Salalah_Sports_League.Models_D
{
    class Team
    {
        public string Name { get; set; }
        public string Coach { get; set; }
        public List<Player> Players { get; set; } = new List<Player>();

        public Team(string name, string coach)
        {
            Name = name;
            Coach = coach;
        }

        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Team: {Name}, Coach: {Coach}");
            Console.WriteLine("Players:");
            foreach (var player in Players)
                player.PrintInfo();
            Console.WriteLine("-----------------------------------");
        }
    }
}
