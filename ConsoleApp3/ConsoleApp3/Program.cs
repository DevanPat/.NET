using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intLists = new List<int>();
            intLists.Add(10);
            intLists.Add(12);
            intLists.Add(15);
            intLists.Add(20);
            Console.WriteLine("Enter a divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("The quotient is: " + intLists[i] / divisor);
            }
            Console.ReadLine();
        }
    }
}
