using System;
using System.Collections.Generic;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class CacheResultAttribute : Attribute { }

class Calculator
{
    Dictionary<int, int> cache = new Dictionary<int, int>();

    [CacheResult]
    public int Square(int n)
    {
        if (cache.ContainsKey(n))
        {
            Console.WriteLine("From Cache");
            return cache[n];
        }

        Console.WriteLine("Computing...");
        int result = n * n;
        cache[n] = result;
        return result;
    }
}

class CacheResult
{
    static void Main()
    {
        Calculator c = new Calculator();
        Console.WriteLine(c.Square(4));
        Console.WriteLine(c.Square(4));
    }
}
