using System;

class NumberAnalysis
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5];


        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nNumber Analysis:");
        for (int i = 0; i < numbers.Length; i++)
        {
            if (IsPositive(numbers[i]))
            {
                Console.Write(numbers[i] + " is Positive and ");

                if (IsEven(numbers[i]))
                    Console.WriteLine("Even");
                else
                    Console.WriteLine("Odd");
            }
            else
            {
                Console.WriteLine(numbers[i] + " is Negative");
            }
        }


        int result = Compare(numbers[0], numbers[numbers.Length - 1]);

        Console.WriteLine("\nComparison of first and last elements:");
        if (result == 1)
            Console.WriteLine("First element is greater than last element");
        else if (result == 0)
            Console.WriteLine("First element is equal to last element");
        else
            Console.WriteLine("First element is less than last element");
    }


    static bool IsPositive(int number)
    {
        return number >= 0;
    }


    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }


    static int Compare(int num1, int num2)
    {
        if (num1 > num2)
            return 1;
        else if (num1 == num2)
            return 0;
        else
            return -1;
    }
}
