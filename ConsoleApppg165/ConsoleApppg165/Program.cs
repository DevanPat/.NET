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
            Person.fNames = new List<string> { "Sample", "John" };
            Person.lNames = new List<string> { "Student", "Sumorop" };
            Employee employee = new Employee();
            employee.ID = new List<int> { 88, 99 };
            Employee employeeID1 = new Employee();
            Employee employeeID2 = new Employee();
            

            
           
            Person.sayName();
            Console.ReadLine();

            




        }
    }
}
