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
            bool checkResult = false;
            int yearBorn = 0;
            try
            {
                while (!checkResult)
                {
                    Console.WriteLine("User please enter your age below.");
                    checkResult = int.TryParse(Console.ReadLine(), out yearBorn);
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
            finally 
            {
                 WrongException();
            }
            return;
           
               
            


        }
    }
}

            
            
            
