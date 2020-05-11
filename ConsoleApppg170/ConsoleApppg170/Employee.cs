using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppg170
{
    public class Employee: Person
    {

         public override void SayName()
        {
            Console.WriteLine(fName + lName);
        }

     }
}
