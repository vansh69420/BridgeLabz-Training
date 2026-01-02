using System;

class CourseManagement
{
    // Instance variables
    public string courseName;
    public int duration;
    public double fee;

    // Class variable
    public static string instituteName = "GLA University";

    // Constructor
    public CourseManagement(string name, int duration, double fee)
    {
        this.courseName = name;
        this.duration = duration;
        this.fee = fee;
    }

    // Instance method
    public void DisplayCourseDetails()
    {
        Console.WriteLine("Institute: " + instituteName);
        Console.WriteLine("Course Name: " + courseName);
        Console.WriteLine("Duration: " + duration + " months");
        Console.WriteLine("Fee: ₹" + fee);
    }

    // Class method
    public static void UpdateInstituteName(string newName)
    {
        instituteName = newName;
    }
}

class Program
{
    static void Main()
    {
        CourseManagement c1 = new CourseManagement("AIML", 6, 45000);
        CourseManagement c2 = new CourseManagement("Data Science", 8, 60000);

        CourseManagement.UpdateInstituteName("GLA University");

        c1.DisplayCourseDetails();
        Console.WriteLine();

        c2.DisplayCourseDetails();
    }
}
