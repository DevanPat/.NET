﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwentyOne123;

namespace TwentyOne123
{
    class Program
    {
        static void Main(string[] args)
        {
            List<game> games = new List<game>();
            twentyonegame game = new twentyonegame();
            games.Add(game);


            Deck deck = new Deck();
            deck.Shuffle(3);
        


            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        //public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        //{
        //    timesShuffled = 0;
        //    for (int i = 0; i < times; i++)
        //    {
        //        timesShuffled++;
        //        List<Card> TempList = new List<Card>();
        //        Random random = new Random();

        //        while (deck.Cards.Count > 0)
        //        {
        //            int randomIndex = random.Next(0, deck.Cards.Count);
        //            TempList.Add(deck.Cards[randomIndex]);
        //            deck.Cards.RemoveAt(randomIndex);
        //        }
        //        deck.Cards = TempList;
        //    }
        //    return deck;
        //}

            //public static Deck Shuffle(Deck deck, int times)
            //{
            //    for (int i = 0; i < times; i++)
            //    {
            //        deck = Shuffle(deck);
            //    }
            //    return deck;
            //}

        }
    }


    