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
    static int[,] prefix;
    static long[] fact;
    static long[] invFact;
    const long MOD = 1000000007;
    static int n;
    /*
     * Complete the 'initialize' function below.
     *
     * The function accepts STRING s as parameter.
     */

    public static void initialize(string s)
    {
        n = s.Length;
        
        prefix = new int[n + 1, 26];
        
        for(int i = 1; i <= n; i++)
        {
            
            
            for (int c = 0; c < 26; c++)
            {
                prefix[i, c] = prefix[i - 1, c];
            }
            
            prefix[i, s[i - 1] - 'a']++;
        }
        
        fact = new long[n + 1];
        invFact = new long[n + 1];
        
        fact[0] = 1;
        
        for (int i = 1; i <= n; i++)
        {
            fact[i] = (fact[i - 1] * i) % MOD;
        }
        
        long a = fact[n];
        long b = MOD - 2;
        long result = 1;
        a %= MOD;
        
        while (b > 0)
        {
            if((b & 1) == 1)
            {
                result = (result * a) % MOD;
            }
            
            a = (a * a) % MOD;
            b >>= 1;
        }
        
        invFact[n] = result;
        
        for(int i = n - 1; i >= 0; i--)
        {
            invFact[i] = (invFact[i + 1] * (i + 1)) % MOD;
        }

    }

    /*
     * Complete the 'answerQuery' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER l
     *  2. INTEGER r
     */

    public static int answerQuery(int l, int r)
    {
        int totalPairs = 0;
        int oddCount = 0;
        long ways = 1;
        
        for(int c = 0; c < 26; c++)
        {
            int count = prefix[r, c] - prefix[l - 1, c];
            
            int half = count / 2;
            
            totalPairs += half;
            
            ways = (ways * invFact[half]) % MOD;
            
            if(count % 2 == 1)
            {
                oddCount++;
            }
        }
        ways = (ways * fact[totalPairs]) % MOD;
            
        if(oddCount > 0)
        {
            ways = (ways * oddCount) % MOD;
        }
        
        return (int)ways;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        Result.initialize(s);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int l = Convert.ToInt32(firstMultipleInput[0]);

            int r = Convert.ToInt32(firstMultipleInput[1]);

            int result = Result.answerQuery(l, r);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
