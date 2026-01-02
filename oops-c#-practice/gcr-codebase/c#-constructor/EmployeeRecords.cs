using System;

class Employee
{
    public int employeeID;
    protected string department;
    private double salary;

    public void SetSalary(double salary)
    {
        this.salary = salary;
    }

    public double GetSalary()
    {
        return salary;
    }

    public void SetDepartment(string dept)
    {
        department = dept;
    }
}

class Manager : Employee
{
    public void DisplayEmployeeDetails()
    {
        Console.WriteLine("Employee ID: " + employeeID);
        Console.WriteLine("Department: " + department);
        Console.WriteLine("Salary: ₹" + GetSalary());
    }
}

class Program
{
    static void Main()
    {
        Manager m = new Manager();
        m.employeeID = 201;
        m.SetDepartment("AIML");
        m.SetSalary(85000);

        m.DisplayEmployeeDetails();
    }
}
