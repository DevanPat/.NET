using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_s_Daily_Report
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.ReadLine();
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("The Coursename is " + courseName);
            Console.WriteLine("What page number are you on?");
            int pageNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Page Number is " + pageNum);
            Console.WriteLine("Do you need help with anything? Please answer true or false.");
            bool doyouNeedHelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you would like to share? Please give specifics.");
            Console.ReadLine();
            Console.WriteLine("Is there any other feedback you would like to provide? Please be specific.");
            Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("I have studied for " + hoursStudied + " hours.");
            Console.WriteLine("Thankyou for all of your answers. An instructor will respond to you shortly! Have a great day!");
            Console.ReadLine();

            
            

        }
    }
}
