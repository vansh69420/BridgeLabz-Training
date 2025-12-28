using System;

class Factorial
{
    public static void Main(string[] args)
    {
        int number = GetInput();

        if (number < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
            return;
        }

        long result = FindFactorial(number);
        DisplayResult(number, result);
    }

    // Method to take input
    static int GetInput()
    {
        Console.Write("Enter a number: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    // Recursive method to calculate factorial
    static long FindFactorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;

        return n * FindFactorial(n - 1);
    }

    // Method to display result
    static void DisplayResult(int num, long factorial)
    {
        Console.WriteLine("Factorial of " + num + " is: " + factorial);
    }
}
