using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'icecreamParlor' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER m
     *  2. INTEGER_ARRAY arr
     */

    public static List<int> icecreamParlor(int m, List<int> arr)
    {
        int n = arr.Count;

        List<(int price, int originalIndex)> indexed = new List<(int, int)>();
        for (int i = 0; i < n; i++)
        {
            indexed.Add((arr[i], i + 1)); 
        }

        indexed.Sort((a, b) => a.price.CompareTo(b.price));

        for (int i = 0; i < n; i++)
        {
            int target = m - indexed[i].price;

            int foundIndex = BinarySearch(indexed, target, i);

            if (foundIndex != -1)
            {
                int idx1 = indexed[i].originalIndex;
                int idx2 = indexed[foundIndex].originalIndex;

                return new List<int>
                {
                    Math.Min(idx1, idx2),
                    Math.Max(idx1, idx2)
                };
            }
        }

        return new List<int>();
    }
    
    private static int BinarySearch(
        List<(int price, int originalIndex)> arr,
        int target,
        int excludeIndex)
    {
        int left = 0;
        int right = arr.Count - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid].price == target && mid != excludeIndex)
            {
                return mid; 
            }
            else if (arr[mid].price < target ||
                    (arr[mid].price == target && mid == excludeIndex && mid > excludeIndex))
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1; 
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int m = Convert.ToInt32(Console.ReadLine().Trim());

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> result = Result.icecreamParlor(m, arr);

            textWriter.WriteLine(String.Join(" ", result));
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
