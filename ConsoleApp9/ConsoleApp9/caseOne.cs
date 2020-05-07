using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
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
