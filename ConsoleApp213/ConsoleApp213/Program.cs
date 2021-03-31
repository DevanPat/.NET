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
            DateTime date1 = DateTime.Now;
            Console.WriteLine("User please enter a number below.");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(date1.AddHours(hours));
            Console.ReadLine();
        }
    }
}
          
            
