using System;
using System.Linq;

class PartitionAroundPivot
{
    public static int partitionArray(int[] arr)
    {
        int pivot = arr[arr.Length - 1];
        int i = 0;

        for (int j = 0; j < arr.Length - 1; j++)
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
        arr[i] = arr[arr.Length - 1];
        arr[arr.Length - 1] = tempPivot;

        return i;
    }

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int pivotIndex = partitionArray(arr);

        Console.WriteLine(string.Join(" ", arr));
        Console.WriteLine(pivotIndex);
    }
}