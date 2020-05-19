using System;
using System.Collections.Generic;
using System.Globalization;
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

            //Employee<string> employees = new Employee<string>();
            //employees.Things = new List<string> { "John", "Bill" };
            //Employee<int> employee1s = new Employee<int>();
            //employee1s.Things = new List<int> { 1, 3 };

            //foreach (string employee in employees.Things)
            //{
            //    Console.WriteLine(employee);
            //    }
            //    foreach (int employee1 in employee1s.Things)
            //{
            //    Console.WriteLine(employee1);
            //}
            //Console.ReadLine();

            Employee<string> employees = new Employee<string>();
            employees.Things = new List<string> { "John Mark", "Bill Smith", "Joe Smithers", "Joe Flab", "Bob Lino", "Grace Snow", "Sarah Beverly", "Lisa Sanders", "Sally Yu", "Patty Enriques" };
            Employee<int> employee1s = new Employee<int>();
            employee1s.Things = new List<int> { 1, 3, 7, 9, 2, 22, 33, 44, 31, 49 };


            employee1s.Things = employee1s.Things.Where(x => x > 5).ToList();
            Console.WriteLine(employee1s.Things);
            Console.ReadLine();


            Employee<string> employee2s = new Employee<string>();
            employee2s.Things = new List<string> { };
            foreach (string employee2 in employee2s.Things)
            {
                employee2s.Things.Add("Joe Mark");
                employee2s.Things.Add("Joe Buv");
            }

            List<string> stringList = new List<string>() { "Joe", "Joe" };

            string Find = stringList.Where(x => stringList.Joe == stringList.Joe);




            //Console.WriteLine(Find);


            Console.ReadLine();











            Console.ReadLine();

        }
    }
}
            
          
            

            
           

            



