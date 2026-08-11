using System;
using System.Linq;

class InsertionSortNearlySorted
{
    public static void Main()
    {
        string[] firstLine = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);

        int n = int.Parse(firstLine[0]);
        int k = int.Parse(firstLine[1]);

        int[] arr = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int comparisons = 0;

        for (int i = 1; i < n; i++)
        {
            int value = arr[i];
            int j = i - 1;

            while (j >= 0)
            {
                comparisons++;

                if (arr[j] > value)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                else
                {
                    break;
                }
            }

            arr[j + 1] = value;
        }

        Console.WriteLine(string.Join(" ", arr));
        Console.WriteLine("Comparisons: " + comparisons);
    }
}