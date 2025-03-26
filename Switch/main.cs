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

        // random numbers to be multiplied
        int num01 = numberGenerator.Next(1, 100);
        int num02 = numberGenerator.Next(1, 100);


        Start:

        // prompt the user to answer the question
        Console.Write($"What is {num01} * {num02}? ");
        int answer = Convert.ToInt32(Console.ReadLine());

        // if the answer is right
        if (answer == num01 * num02)
        {

            // the range for random number is bigger than the number of cases, so default will be returned when randResponce == 4, 5, 6
            int randResponse = numberGenerator.Next(1, 7);

            // random responses to right answers
            switch (randResponse)
            {

                // first response
                case 1:
                    Console.WriteLine("Good Job.");
                    break;

                // second response
                case 2:
                    Console.WriteLine("The answer is correct.");
                    break;

                // third response
                case 3:
                    Console.WriteLine($"{num01} * {num02} does equal {answer}.");
                    break;

                // default response
                default:
                    Console.WriteLine("Good Job");
                    break;
            }
        }

        // if the answer is incorrect
        else
        {   

            // if the user answer is smaller
            if (answer < (num01*num02))
            {
                int randResponse = numberGenerator.Next(1, 7);


                // random responses
                switch(randResponse)
                {
                case 1:
                    Console.WriteLine("The answer is incorrect. Try a bigger number.");
                    goto Start;
                case 2:
                    Console.WriteLine($"{num01} * {num02} is bigger than that. Try again");
                    goto Start;
                default:
                    Console.WriteLine("Try a bigger number.");
                    goto Start;
                }
            }

            // if the user answer is bigger
            else if (answer > (num01*num02))
            {
                int randResponse = numberGenerator.Next(1, 7);


                // random responses
                switch(randResponse)
                {
                case 1:
                    Console.WriteLine("The answer is incorrect. Try a smaller number.");
                    goto Start;
                case 2:
                    Console.WriteLine($"{num01} * {num02} is smaller than that. Try again");
                    goto Start;
                default:
                    Console.WriteLine("Try a smaller number.");
                    goto Start;
                }

            }
        }
    }
} 