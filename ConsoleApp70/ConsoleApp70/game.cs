using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp70
{
    public class game
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public void ListPlayers()
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }

        }
    }
}
