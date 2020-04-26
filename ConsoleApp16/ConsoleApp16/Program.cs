using System;
using System.Collections.Generic;
using System.ComponentModel;


    class Program 
    {
        static void Main()
        {
           
            string[] stringArray = new string[5] { "Hello", "my", "name", "is", "Devan"};
            int index = Convert.ToInt32(Console.ReadLine());

            if (index <= 4)
            {
                Console.WriteLine(stringArray[index]);
            }
            else
            {
                Console.WriteLine("This index does not exist");
            }

            int[] intArray = new int[5] { 12, 32, 500, 15, 234 };
            int index1 = Convert.ToInt32(Console.ReadLine());

            if (index1 <= 4)
            {
                Console.WriteLine(intArray[index1]);
            }
            else
            {
                Console.WriteLine("This index does not exist");
            }

            List<string> stringList = new List<string>();
            stringList.Add("Jim");
            stringList.Add("Bonnie");
            stringList.Add("Sarah");
            stringList.Add("Tom");
            Console.WriteLine("Select an index from the List");
            int index3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringList[index3]);













        




    }
}

