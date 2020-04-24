using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to package express, please follow the instructions below.");
            Console.WriteLine("What is the weight of your package?");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("The package is too heavy to be shipped via package express. Have a good day.");
            }
            else
                Console.WriteLine("What is the width of your package?");
                int packageWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the package height?");
                int packageHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the package length?");
                int packageLength = Convert.ToInt32(Console.ReadLine());

                int dimensionTotal = packageWidth + packageHeight + packageLength;

               if (dimensionTotal > 50)
            {
                Console.WriteLine("Your package is too big to be shipped.");
            }
               else
            {                 
                double quote = (dimensionTotal * packageWeight);
                Console.WriteLine("Your estimated total for shipping this package is: " + "$" + quote);
                Console.ReadLine();
            }
            Console.ReadLine();



        }
    }
}
