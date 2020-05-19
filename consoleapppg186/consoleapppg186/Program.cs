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

            Console.WriteLine("User please enter the current day of the week.");
            string dayUser = Console.ReadLine();
            Day day = (Day)Enum.Parse(typeof(Day), dayUser);
            Console.WriteLine(dayUser);
            Console.ReadLine();
        }

        public enum Day
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }


    }
}















