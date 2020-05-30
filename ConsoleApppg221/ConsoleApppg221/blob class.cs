using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppg221
{
    class Blob
    {
        public Blob(string age) : this(age, 40)
        {
        }

        public Blob (string age, int hoursWorked)
        {
            weekHours = hoursWorked;
            Age = age;
        }




        public string Age { get; set; }
        public int weekHours { get; set; }
    }
}
