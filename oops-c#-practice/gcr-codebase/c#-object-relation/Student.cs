using System;
using System.Collections.Generic;

class Course
{
    public string CourseName;
    public List<Student> Students = new List<Student>();
}

class Student
{
    public string Name;
    public List<Course> Courses = new List<Course>();

    public void Enroll(Course course)
    {
        Courses.Add(course);
        course.Students.Add(this);
        Console.WriteLine($"{Name} enrolled in {course.CourseName}");
    }

    public void ShowCourses()
    {
        Console.WriteLine($"\nCourses of {Name}:");
        foreach (var c in Courses)
            Console.WriteLine(c.CourseName);
    }
}

class School
{
    public List<Student> Students = new List<Student>();
}

class Program
{
    static void Main()
    {
        School school = new School();

        Student s1 = new Student { Name = "Vansh" };
        Student s2 = new Student { Name = "Aarav" };

        Course c1 = new Course { CourseName = "AI" };
        Course c2 = new Course { CourseName = "ML" };

        school.Students.Add(s1);
        school.Students.Add(s2);

        s1.Enroll(c1);
        s1.Enroll(c2);
        s2.Enroll(c1);

        s1.ShowCourses();
        s2.ShowCourses();

        Console.WriteLine("\nStudents enrolled in AI:");
        foreach (var s in c1.Students)
            Console.WriteLine(s.Name);
    }
}
