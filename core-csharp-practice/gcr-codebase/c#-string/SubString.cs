using System;
class SubString
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string: ");
        string str = Console.ReadLine();

        Console.WriteLine("Enter starting index for substring: ");
        int startIndex = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter end index: ");
        int end = Convert.ToInt32(Console.ReadLine());

        string substringUsingCharAt = SubstringUsingCharAt(str, startIndex, end);
        string subString = str.Substring(startIndex, end);
        Console.WriteLine("Substring using character access: {0}", substringUsingCharAt);
        Console.WriteLine("Substring using built-in method: {0}", subString);

    }

    public static string SubstringUsingCharAt(string str, int startIndex, int end)
    {
        string result = "";
        for(int i = startIndex; i < startIndex + end && i < str.Length; i++)
        {
            result += str[i];
        }
        return result;
    }
}