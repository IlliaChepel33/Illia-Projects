// CS30 C# Intro
// Mrs. Bender
// March 19, 2025
// Giving different options for correct answers OR using the SWITCH statement

using System;


class Program
{
    public static void Main (String[] args)
    {
        Random numberGenerator = new Random();

        // random number to be multiplied
        int num01 = numberGenerator.Next(1, 100);
        int num02 = numberGenerator.Next(1, 100);


        Start:

        // prompt the user to answer the question
        Console.Write($"What is {num01} * {num02}? ");
        int answer = Convert.ToInt32(Console.ReadLine());

        // if the answer is right
        if (answer == num01 * num02)
        {
            Console.WriteLine("Good Job");
        }
        else
        {

            // the range for random number is bigger than the number of cases, so default will be returned when randResponce == 4, 5, 6
            int randResponse = numberGenerator.Next(1, 7);

            // random responses to wrong answers
            switch (randResponse)
            {

                // first response
                case 1:
                    Console.WriteLine("Wrong answer.");
                    goto Start;

                // second response
                case 2:
                    Console.WriteLine("The answer is incorrect.");
                    goto Start;

                // third response
                case 3:
                    Console.WriteLine($"{num01} * {num02} does not equal to {answer}.");
                    goto Start;

                // default response
                default:
                    Console.WriteLine("Try again.");
                    goto Start;
            }
        }
    }
} 