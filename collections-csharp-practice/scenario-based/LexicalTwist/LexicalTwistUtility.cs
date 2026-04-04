using System;
using System.Text;
public class LexicalTwistUtility
{
    public static void ValidateWord(string word)
    {
        if (string.IsNullOrWhiteSpace(word))
        {
            throw new InvalidWordException("Input cannot be empty");
        }
        if(word.Contains(" "))
        {
            throw new InvalidWordException(word + "is a invalid word");
        }
        foreach(char c in word)
        {
            if (!char.IsLetter(c))
            {
                throw new InvalidWordException("Word should be only alphabet");
            }
        }
    }
    public void ProcessWords(string first, string second)
    {
        string reversed = Reverse(first);
        if(string.Equals(reversed, second, StringComparison.OrdinalIgnoreCase))
        {
            string result = ReplaceVowelsWithAt(reversed.ToLower());
            Console.WriteLine(result);
        }
        else
        {
            string combined = (first + second).ToUpper();
            AnalyzeAndPrint(combined);
        }
    }
    private string Reverse(string input)
    {
        char[] arr = input.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
    private string ReplaceVowelsWithAt(string input)
    {
        StringBuilder sb = new StringBuilder();

        foreach (char c in input)
        {
            sb.Append("aeiou".Contains(c) ? '@' : c);
        }
        return sb.ToString();
    }
    private void AnalyzeAndPrint(string word)
    {
        int vowels = 0, consonants = 0;

        foreach (char c in word)
        {
            if (IsVowel(c))
                vowels++;
            else if (char.IsLetter(c))
                consonants++;
        }

        if (vowels > consonants)
            PrintFirstTwo(word, true);
        else if (consonants > vowels)
            PrintFirstTwo(word, false);
        else
            Console.WriteLine("Vowels and consonants are equal");
    }
    private void PrintFirstTwo(string word, bool vowelMode)
    {
        StringBuilder sb = new StringBuilder();

        foreach (char c in word)
        {
            if (vowelMode && IsVowel(c) && !sb.ToString().Contains(c))
                sb.Append(c);

            if (!vowelMode && !IsVowel(c) && char.IsLetter(c) && !sb.ToString().Contains(c))
                sb.Append(c);

            if (sb.Length == 2)
                break;
        }

        Console.WriteLine(sb.ToString());
    }
    private bool IsVowel(char c)
    {
        return "AEIOU".Contains(c);
    }
}