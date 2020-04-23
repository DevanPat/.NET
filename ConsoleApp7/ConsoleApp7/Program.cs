using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI?");
            bool answer = Convert.ToBoolean(Console.ReadLine()); 
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            bool condition1 = age > 15;
            bool condition2 = answer == false;
            bool condition3 = tickets <= 3;
            Console.WriteLine("See below to see if you qualified.");
            if (condition1 == true && condition2 == true && condition3 == true)
            {
                Console.WriteLine(true);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(false);
                Console.ReadLine();
                    
             }
        }
    }
}
