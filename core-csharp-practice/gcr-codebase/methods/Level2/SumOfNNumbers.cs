using System;
class SumOfNNumbers
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a positive number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        int SumUsingRecursion = CalculateSumRecursion(n);
        int SumUsingFormula = CalculateSumFormula(n);

        Console.WriteLine("Sum of first " + n + " natural numbers using recursion is: " + SumUsingRecursion);
        Console.WriteLine("Sum of first " + n + " natural numbers using formula is: " + SumUsingFormula);

        if(SumUsingRecursion == SumUsingFormula)
        {
            Console.WriteLine("Both methods give the same result.");
        }
        else
        {
            Console.WriteLine("There is a discrepancy between the two methods.");
        }
    }

    static int CalculateSumRecursion(int n)
    {
        if (n == 1)
            return 1;
        return n + CalculateSumRecursion(n - 1);
    }
    static int CalculateSumFormula(int n)
    {
        return n * (n + 1) / 2;
    }
}