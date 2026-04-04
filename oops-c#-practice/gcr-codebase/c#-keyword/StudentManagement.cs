using System;

class Student
{
    public static string UniversityName = "GLA University";
    private static int totalStudents = 0;

    public readonly int RollNumber;
    public string Name;
    public char Grade;

    public Student(int roll, string name, char grade)
    {
        this.RollNumber = roll;
        this.Name = name;
        this.Grade = grade;
        totalStudents++;
    }

    public static void DisplayTotalStudents()
    {
        Console.WriteLine("Total Students: " + totalStudents);
    }

    public void Display(object obj)
    {
        if (obj is Student)
        {
            Console.WriteLine($"{Name}, Roll: {RollNumber}, Grade: {Grade}");
        }
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student(101, "Vansh", 'A');
        s.Display(s);
        Student.DisplayTotalStudents();
    }
}
