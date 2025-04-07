// CS30 C#
// Mrs. Bender
// April 1, 2025
// Illia Chepel
// OOP
// Database of Apple employees

using System;



class Program
{
    static void Main (string[] args)
    {

        // employee #1
        Business director = new Business();
        director.position = "Director";
        director.name = "David";
        director.city = "Seattle";
        director.age = 42;
        director.PrintBase();

        // employee #2
        Business person = new Business();
        person.getInfo();
        person.PrintBase();

        // manager #1
        Manager ben = new Manager();
        ben.name = "Ben";
        ben.city = "Chicago";
        ben.age = 39;
        ben.num_people = 25;
        ben.location = "Lake St. 113";
        ben.PrintBase();
        ben.PrintMng();

        // manager #2
        Manager manager = new Manager();
        manager.getInfo();
        manager.mngInfo();
        manager.PrintBase();
        manager.PrintMng();

        // regular employee #1
        Employee ron = new Employee();
        ron.name = "Ron";
        ron.city = "Calgary";
        ron.age = 31;
        ron.manager = "Peter";
        ron.rspb = "Tech. support";
        ron.PrintBase();
        ron.PrintEmp();

        // regular employee #2
        Employee employee = new Employee();
        employee.getInfo();
        employee.empInfo();
        employee.PrintBase();
        employee.PrintEmp();
    }
}

public class Business
{
    
    // fields
    public string position = "None";
    public string city = "None";
    public string name = "None";
    public int age;


    // for user input
    public void getInfo ()
    {
        
        // if the position was not previously specified
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
    // changes the parent class's field for each instance of this child class
    public Manager()
    {
        position = "Manager";
    }
    public string location = "None";
    public int num_people;
    public List<string> people = new List<string>() {};

    // user input
    public void mngInfo ()
    {
        Console.Write("What is the location? ");
        location = Console.ReadLine()!;
        Console.Write("How many people? ");
        num_people = Convert.ToInt32(Console.ReadLine());

        // to get the list of people
        for (int x=0; x<num_people; x++)
        {
            Console.Write("Name of the managed person: ");
            people.Add(Console.ReadLine()!);
        }
    }

    // prints manager-specific info
    public void PrintMng ()
    {
        Console.WriteLine($"MANAGER {name} specifics:");
        Console.WriteLine("Location managed: " + location);
        Console.WriteLine("People managed: " + num_people);

        // to print the list of people in case it was provided
        for (int x = 0; x < people.Count; x++)
        {
            Console.WriteLine("  * " + people[x]);
        }
        Console.WriteLine("---------------------------");
    }
}

class Employee : Business
{

    // regular employee fields
    public Employee ()
    {
        position = "Regular Employee";
    }
    public string manager = "None";
    public string rspb = "None";
    
    // user input
    public void empInfo ()
    {
        Console.Write("Who is the employee's manager? ");
        manager = Console.ReadLine()!;
        Console.Write("What are the emplyee's responsibilities? ");
        rspb = Console.ReadLine()!;
    }

    // prints info specific for regular employees
    public void PrintEmp ()
    {
        Console.WriteLine($"REGULAR EMPLOYEE {name} specifics:");
        Console.WriteLine("Manager: " + manager);
        Console.WriteLine("Responsibilities: " + rspb);
        Console.WriteLine("---------------------------");
    }
}