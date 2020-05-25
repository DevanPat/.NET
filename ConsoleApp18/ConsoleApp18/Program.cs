using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User please enter a number below.");
            string text = Console.ReadLine();
            File.WriteAllText(@"C:\Users\devan\c-logs\challenge1.txt", text);
            Console.WriteLine(File.ReadAllText(@"C:\Users\devan\c-logs\challenge1.txt"));
            Console.ReadLine();
            

        }
    }
}
