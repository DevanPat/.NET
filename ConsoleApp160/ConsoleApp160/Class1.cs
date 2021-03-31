using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppg160
{
   public class caseOne
    {
        public void methodOne(int x)
        {
            int result = x / 2;
            Console.WriteLine(result);
        }

        public int methodTwo(int x, out int y)
        { 
             y = x * 2;
            return y;
        }
        

        
    }
}
