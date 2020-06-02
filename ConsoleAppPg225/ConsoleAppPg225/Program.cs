using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPg225
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("User please enter your age below.");
            string yearBorn = Console.ReadLine();

            try
            {
                int yearBorn1 = Convert.ToInt32(yearBorn);
                if (yearBorn1 < 0)
                {
                    throw new WrongException();
                }
            }
           

            catch (WrongException)
            {
                Console.WriteLine("There was an error. Number must be above 0.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("There was an error. Please try again or contact the system administrator.");
                Console.ReadLine();
                return;
            }
           




        }
        }
    }


            
            
            
