using System;

class Quadratic
{
    static void Main(string[] args)
    {
        Console.Write("Enter value of a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value of b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value of c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double[] roots = FindRoots(a, b, c);

        if (roots.Length == 2)
        {
            Console.WriteLine("Two real roots:");
            Console.WriteLine("Root 1 = " + roots[0]);
            Console.WriteLine("Root 2 = " + roots[1]);
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine("One real root:");
            Console.WriteLine("Root = " + roots[0]);
        }
        else
        {
            Console.WriteLine("No real roots (Delta is negative).");
        }
    }

    // Method to find roots of quadratic equation
    static double[] FindRoots(double a, double b, double c)
    {
        // delta = b^2 - 4ac
        double delta = Math.Pow(b, 2) - 4 * a * c;

        // If delta is positive → two roots
        if (delta > 0)
        {
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return new double[] { root1, root2 };
        }
        // If delta is zero → one root
        else if (delta == 0)
        {
            double root = -b / (2 * a);
            return new double[] { root };
        }
        // If delta is negative → no real roots
        else
        {
            return new double[0]; // empty array
        }
    }
}
