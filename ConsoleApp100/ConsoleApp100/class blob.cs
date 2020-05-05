using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp100
{
    class classBlob
    {


        public int methodOne(int x, string y)
        {
            int result = 0;
            if (y == "")
            {
                result = x + 5;
                Console.WriteLine("The user did not enter value, program defaults to 5 for second number");
            }
            else
            {
               int b = Convert.ToInt32(y);
                result = x + b;
                Console.WriteLine("You entered a value for the second number we added them together.");
            }
            return result;
                

        }

    }
    
}
    

