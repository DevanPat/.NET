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


             Day Day = new Day();
                Console.WriteLine("User please enter the current day of the week.");
            int dayUser = Convert.ToInt32(Console.ReadLine());
            if (dayUser == Day)
            {
                Console.WriteLine(Day);
            }
          
       

            

        }



      

    }
    }

