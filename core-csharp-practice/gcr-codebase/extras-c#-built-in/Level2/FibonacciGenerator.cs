using System;

class FibonacciGenerator
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number of terms: ");
        int terms = Convert.ToInt32(Console.ReadLine());

        if (terms <= 0)
        {
            Console.WriteLine("Please enter a positive number.");
            return;
        }

        GenerateFibonacci(terms);
    }

    // Method to generate and print Fibonacci sequence
    static void GenerateFibonacci(int n)
    {
        int first = 0;
        int second = 1;

        Console.WriteLine("\nFibonacci Sequence:");

        for (int i = 1; i <= n; i++)
        {
            Console.Write(first + " ");

            int next = first + second;
            first = second;
            second = next;
        }
    }
}
 