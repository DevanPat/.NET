using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppg160
{
    class Program
    {
        static void Main(string[] args)
        {
            caseOne caseOnes = new caseOne();
            int y = 0;
            
            Console.WriteLine("User please enter a number for a math operation.");
            int x = Convert.ToInt32(Console.ReadLine());
            caseOnes.methodOne(x);
            int b = caseOnes.methodTwo(x, y);
            Console.WriteLine(b);
            Console.ReadLine();

        }
    }
}
