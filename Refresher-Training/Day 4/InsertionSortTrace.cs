using System;
using System.Linq;

class InsertionSortTrace
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        for (int i = 1; i < n; i++)
        {
            int value = arr[i];

            int j = i - 1;

            while (j >= 0 && arr[j] > value)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = value;

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}