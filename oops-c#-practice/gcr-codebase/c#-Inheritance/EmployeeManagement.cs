using System;

class Employee
{
    public string Name;
    public int Id;
    public double Salary;

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Id: {Id}, Salary: {Salary}");
    }
}

class Manager : Employee
{
    public int TeamSize;

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Team Size: " + TeamSize);
    }
}

class Program
{
    static void Main()
    {
        Manager m = new Manager
        {
            Name = "Vansh",
            Id = 101,
            Salary = 75000,
            TeamSize = 5
        };

        m.DisplayDetails();
    }
}
