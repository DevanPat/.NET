using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppg157
{
    class Program
    {
        static void Main(string[] args)
        {
            classOne classOnes = new classOne();

            Console.WriteLine("User please enter a number for a math operation");
            int firstInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number which will display on the screen");
            int secondInput = Convert.ToInt32(Console.ReadLine());
            classOnes.methodOne(firstInput, secondInput);
            classOnes.methodOne(x: firstInput, y: secondInput);
            Console.ReadLine();

        }
    }
}

             

