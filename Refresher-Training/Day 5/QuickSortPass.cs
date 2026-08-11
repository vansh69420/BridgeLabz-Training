using System;
using System.Linq;

class QuickSortPass
{
    public static string isSortedAfterOnePass(int[] arr)
    {
        int n = arr.Length;

        int pivot = arr[n - 1];
        int i = 0;

        for (int j = 0; j < n - 1; j++)
        {
            if (arr[j] < pivot)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
            }
        }

        int tempPivot = arr[i];
        arr[i] = arr[n - 1];
        arr[n - 1] = tempPivot;

        for (int k = 0; k < n - 1; k++)
        {
            if (arr[k] > arr[k + 1])
            {
                return "NO";
            }
        }

        return "YES";
    }

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        string result = isSortedAfterOnePass(arr);

        Console.WriteLine(string.Join(" ", arr));
        Console.WriteLine(result);
    }
}