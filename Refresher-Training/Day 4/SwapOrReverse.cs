using System;
using System.Collections.Generic;

class SwapOrReverse
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        int[] sorted = (int[])arr.Clone();
        Array.Sort(sorted);

        List<int> diff = new List<int>();

        for(int i = 0; i < n; i++)
        {
            if(arr[i] != sorted[i])
            {
                diff.Add(i);
            }
        }

        if(diff.Count == 0)
        {
            Console.WriteLine("neither");
            return;
        }

        if(diff.Count == 2)
        {
            Console.WriteLine($"swap {diff[0] + 1} {diff[1] + 1}");
            return;
        }

        int left = diff[0];
        int right = diff[diff.Count - 1];

        int[] temp = (int[])arr.Clone();
        Array.Reverse(temp, left, right - left + 1);

        bool isSortAfterReversed = true;

        for(int i = 0; i < n; i++)
        {
            if(temp[i] != sorted[i])
            {
                isSortAfterReversed = false;
                break;
            }
        }

        if (isSortAfterReversed)
        {
            Console.WriteLine($"reverse {left + 1} {right + 1}");
        }
        else
        {
            Console.WriteLine("neither");
        }
    }
}