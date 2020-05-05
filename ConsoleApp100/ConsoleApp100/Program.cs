using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp100
{
    class Program
    {
        public static void Main(string[] args)
        {
            classBlob classBlobs = new classBlob();

            Console.WriteLine("User please input a number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number which is optional. Press enter if you don't want to enter a number.");
            string y = Console.ReadLine();
            int answer2 = classBlobs.methodOne(x, y);
            Console.WriteLine("Your answer is " + answer2);
            Console.ReadLine();



       

          

        }
    }
           

     
}
