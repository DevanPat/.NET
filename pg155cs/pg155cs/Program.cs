using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg155cs
{
    class Program
    {
        static void Main(string[] args)
        {
            methodC methodic1 = new methodC();
            Console.WriteLine("User please enter a number.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            
            int answer1 = methodic1.methodOne(userInput);
            Console.WriteLine("Your answer is " + answer1);
            Console.ReadLine();

            double answer2 = methodic1.methodTwo(userInput);
            Console.WriteLine("Your answer is " + answer2);
            Console.ReadLine();

            Console.WriteLine("User please enter a number as a string.");
            string userTypes = Console.ReadLine();
            string answer3 = methodic1.methodThree(userTypes);
            Console.WriteLine("Your answer is " + answer3);
            Console.ReadLine();

        }
    }
}
            

            



