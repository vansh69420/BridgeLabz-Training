using System;
using System.Linq;

class TotalCount
{
    public static int countMergeOperations(int[] arr)
    {
        int[] sorted = MergeSortCount(arr, out int count);

        for (int x = 0; x < arr.Length; x++)
        {
            arr[x] = sorted[x];
        }

        return count;
    }

    static int[] MergeSortCount(int[] arr, out int mergeCount)
    {
        if (arr.Length <= 1)
        {
            mergeCount = 0;
            return arr;
        }

        int mid = arr.Length / 2;

        int[] left = new int[mid];
        int[] right = new int[arr.Length - mid];

        for (int x = 0; x < mid; x++)
        {
            left[x] = arr[x];
        }

        for (int x = mid; x < arr.Length; x++)
        {
            right[x - mid] = arr[x];
        }

        left = MergeSortCount(left, out int leftCount);
        right = MergeSortCount(right, out int rightCount);

        int[] merged = Merge(left, right);

        mergeCount = leftCount + rightCount + 1;

        return merged;
    }

    static int[] Merge(int[] a, int[] b)
    {
        int[] result = new int[a.Length + b.Length];

        int i = 0;
        int j = 0;
        int k = 0;

        while (i < a.Length && j < b.Length)
        {
            if (a[i] <= b[j])
            {
                result[k] = a[i];
                i++;
            }
            else
            {
                result[k] = b[j];
                j++;
            }
            k++;
        }

        while (i < a.Length)
        {
            result[k] = a[i];
            i++;
            k++;
        }

        while (j < b.Length)
        {
            result[k] = b[j];
            j++;
            k++;
        }

        return result;
    }

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int totalMerges = countMergeOperations(arr);

        Console.WriteLine("[" + string.Join(", ", arr) + "]");
        Console.WriteLine("Merge operations: " + totalMerges);
    }
}