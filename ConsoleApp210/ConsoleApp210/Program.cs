
using System;
using System.IO;

namespace ConsoleApppg210
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User please enter a number below.");
            string text = Console.ReadLine();
            File.WriteAllText(@"C:\Users\devan\c-logs\challenge1.txt", text);
            File.ReadAllText(@"C:\Users\devan\c-logs\challenge1.txt");
           
           
        }
    }
}
