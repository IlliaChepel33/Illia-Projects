// CS30 C# Intro
// Mrs. Bender
// March 19, 2025
// HandIn
// The program generates a random number (in a range defined by the user) and tries to guess it (# of attempts is also defined by the user)

using System;

class Program
{
    public static void Main (string[] args)
    {
        int max = 0;
        int tries = 0;


        // user prompts
        try
        {
            Console.Write("How many possible answers? ");
            max = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many attempts? ");
            tries = Convert.ToInt32(Console.ReadLine());
            if (max <= 0 | tries <= 0)
            {
                throw new FormatException();
            }
        }
        catch (FormatException)
        {

            // closes the program if the format is wrong 
            Console.WriteLine("Please use positive numbers.\n");
            Environment.Exit(0);
        }


        // so that the number won't be negative or 0
        int min = 1;

        Random numberGenerator = new Random();


        // random number
        int ans = numberGenerator.Next(min, max);
        Console.WriteLine($"The number to be guessed is {ans}");


        // try random numbers to figure out the answer
        for (int x=0; x <= tries; x++)
        {
            if (x==tries)
            {
                Console.WriteLine("Ran out of attempts.");
                break;
            }

            // random guess
            int num = numberGenerator.Next(min, max);

            // if the number is correct
            if (num == ans)
            {
                Console.WriteLine($"Attempt #{x+1}. The answer is {num}");
                break;
            }


            // if number is less than the answer
            else if (num < ans)
            {
                Console.WriteLine($"Attempt #{x+1}. {num} is too small");

                // changes the range of random numbers to be (num+1(*new min*), max)
                min = num+1;
            }


            // if number is bigger than the answer
            else if (num > ans)
            {
                Console.WriteLine($"Attempt #{x+1}. {num} is too big");

                // changes the range of random numbers to be (min, num(*new max*))
                max = num;
            }
        }
    }
}