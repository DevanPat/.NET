using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 10;
            while (b < 15)
            {
                Console.WriteLine(b);
                b++;
            }
            

            int c = 25;
            do
            {
                Console.WriteLine(c + 2);
                c++;
            }
            while (c < 30);
            Console.ReadLine();
            

            
               
        }
    }
}
