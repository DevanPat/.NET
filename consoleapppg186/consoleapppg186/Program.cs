using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapppg186
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                Console.WriteLine("User please enter the current day of the week.");
                int Day = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Input was not in the correct format.");
            }
            Console.ReadLine();
       

            

        }



      

    }
    }

