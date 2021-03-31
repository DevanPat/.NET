using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
        try
        {
            List<int> intLists = new List<int>();
            intLists.Add(10);
            intLists.Add(12);
            intLists.Add(15);
            intLists.Add(20);
            Console.WriteLine("Enter a divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("The quotient is: " + intLists[i] / divisor);
            }
            Console.ReadLine();
        }

        catch (FormatException)
        {
            Console.WriteLine("Type a whole number please.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("You can not divide by zero in this program.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }











        }
    }

