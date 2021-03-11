using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_pg152
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Challenge challenge1 = new Challenge();
            Console.WriteLine("User please enter a number.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int result1 = challenge1.challengeOne(userInput);
            Console.WriteLine("Your returned value is " + result1);

            int result2 = challenge1.challengeTwo(userInput);
            Console.WriteLine("Your returned value is " + result2);

            int result3 = challenge1.challengeThree(userInput);
            Console.WriteLine("Your returned value is " + result3);
            Console.ReadLine();

            
            

        }
    }
}
