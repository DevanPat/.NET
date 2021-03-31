using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppg170
{
    public abstract class Person : IQuittable
    {
        public string fName { get; set; }
        public string lName { get; set; }

        public abstract void SayName();
        
    }
}
