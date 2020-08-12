using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            List<Employee> employees = new List<Employee> {
            new Employee
            {
                FirstName = "John",
                LastName = "Tilt",
                ID = 1
            },
            new Employee
            {
                FirstName = "Stan",
                LastName = "Box",
                ID = 2
            },
            new Employee
            {
                FirstName = "Joe",
                LastName = "Smot",
                ID = 3
            },
            new Employee
            {
                FirstName = "Bill",
                LastName = "Splat",
                ID = 4
            },
            new Employee
            {
                FirstName = "Tom",
                LastName = "Pat",
                ID = 5
            },
            new Employee
            {
                FirstName = "Sally",
                LastName = "Dallas",
                ID = 6
            },
            new Employee
            {
                FirstName = "Joe",
                LastName = "Bob",
                ID = 7
            },
            new Employee
            {
                FirstName = "Tim",
                LastName = "Sand",
                ID = 8
            },
            new Employee
            {
                FirstName = "Nancy",
                LastName = "Apple",
                ID = 9
            },
            new Employee
            {
                FirstName = "Jed",
                LastName = "Bread",
                ID = 10
            }
           };
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.FirstName);
            }
            List<Employee> employee1s = new List<Employee> {
            new Employee
            {
                FirstName = "Joe",
                LastName = "Todd",
                ID = 11
            },
            new Employee
            {
                FirstName = "Stan",
                LastName = "Flopper",
                ID = 12
            },
            new Employee
            {
                FirstName = "Joe",
                LastName = "Ted",
                ID = 13
            }
            };
            foreach (Employee employee1 in employee1s)
            {
                for (employee1.FirstName = "Joe")
                {
                    List<Employee> employee2s = new List<Employee>;
                    employee2s = employee1;
                }
            }

        };


            Console.ReadLine();

        }
    }
    

