using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApppg213
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("User please enter a number below.");
            string hours = Console.ReadLine();
            DateTime userhour = DateTime.Parse(hours);
            Console.WriteLine(userhour);
            Console.ReadLine();
            
        }
    }
}
