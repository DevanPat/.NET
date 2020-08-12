using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WebApplication12
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();


            Employee employees = new Employee();
            List<Employee> Employeelist = new List<Employee>();
            new Employee
            {
                FirstName = "John",
                LastName = "Tilt",
                ID = 1
            };
            new Employee
            {
                FirstName = "Stan",
                LastName = "Box",
                ID = 2
            };
            new Employee
            {
                FirstName = "Joe",
                LastName = "Smot",
                ID = 3
            };
            new Employee
            {
                FirstName = "Bill",
                LastName = "Splat",
                ID = 4
            };
            new Employee
            {
                FirstName = "Tom",
                LastName = "Pat",
                ID = 5
            };
            new Employee
            {
                FirstName = "Sally",
                LastName = "Dallas",
                ID = 6
            };
            new Employee
            {
                FirstName = "Joe",
                LastName = "Bob",
                ID = 7
            };
            new Employee
            {
                FirstName = "Tim",
                LastName = "Sand",
                ID = 8
            };
            new Employee
            {
                FirstName = "Nancy",
                LastName = "Apple",
                ID = 9
            };
            new Employee
            {
                FirstName = "Jed",
                LastName = "Bread",
                ID = 10
            };
            foreach (Employee employee in Employeelist)
            {
                Console.WriteLine(employee);
            }
            Console.ReadLine();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
