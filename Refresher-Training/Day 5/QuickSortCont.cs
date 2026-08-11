using System;
using System.Linq;

class QuickSortCount
{
    public static int quicksortComparisons(int[] arr)
    {
        return QuickSort(arr, 0, arr.Length - 1);
    }

    static int QuickSort(int[] arr, int low, int high)
    {
        if (low >= high)
        {
            return 0;
        }

        int comparisons = 0;

        int pivotIndex = Partition(arr, low, high, ref comparisons);

        comparisons += QuickSort(arr, low, pivotIndex - 1);
        comparisons += QuickSort(arr, pivotIndex + 1, high);

        return comparisons;
    }

    static int Partition(int[] arr, int low, int high, ref int comparisons)
    {
        int pivot = arr[high];
        int i = low;

        for (int j = low; j < high; j++)
        {
            comparisons++;

            if (arr[j] < pivot)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
            }
        }

        int tempPivot = arr[i];
        arr[i] = arr[high];
        arr[high] = tempPivot;

        return i;
    }

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int totalComparisons = quicksortComparisons(arr);

        Console.WriteLine(string.Join(" ", arr));
        Console.WriteLine("Comparisons: " + totalComparisons);
    }
}