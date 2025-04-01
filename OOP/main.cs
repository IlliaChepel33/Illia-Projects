// CS30 C#
// Mrs. Bender
// April 1, 2025
// OOP

using System;



class Program
{
    static void Main (string[] args)
    {
        
    }
}

class Business
{
    string city = "None";
    string name = "None";
    int age;


    // for user input
    public void getInfo ()
    {
        Console.Write("What is the person's city? ");
        city = Console.ReadLine()!;
        Console.Write("What is the person's full name? ");
        name = Console.ReadLine()!;
        Console.Write("What is the person's age? ");
        age = Convert.ToInt32(Console.ReadLine());
    }


    // the printbase method
    public void PrintBase ()
    {
        Console.WriteLine("Location: " + city);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class Manager : Business
{
    string location = "None";
    int num_people;
    List<string> people = new List<string>() {};

    public void mngInfo ()
    {
        Console.WriteLine("What is the location?");
        location = Console.ReadLine()!;
        Console.WriteLine("How many people?");
        num_people = Convert.ToInt32(Console.ReadLine());
        for (int x=0; x<num_people; x++)
        {
            Console.WriteLine("Name of the managed person: ");
            people.Add(Console.ReadLine()!);
        }
    }

    public void PrintMng ()
    {
        Console.WriteLine("Location: " + location);
        Console.WriteLine("People managed: ");
        for (int x = 0; x < people.Count; x++)
        {
            Console.WriteLine("  * " + people[x]);
        }
    }
}