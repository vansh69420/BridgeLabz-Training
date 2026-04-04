using System;

class DistanceAndLine
{
    // a. Method to calculate Euclidean distance
    public static double CalculateDistance(double x1, double y1, double x2, double y2)
    {
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return distance;
    }

    // d. Method to find slope and y-intercept of the line
    public static double[] FindLineEquation(double x1, double y1, double x2, double y2)
    {
        double[] equation = new double[2]; // [0] = slope (m), [1] = intercept (b)

        if (x2 == x1) // vertical line
        {
            equation[0] = double.NaN; // slope undefined
            equation[1] = double.NaN; // intercept not defined
        }
        else
        {
            double m = (y2 - y1) / (x2 - x1);
            double b = y1 - m * x1;

            equation[0] = m;
            equation[1] = b;
        }

        return equation;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        double distance = CalculateDistance(x1, y1, x2, y2);
        Console.WriteLine("\nEuclidean distance between points: " + distance);

        double[] lineEq = FindLineEquation(x1, y1, x2, y2);

        if (double.IsNaN(lineEq[0]))
        {
            Console.WriteLine("The line is vertical. Equation: x = " + x1);
        }
        else
        {
            Console.WriteLine("Equation of the line: y = " + lineEq[0] + "x + " + lineEq[1]);
        }
    }
}
