// CS30 C# Intro
// Mrs. Bender
// March 19, 2025
// For loop for only even numbers

using System;

class Program
{
    public static void Main (string[] args)
    {

        // the for loop
        for (int x = 0; x < 100; x++)
        {
            // if the remainder is 0 when x is divided by 2 (and 0 is ignored)
            if ((x%2) != 0 | x == 0)
            {

                // start the next step in the loop
                continue;
            }
            else
            {

                // write the number
                Console.WriteLine(x);
            }
        }
    }
}