using System;

namespace twentyOnegame2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the grand hotel and casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer = "ya")
            {
                Player player = new Player
            }
        }
    }
}
