using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static Dictionary<int, int> memo = new Dictionary<int, int>();
    
    public static int Fibonacci(int n) {


        if (n == 0) return 0;
        if (n == 1) return 1;

        if (memo.ContainsKey(n))
        {
            return memo[n];
        }

        int result = Fibonacci(n - 1) + Fibonacci(n - 2);
        memo[n] = result;

        return result;

    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Fibonacci(n));
    }
}
