using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwentyOne123;
using System.IO;

namespace TwentyOne123
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("C:\\Users\\devan\\c-logs\\log.txt");

            Console.WriteLine("Welcome to the grand hotel and casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new twentyonegame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                    Console.WriteLine("Thankyou for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();


























            //Card card1 = new Card();
            //Card card2 = card1;
            //card1.Face = Face.Eight;
            //card2.Face = Face.King;

            //Console.WriteLine(card1.Face);
            //twentyonegame game = new twentyonegame();
            //game.Players = new List<string>() { "Daryl", "Joe", "Sam" };
            //game.ListPlayers();
            //Console.ReadLine();
            //List<game> games = new List<game>();
            //games.Add(game);
            //Card card = new Card();
            //card.Suit = Suit.Clubs;
            //int underlyingValue = (int)Suit.Diamonds;
            //Console.WriteLine(underlyingValue);

            //Game game = new twentyonegame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Devan";
            //game += player;
            //game -= player;    
           
            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();

            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //}


            //int count = deck.Cards.Count(x => x.Face == Face.Ace);

            //Console.WriteLine(count);



            //Deck deck = new Deck();

            //List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };
            

            //int sum = numberList.Where(x => x > 20).Sum();

            //Console.WriteLine(sum);


            //Console.ReadLine();




            //    foreach (Card card in deck.Cards)
            //    {
            //        Console.WriteLine(card.Face + " of " + card.Suit);
            //    }
            //    Console.WriteLine(deck.Cards.Count);
            //    Console.ReadLine();
            //}

            ////public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
            ////{
            ////    timesShuffled = 0;
            ////    for (int i = 0; i < times; i++)
            ////    {
            ////        timesShuffled++;
            ////        List<Card> TempList = new List<Card>();
            ////        Random random = new Random();

            ////        while (deck.Cards.Count > 0)
            ////        {
            ////            int randomIndex = random.Next(0, deck.Cards.Count);
            ////            TempList.Add(deck.Cards[randomIndex]);
            ////            deck.Cards.RemoveAt(randomIndex);
            ////        }
            ////        deck.Cards = TempList;
            ////    }
            ////    return deck;
            ////}

            ////public static Deck Shuffle(Deck deck, int times)
            ////{
            ////    for (int i = 0; i < times; i++)
            ////    {
            ////        deck = Shuffle(deck);
            ////    }
            ////    return deck;
            ////}



        }
    }
}


    