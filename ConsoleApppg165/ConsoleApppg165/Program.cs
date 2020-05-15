using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppg165
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee Person = new Employee();
            Person.fNames = "Sample";
            Person.lNames = "Student";
            Person.ID = 88;
            Employee employee = new Employee();
            employee.fNames = "John";
            employee.lNames = "Stans";
            employee.ID = 12;
            Person.sayName();
            Console.WriteLine(Person == employee);
            Console.WriteLine(Person != employee);
            Console.ReadLine();

        }
    }
}
            
          
            

            
           

            



