using System;
using System.Linq;

class EarlyExit
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int passes = 0;

        for (int i = 0; i < n; i++)
        {
            bool swapped = false;

            for (int j = 0; j < n - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;

                    swapped = true;
                }
            }

            passes++;

            if (!swapped)
            {
                break;
            }
        }

        Console.WriteLine(passes);
    }
}