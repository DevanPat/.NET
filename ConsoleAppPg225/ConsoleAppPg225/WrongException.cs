using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPg225
{
    class WrongException : Exception
    {
        public WrongException()
            : base() { }
        public WrongException(string message)
            : base(message) { }
        
        

    }
}
