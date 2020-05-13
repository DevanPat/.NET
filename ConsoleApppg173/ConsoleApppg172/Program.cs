using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppg172
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employees = new Employee();
            employees.fName = "John ";
            employees.lName = "Stamop";
            employees.SayName();
            Console.ReadLine();


            IQuittable person1 = new Employee();
            person1.Quit();

        }
    }
}
