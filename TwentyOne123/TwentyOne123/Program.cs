using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne123
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";


            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\devan\c-logs\log.txt", true))
                {
                    file.WriteLine(DateTime.Now);
                    file.WriteLine(player.Id);
                }
                Game game = new twentyonegame();
                game += player;
                player.isActivelyPlaying = true;

                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    {
                        try
                        {
                            game.Play();
                        }
                        catch (FraudException)
                        {
                            Console.WriteLine("Security kick this person out!");
                            Console.ReadLine();
                            return;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("An error occurred. Please contact your system administrator.");
                            Console.ReadLine();
                            return;
                        }
                    }
                    game -= player;
                    Console.WriteLine("Thankyou for playing!");
                }
                Console.WriteLine("Feel free to look around the casino. Bye for now.");
                Console.Read();
            }

            private static void UpdateDbWithException(Exception ex)
            {
                string ConnectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
            }

      


        }
    }
}


    