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
     * Complete the 'matchingStrings' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. STRING_ARRAY stringList
     *  2. STRING_ARRAY queries
     */

    public static List<int> matchingStrings(List<string> stringList, List<string> queries)
    {
        stringList.Sort(StringComparer.Ordinal);

        List<int> results = new List<int>();

        foreach (string query in queries)
        {
            int firstIndex = FindFirst(stringList, query);

            if (firstIndex == -1)
            {
                results.Add(0);
            }
            else
            {
                int lastIndex = FindLast(stringList, query);
                results.Add(lastIndex - firstIndex + 1);
            }
        }

        return results;
    }
    
    private static int FindFirst(List<string> arr, string target)
    {
        int left = 0;
        int right = arr.Count - 1;
        int result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int comparison = string.Compare(arr[mid], target, StringComparison.Ordinal);

            if (comparison == 0)
            {
                result = mid;      
                right = mid - 1;   
            }
            else if (comparison < 0)
            {
                left = mid + 1;  
            }
            else
            {
                right = mid - 1;  
            }
        }

        return result;
    }
    
    private static int FindLast(List<string> arr, string target)
    {
        int left = 0;
        int right = arr.Count - 1;
        int result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int comparison = string.Compare(arr[mid], target, StringComparison.Ordinal);

            if (comparison == 0)
            {
                result = mid;     
                left = mid + 1;    
            }
            else if (comparison < 0)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;   
            }
        }

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int stringListCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> stringList = new List<string>();

        for (int i = 0; i < stringListCount; i++)
        {
            string stringListItem = Console.ReadLine();
            stringList.Add(stringListItem);
        }

        int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> queries = new List<string>();

        for (int i = 0; i < queriesCount; i++)
        {
            string queriesItem = Console.ReadLine();
            queries.Add(queriesItem);
        }

        List<int> res = Result.matchingStrings(stringList, queries);

        textWriter.WriteLine(String.Join("\n", res));

        textWriter.Flush();
        textWriter.Close();
    }
}
