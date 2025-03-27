// CS30 C# Intro
// Mrs. Bender
// March 19, 2025
// HandIn

using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("How many possible answers? ");
        var max = Convert.ToInt32(Console.ReadLine());
        Console.Write("How many attempts? ");
        var tries = Convert.ToInt32(Console.ReadLine());

        int min = 1;

        Random numberGenerator = new Random();

        int ans = numberGenerator.Next(min, max);


        for (int x=0; x < tries; x++)
        {

            int num = numberGenerator.Next(min, max);
            if (num == ans)
            {
                Console.WriteLine($"Attempt #{x}. The answer is {num}");
                break;
            }
            else if (num < ans)
            {
                Console.WriteLine($"Attempt #{x}. {num} is too small");
                if (min==num)
                {
                    min = num+1;
                }
                else
                {
                min = num;
                }
            }
            else if (num > ans)
            {
                Console.WriteLine($"Attempt #{x}. {num} is too big");
                max = num;
            }
        }
    }
}