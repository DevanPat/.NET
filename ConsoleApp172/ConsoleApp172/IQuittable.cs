using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppg172
{
    interface IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("I wore socks though.");
        }
    }
}
