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
     * Complete the 'separateNumbers' function below.
     *
     * The function accepts STRING s as parameter.
     */

    public static void separateNumbers(string s)
    {
        if(s.Length < 2 ||s[0] == '0')
        {
            Console.WriteLine("NO");
            return;
        }
        
        for(int len = 1; len <= s.Length / 2; len++)
        {
            string first = s.Substring(0, len); // 9
            long firstnum = long.Parse(first);
            
            int idx = 0;
            long curr = firstnum;
            
            while(idx < s.Length)
            {
                string currStr = curr.ToString();
                
                if(idx + currStr.Length > s.Length || s.Substring(idx, currStr.Length) != currStr)
                {
                    break;
                }
                
                idx += currStr.Length;
                curr++;
            }
            if(idx == s.Length)
            {
                Console.WriteLine("YES " + first);
                return;
            }
        }
        Console.WriteLine("NO");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            Result.separateNumbers(s);
        }
    }
}
