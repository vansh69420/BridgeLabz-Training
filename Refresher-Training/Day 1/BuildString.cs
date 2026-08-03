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
     * Complete the 'buildString' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER a
     *  2. INTEGER b
     *  3. STRING s
     */

    public static int buildString(int a, int b, string s)
    {
        int n = s.Length;
        
        int[] dp = new int[n + 1];
        
        for(int i = 1; i <= n; i++)
        {
            dp[i] = int.MaxValue;
        }
        
        dp[0] = 0;
        
        for(int i = 0; i < n ; i++)
        {
            if(dp[i] == int.MaxValue)
            {
                continue;
            }
            
            dp[i + 1] = Math.Min(dp[i + 1], dp[i] + a);
            
            for(int j = 0; j < i; j++)
            {
                int len = 0;
                
                while(i + len < n && j + len < i && s[j + len] == s[i + len])
                {
                    len++;
                    
                    dp[i + len] = Math.Min(dp[i + len], dp[i] + b);
                }
            }
        }
        return dp[n];
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
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int a = Convert.ToInt32(firstMultipleInput[1]);

            int b = Convert.ToInt32(firstMultipleInput[2]);

            string s = Console.ReadLine();

            int result = Result.buildString(a, b, s);
            
            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
