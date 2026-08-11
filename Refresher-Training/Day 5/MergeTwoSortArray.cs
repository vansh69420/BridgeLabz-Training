using System;
using System.Linq;

class Solution
{
    public static int[] mergeSortedArrays(int[] a, int[] b)
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
        int[] a = n == 0
            ? new int[0]
            : Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

        int m = int.Parse(Console.ReadLine());
        int[] b = m == 0
            ? new int[0]
            : Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

        int[] merged = mergeSortedArrays(a, b);

        Console.WriteLine("[" + string.Join(", ", merged) + "]");
    }
}