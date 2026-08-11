using System;
using System.Linq;

class ShiftCount
{
    static long inversions = 0;

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        MergeSort(arr, 0, n - 1);

        Console.WriteLine(inversions);
    }

    static void MergeSort(int[] arr, int left, int right)
    {
        if (left >= right)
        {
            return;
        }

        int mid = left + (right - left) / 2;

        MergeSort(arr, left, mid);

        MergeSort(arr, mid + 1, right);

        Merge(arr, left, mid, right);
    }

    static void Merge(int[] arr, int left, int mid, int right)
    {
        int leftSize = mid - left + 1;
        int rightSize = right - mid;

        int[] leftArr = new int[leftSize];
        int[] rightArr = new int[rightSize];

        for (int x = 0; x < leftSize; x++)
        {
            leftArr[x] = arr[left + x];
        }

        for (int x = 0; x < rightSize; x++)
        {
            rightArr[x] = arr[mid + 1 + x];
        }

        int i = 0;    
        int j = 0;    
        int k = left; 

        while (i < leftSize && j < rightSize)
        {
            if (leftArr[i] <= rightArr[j])
            {
                arr[k] = leftArr[i];
                i++;
            }
            else
            {
                inversions += (leftSize - i);

                arr[k] = rightArr[j];
                j++;
            }

            k++;
        }

        while (i < leftSize)
        {
            arr[k] = leftArr[i];
            i++;
            k++;
        }

        while (j < rightSize)
        {
            arr[k] = rightArr[j];
            j++;
            k++;
        }
    }
}