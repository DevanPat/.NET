using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppg165
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee Person = new Employee();
            Person.fNames = new List<string> { "Sample" };
            Person.lNames = new List<string> { "Student" };
            Person.sayName();
            Console.ReadLine();




        }
    }
}
