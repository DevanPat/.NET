using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppg165
{
    public class Person
    {
        public List <string> fNames { get; set; }
        public List <string> lNames { get; set; }

        public void sayName()
        {
            foreach (string fName in fNames)
            {
                foreach (string lName in lNames)
                {
                    Console.WriteLine("Name: " + fName + lName);
                }
            }
        }

    }
}
