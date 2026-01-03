using System;

class Employee
{
    public static string CompanyName = "TechCorp";
    private static int totalEmployees = 0;

    public readonly int Id;
    public string Name;
    public string Designation;

    public Employee(int id, string name, string designation)
    {
        this.Id = id;
        this.Name = name;
        this.Designation = designation;
        totalEmployees++;
    }

    public static void DisplayTotalEmployees()
    {
        Console.WriteLine("Total Employees: " + totalEmployees);
    }

    public void Display(object obj)
    {
        if (obj is Employee)
        {
            Console.WriteLine($"{Name} ({Designation}), ID: {Id}");
        }
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee(1, "Vansh Tyagi", "Developer");
        emp.Display(emp);
        Employee.DisplayTotalEmployees();
    }
}
