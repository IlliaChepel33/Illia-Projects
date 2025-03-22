// CS30 C# Intro
// Mrs. Bender
// March 19, 2025
// Calculator with 4 operators


using System;

class Program
{
    public static void Main (string[] args)
    {

        Console.Write("Type in the first number: ");
        int num01 = Convert.ToInt32(Console.ReadLine()); // integer 1

        Console.Write("Type in the second number: ");
        int num02 = Convert.ToInt32(Console.ReadLine()); // integer 2

        Console.Write("What opeartion do you want to do (type +, -, * or /): ");
        var sign = Console.ReadLine(); // sign

        if (sign == "+") // if "+"
        {
            Console.WriteLine("The result is " + (num01 + num02));
        }
        else if (sign == "-") // if "-"
        {
            Console.WriteLine("The result is " + (num01 - num02));
        }
        else if (sign == "*") // if "*"
        {
            Console.WriteLine("The result is " + (num01 * num02));
        }
        else if (sign == "/") // if "/"
        {
            Console.WriteLine("The result is " + (num01 / num02));
        }
    }
}
