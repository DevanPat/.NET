﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            caseOne caseOnes = new caseOne();

  
            int y = 0;

            caseOnes.methodOne(out y);
           
            Console.WriteLine("User please enter a number for a math operation.");
            int x = Convert.ToInt32(Console.ReadLine());
            int result = caseOnes.methodTwo(x, out y);
            Console.WriteLine(result);
            int num1 = caseOnes.methodThree(11, 15);
            double num2 = caseOnes.methodThree(12.5, 3.4);
            Console.WriteLine("Int: " + num1);
            Console.WriteLine("Double: " + num2);
            Console.ReadLine();
        }
    }
}


            

