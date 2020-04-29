using System;
using System.Collections.Generic;
using System.ComponentModel;



class Program
{
    static void Main()
    {
        string[] samWiches = { "Greetings", "from", "sandwich depot", "we have", "the best sandwiches" };
        Console.WriteLine("Hello User! Please input text!");
        string userTexts = Console.ReadLine();

        for (int i = 0; i < samWiches.Length; i++)
        {
            samWiches[i] = samWiches[i] + userTexts;
        }

        for (int i = 0; i < samWiches.Length; i++)
        {
            Console.WriteLine(samWiches[i]);
        }

        int e = 2;
        while (true)
        {
            Console.WriteLine(e++);
            if (e > 25) break;
        }

        int b = 1;
        do
        {
            Console.WriteLine("Coleslaw is nasty!");
            b++;
        }
        while (b < 20);

        int c = 25;
        do
        {
            Console.WriteLine("Sometimes coffee can taste like burnt burgers.");
            c++;
        }
        while (c <= 55);

        List<string> randomVals = new List<string>();
        randomVals.Add("orange");
        randomVals.Add("wall");
        randomVals.Add("tea");
        randomVals.Add("rain");
        Console.WriteLine("Hello user please input text!");
        string userWrite = Console.ReadLine();
        for (int i = 0; i < randomVals.Count; i++)
        {
            if (userWrite == randomVals[i])
            {
                Console.WriteLine("Match found at: " + i);
            }
            else
            {
                Console.WriteLine("Match was not found at index: " + i);
            }
        }

        List<string> sanDals = new List<string>();
        sanDals.Add("burrito");
        sanDals.Add("phone");
        sanDals.Add("sun");
        sanDals.Add("phone");
        Console.WriteLine("Hi user please input text!");
        string userInput = Console.ReadLine();
        for (int i = 0; i < sanDals.Count; i++)
            if (userInput == sanDals[i])
            {
                Console.WriteLine("Match found at: " + i);
            }
            else
            {
                Console.WriteLine("Match was not found at index: " + i);
            }




        List<string> lisStrings = new List<string>();
        lisStrings.Add("tennis");
        lisStrings.Add("hat");
        lisStrings.Add("plate");
        lisStrings.Add("hat");
        List<string> listStringscopy = new List<string>();
        foreach (string lisString in lisStrings)
        {
            foreach (string element in listStringscopy)
            {
                if (lisString == element)
                {
                    Console.WriteLine("A match has been found for the word: " + lisString);
                }
            }
            listStringscopy.Add(lisString);
        }

    
    }

}















        
    

