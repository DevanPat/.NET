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
            //Employee Person = new Employee();
            //Person.fNames = "Sample";
            //Person.lNames = "Student";
            //Person.ID = 88;
            //Employee employee = new Employee();
            //employee.fNames = "John";
            //employee.lNames = "Stans";
            //employee.ID = 12;
            //Person.sayName();
            //Console.WriteLine(Person == employee);
            //Console.WriteLine(Person != employee);

            Employee<string> employees = new Employee<string>();
            employees.Things = new List<string> { "John", "Bill" };
            Employee<int> employee1s = new Employee<int>();
            employee1s.Things = new List<int> { 1, 3 };
        
            foreach (string employee in employees.Things)
            {
                Console.WriteLine(employee);
                }
                foreach (int employee1 in employee1s.Things)
            {
                Console.WriteLine(employee1);
            }
            Console.ReadLine();











            Console.ReadLine();

        }
    }
}
            
          
            

            
           

            



