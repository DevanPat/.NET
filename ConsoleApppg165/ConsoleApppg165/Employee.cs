using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppg165
{
    public class Employee : Person
    {
        public List<int> ID { get; set; }

        public static bool operator ==(Employee employeeID1, Employee employeeID2)
        {
            if (employeeID1 == employeeID2)
            {
                return true;
            }
            else 
            {
                return false;
            }
                
        }
    }
}
