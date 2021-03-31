using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
        public class caseOne
        {
            public void methodOne(out int x)
            {
            Console.WriteLine("User enter a number.");
            x = Convert.ToInt32(Console.ReadLine());
            x = x / 2;
            Console.WriteLine(x);
                
            }

            public int methodTwo(int x, out int y)
            {
                y = x * 2;
                return y;
            }

            public int methodThree(int c, int d)
            {
            int g = c * d;
            return g;
            }

            public double methodThree(double e, double f)
            {
            double q = e - f;
            return q;
            }


        }
    }
