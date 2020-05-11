using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppg170
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
        }
    }
}
