using System;

class Circle
{
    public double radius;

    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    public double CalculateCircumference()
    {
        return 2 * Math.PI * radius;
    }

    public void DisplayResults()
    {
        Console.WriteLine("Radius: " + radius);
        Console.WriteLine("Area: " + CalculateArea());
        Console.WriteLine("Circumference: " + CalculateCircumference());
    }
}

class Program
{
    static void Main()
    {
        Circle c = new Circle();
        Console.WriteLine("Enter radius of circle :");
        c.radius = Convert.ToDouble(Console.ReadLine());

        c.DisplayResults();
    }
}
