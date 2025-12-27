using System;
class LongestWord
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string: ");
        string str = Console.ReadLine();

        string longestWord = FindLongestWord(str);
        Console.WriteLine("Longest word: " + longestWord);
    }

    public static string FindLongestWord(string str)
    {
        string[] words = str.Split(' ');
        string longest = "";

        foreach (string word in words)
        {
            if (word.Length > longest.Length)
            {
                longest = word;
            }
        }
        return longest;
    }
}