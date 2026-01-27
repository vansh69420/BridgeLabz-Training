using System;

class Student
{
    public Student()
    {
        Console.WriteLine("Student object created");
    }
}

class DynamicObject
{
    static void Main()
    {
        Type t = typeof(Student);
        object obj = Activator.CreateInstance(t);
    }
}
