using System;
using System.Security.Cryptography.X509Certificates;
class Lowercase
{
    public static void Main(string[] args)
    {
        string str = "HELLO WORLD";
        string lowerstr = LowercaseString(str);
        string lowerstrUsingBuiltIn = str.ToLower();
        Console.WriteLine("Lowercase using custom method: " + lowerstr);
        Console.WriteLine("Lowercase using ToLower(): " + lowerstrUsingBuiltIn);
    }

    public static string LowercaseString(string s)
    {
        char[] chars = new char[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            if(s[i] >= 'A' && s[i] <= 'Z')
            {
                chars[i] = (char)(s[i] + ('a' - 'A'));
            }
            else
            {
                chars[i] = s[i];
            }
        }
        return new string(chars);
    }
}
