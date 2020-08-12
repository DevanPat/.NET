using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp50
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<Employee> employees = new List<Employee>();
            
                employees.Add(new Employee() { FirstName = "Joe", LastName = "atu", ID = 1 });
                employees.Add(new Employee() { FirstName = "Tom", LastName = "mato", ID = 2 });
                employees.Add(new Employee() { FirstName = "Sally", LastName = "clop", ID = 3 });
                employees.Add(new Employee() { FirstName = "Lisa", LastName = "spont", ID = 4 });
                employees.Add(new Employee() { FirstName = "Sam", LastName = "roe", ID = 5 });
                employees.Add(new Employee() { FirstName = "Joe", LastName = "spin", ID = 6 });
                employees.Add(new Employee() { FirstName = "Patty", LastName = "Tolk", ID = 7 });
                employees.Add(new Employee() { FirstName = "Poe", LastName = "Folk", ID = 8 });
                employees.Add(new Employee() { FirstName = "Lila", LastName = "Polk", ID = 9 });
                employees.Add(new Employee() { FirstName = "Ezra", LastName = "Yolk", ID = 10 });

       

            List<Employee> employee1s = new List<Employee>();

            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    employee1s.Add(employee);
                }
            }
           foreach (Employee employee1 in employee1s)
            {
                Console.WriteLine(employee1.FirstName);
            }

            List<Employee> employee2s = (employees.Where(x => x.FirstName == "Joe")).ToList();
            foreach (Employee employee2 in employee2s)
            {
                Console.WriteLine(employee2.FirstName);
            }
            
            List<Employee> employee3s = (employees.Where(x => x.ID > 5)).ToList();
           foreach (Employee employee3 in employee3s)
            {
                Console.WriteLine(employee3.ID);
            }
            Console.ReadLine();
       
                
                
               
            
            

            


            
        }
    }
}
