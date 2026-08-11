using System;
using System.Linq;

class MinimumSwaps
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        bool[] visited = new bool[n];

        int swaps = 0;

        for (int i = 0; i < n; i++)
        {
            if (visited[i] || arr[i] == i + 1)
            {
                continue;
            }

            int cycleLength = 0;
            int j = i;

            while (!visited[j])
            {
                visited[j] = true;
                j = arr[j] - 1;
                cycleLength++;
            }

            swaps += cycleLength - 1;
        }

        Console.WriteLine(swaps);
    }
}