using System;
using System.Collections.Generic;

public class Class1
{
    public static void Main()
    {
        // Instantiate random number generator using system-supplied value as seed.
        Random rand = new Random();
       
        var myListOfIntegers = new List<int>();
     

        for (int i = 0; i < 20; i++)
        {
            myListOfIntegers.Add(rand.Next(1,51));
        }

        foreach(int randomNumber in myListOfIntegers)
        {
            Console.WriteLine(randomNumber);
            
        }
        Console.WriteLine();

        var randomIntegers = new List<int>();
        foreach(int randomNumber in myListOfIntegers)
        {
            var squaredRoot = randomNumber * randomNumber;
            randomIntegers.Add(squaredRoot);
           
        }
        Console.WriteLine();

        foreach (int randomNumber in randomIntegers)
        {
            Console.WriteLine(randomNumber);

        }
        Console.WriteLine();

        var evenNumbers = new List<int>();
        foreach (int squarednumber in randomIntegers)
        {
            if (squarednumber % 2 == 0)
            {
                evenNumbers.Add(squarednumber);
            }
            //console.writeline(evennumbers);
        }

        foreach (int squaredNumber in evenNumbers)
        {
            Console.WriteLine(squaredNumber);

        }

        // Console.WriteLine(evenNumbers);
        Console.ReadLine();
    }
}
