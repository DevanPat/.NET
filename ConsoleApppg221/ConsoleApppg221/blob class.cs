using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppg221
{
    class Blob
    {
        public Blob(string age) : this(age, "")
        {
        }

        public Blob (string age, string hoursWorked)
        {
            weekHours = hoursWorked;
            Age = age;
        }




        public string Age { get; set; }
        public string weekHours { get; set; }
    }
}
