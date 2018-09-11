using System;
using System.Collections.Generic;

public class Class1
{
    public static void Main()
    {
        // Instantiate random number generator using system-supplied value as seed.
        Random rand = new Random();
       
        var myListOfIntegers = new List<int>();
     
        // getting random number
        for (int i = 0; i < 20; i++)
        {
            myListOfIntegers.Add(rand.Next(1,51));
        }

        foreach(int randomNumber in myListOfIntegers)
        {
            Console.WriteLine(randomNumber);
            
        }
        Console.WriteLine();


        // getting square numbers
        var randomIntegers = new List<int>();
        foreach(int randomNumber in myListOfIntegers)
        {
            var squaredRoot = randomNumber * randomNumber;
            randomIntegers.Add(squaredRoot);
           
        }

        foreach (int randomNumber in randomIntegers)
        {
            Console.WriteLine(randomNumber);

        }
        Console.WriteLine();

        // getting even numbers
        var evenNumbers = new List<int>();
        foreach (int squarednumber in randomIntegers)
        {
            if (squarednumber % 2 == 0)
            {
                evenNumbers.Add(squarednumber);
            }
        }

        foreach (int squaredNumber in evenNumbers)
        {
            Console.WriteLine(squaredNumber);

        }

        Console.ReadLine();
    }
}
