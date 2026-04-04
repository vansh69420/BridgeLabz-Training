using System;

class Employee
{
    public string name;
    public int id;
    public double salary;

    public void DisplayDetails()
    {
        Console.WriteLine("Employee Name: " + name);
        Console.WriteLine("Employee ID: " + id);
        Console.WriteLine("Salary: " + salary);
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee();

        emp.name = "Vansh";
        emp.id = 101;
        emp.salary = 45000;

        emp.DisplayDetails();
    }
}
