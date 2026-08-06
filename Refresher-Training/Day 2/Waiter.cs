using System;
using System.Collections.Generic;
using System.Text;

class Solution
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split(' ');
        int n = int.Parse(firstLine[0]);  
        int q = int.Parse(firstLine[1]);  

        string[] numberStrings = Console.ReadLine().Split(' ');

        Stack<int> inputStack = new Stack<int>();
        for (int i = n - 1; i >= 0; i--)
        {
            inputStack.Push(int.Parse(numberStrings[i]));
        }

        List<int> primes = GetPrimes(q);


        StringBuilder sb = new StringBuilder();


        for (int i = 0; i < q; i++)
        {
            int prime = primes[i];

            Stack<int> A = new Stack<int>();
            Stack<int> B = new Stack<int>();

            while (inputStack.Count > 0)
            {
                int plate = inputStack.Pop();

                if (plate % prime == 0)
                    B.Push(plate);
                else
                    A.Push(plate);
            }


            while (B.Count > 0)
            {
                sb.AppendLine(B.Pop().ToString());
            }


            inputStack = A;
        }


        while (inputStack.Count > 0)
        {
            sb.AppendLine(inputStack.Pop().ToString());
        }

        Console.Write(sb);
    }

    static List<int> GetPrimes(int count)
    {
        List<int> primes = new List<int>();
        int num = 2;

        while (primes.Count < count)
        {
            if (IsPrime(num))
                primes.Add(num);
            num++;
        }

        return primes;
    }

    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;

        for (int i = 3; i * i <= n; i += 2)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }
}