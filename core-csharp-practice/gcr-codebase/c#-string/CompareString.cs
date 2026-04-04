using System;
class CompareString
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter first string: ");
        string str1 = Console.ReadLine();

        Console.WriteLine("Enter second string: ");
        string str2 = Console.ReadLine();

        bool charCompare = CompareStrings(str1, str2);
        bool builtIncResult = str1.Equals(str2);

        Console.WriteLine("Character-by-character comparison result: {0}", charCompare);
        Console.WriteLine("Built-in comparison result: {0}", builtIncResult);
    }

    public static bool CompareStrings(string s1, string s2)
    {
        if(s1.Length != s2.Length)
        {
            return false;
        }
        for (int i = 0; i < s1.Length; i++)
        {
            if(s1[i] != s2[i])
            {
                return false;
            }
        }
        return true;
    }
}