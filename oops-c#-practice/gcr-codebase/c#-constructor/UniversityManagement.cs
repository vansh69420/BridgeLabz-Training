using System;

class Student
{
    public int rollNumber;
    protected string name;
    private double CGPA;

    public void SetCGPA(double cgpa)
    {
        CGPA = cgpa;
    }

    public double GetCGPA()
    {
        return CGPA;
    }

    public void SetName(string name)
    {
        this.name = name;
    }
}

class PostgraduateStudent : Student
{
    public void DisplayDetails()
    {
        Console.WriteLine("Roll Number: " + rollNumber);
        Console.WriteLine("Name: " + name); // protected access
        Console.WriteLine("CGPA: " + GetCGPA());
    }
}

class Program
{
    static void Main()
    {
        PostgraduateStudent pg = new PostgraduateStudent();
        pg.rollNumber = 101;
        pg.SetName("Vansh");
        pg.SetCGPA(8.9);

        pg.DisplayDetails();
    }
}
