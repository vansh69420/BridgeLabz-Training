using System;
class AnagramsString
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the first string: ");
        string str1 = Console.ReadLine();

        Console.WriteLine("Enter the second string: ");
        string str2 = Console.ReadLine();

        bool areAnagrams = AreAnagrams(str1, str2);
        if (areAnagrams)
        {
            Console.WriteLine("The strings are anagrams.");
        }
        else
        {
            Console.WriteLine("The strings are not anagrams.");
        }
    }

    public static bool AreAnagrams(string str1, string str2)
    {
        str1 = str1.Replace(" ", "").ToLower();
        str2 = str2.Replace(" ", "").ToLower();

        if (str1.Length != str2.Length)
        {
            return false;
        }

        char[] charArray1 = str1.ToCharArray();
        char[] charArray2 = str2.ToCharArray();

        Array.Sort(charArray1);
        Array.Sort(charArray2);

        for (int i = 0; i < charArray1.Length; i++)
        {
            if (charArray1[i] != charArray2[i])
            {
                return false;
            }
        }
        return true;
    }
}