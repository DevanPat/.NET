using System;
using System.Text;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Greetings ";
            string name2 = "and salutations from the Museum Hergenshmergelwerber's Planetarium";
            string name3 = " I hope you enjoy the show.";
            name1 = name1.ToUpper();
            string name = name1 + name2 + name3;
            Console.WriteLine(name);
            StringBuilder Strinbu = new StringBuilder();
            Strinbu.Append("My name is Devan Raj. ");
            Strinbu.Append("I was born in Houston, Texas. ");
            Strinbu.Append("I am 24 years old. ");
            Strinbu.Append("I am half Indian.");
            Console.WriteLine(Strinbu);
            Console.ReadLine();

        }
    }
}

            


