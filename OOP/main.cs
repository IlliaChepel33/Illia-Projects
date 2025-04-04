// CS30 C#
// Mrs. Bender
// April 1, 2025
// OOP

using System;



class Program
{
    static void Main (string[] args)
    {
        Business director = new Business();
        director.name = "David";
        director.city = "Seattle";
        director.position = "Director";
        director.age = 42;
        director.PrintBase();

        Business person = new Business();
        person.getInfo();
        person.PrintBase();

        Manager ben = new Manager();
        ben.name = "Ben";
        ben.city = "Chicago";
        ben.age = 39;
        ben.num_people = 25;
        ben.location = "Lake St. 113";
        ben.PrintBase();
        ben.PrintMng();

        Manager manager = new Manager();
        manager.getInfo();
        manager.mngInfo();
        manager.PrintBase();
        manager.PrintMng();

        Employee ron = new Employee();
        ron.name = "Ron";
        ron.city = "Calgary";
        ron.age = 31;
        ron.manager = "Peter";
        ron.rspb = "Tech. support";

        Employee employee = new Employee();
        employee.getInfo();
        employee.empInfo();
        employee.PrintBase();
        employee.PrintEmp();
    }
}

public class Business
{
    public string position = "None";
    public string city = "None";
    public string name = "None";
    public int age;


    // for user input
    public void getInfo ()
    {
        if (position == "None")
        {
            Console.Write("What is the person's position? ");
            position = Console.ReadLine()!;
        }

        Console.Write("What is the person's city? ");
        city = Console.ReadLine()!;
        Console.Write("What is the person's name? ");
        name = Console.ReadLine()!;
        Console.Write("What is the person's age? ");
        age = Convert.ToInt32(Console.ReadLine());
    }


    // the printbase method
    public void PrintBase ()
    {
        Console.WriteLine("Position: " + position);
        Console.WriteLine("Location: " + city);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("---------------------------");
    }
}

class Manager : Business
{
    public Manager()
    {
        position = "Manager";
    }
    public string location = "None";
    public int num_people;
    public List<string> people = new List<string>() {};

    public void mngInfo ()
    {
        Console.Write("What is the location? ");
        location = Console.ReadLine()!;
        Console.Write("How many people? ");
        num_people = Convert.ToInt32(Console.ReadLine());
        for (int x=0; x<num_people; x++)
        {
            Console.Write("Name of the managed person: ");
            people.Add(Console.ReadLine()!);
        }
    }

    public void PrintMng ()
    {
        Console.WriteLine($"MANAGER {name} specifics:");
        Console.WriteLine("Location managed: " + location);
        Console.WriteLine("People managed: " + num_people);
        for (int x = 0; x < people.Count; x++)
        {
            Console.WriteLine("  * " + people[x]);
        }
        Console.WriteLine("---------------------------");
    }
}

class Employee : Business
{
    public Employee ()
    {
        position = "Regular Employee";
    }
    public string manager = "None";
    public string rspb = "None";
    
    public void empInfo ()
    {
        Console.WriteLine("Who is the employee's manager? ");
        manager = Console.ReadLine()!;
        Console.Write("What are the emplyee's responsibilities? ");
        rspb = Console.ReadLine()!;
    }

    public void PrintEmp ()
    {
        Console.WriteLine($"REGULAR EMPLOYEE {name} specifics:");
        Console.WriteLine("Manager: " + manager);
        Console.WriteLine("Responsibilities: " + rspb);
        Console.WriteLine("---------------------------");
    }
}