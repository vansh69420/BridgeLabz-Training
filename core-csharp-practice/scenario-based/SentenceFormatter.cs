using System;

class SentenceFormatter
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1. Sentence Formatter");
        Console.WriteLine("2. Paragraph Analyzer");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                ParaFormatter();
                break;
            case 2:
                ParaAnalyzer();
                break;
            default:
                Console.WriteLine("Invalid Choice.");
                break;
        }
    }

    // ================= SCENARIO 1 =================

    public static void ParaFormatter()
    {
        Console.WriteLine("Enter the Paragraph: ");
        string sentence = Console.ReadLine() ?? "";

        if (IsEmpty(sentence))
        {
            Console.WriteLine("Enter valid sentence.");
            return;
        }

        string formatted = FormatSentence(sentence);
        Console.WriteLine("\nFormatted Sentence: ");
        Console.WriteLine(formatted);
    }

    public static bool IsEmpty(string sentence)
    {
        return sentence.Trim() == "";
    }

    public static string FormatSentence(string text)
    {
        text = text.Trim();
        string result = "";
        bool capitalNext = true;

        for (int i = 0; i < text.Length; i++)
        {
            char c = text[i];

            if (IsLetter(c))
            {
                result += capitalNext ? ToUpper(c) : ToLower(c);
                capitalNext = false;
            }
            else if (IsPunctuation(c))
            {
                result += c + " ";
                capitalNext = true;
            }
            else if (c == ' ')
            {
                if (result.Length > 0 && result[result.Length - 1] != ' ')
                    result += c;
            }
        }
        return result.Trim();
    }

    public static bool IsLetter(char c)
    {
        return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
    }

    public static bool IsPunctuation(char c)
    {
        return c == '.' || c == '?' || c == '!';
    }

    public static char ToUpper(char c)
    {
        return (c >= 'a' && c <= 'z') ? (char)(c - 32) : c;
    }

    public static char ToLower(char c)
    {
        return (c >= 'A' && c <= 'Z') ? (char)(c + 32) : c;
    }

    // ================= SCENARIO 2 =================

    public static void ParaAnalyzer()
    {
        Console.WriteLine("Enter the Paragraph: ");
        string input = Console.ReadLine() ?? "";

        if (IsEmpty(input))
        {
            Console.WriteLine("Invalid input");
            return;
        }

        Console.WriteLine("Enter the word to replace: ");
        string oldWord = Console.ReadLine() ?? "";

        Console.WriteLine("Enter the new Word: ");
        string newWord = Console.ReadLine() ?? "";

        string[] words = SplitWords(input);

        int count = CountWords(words);
        string longestWord = LongestWord(words);   
        string replaced = Replaced(words, oldWord, newWord);

        Console.WriteLine("\nWord Count : " + count);
        Console.WriteLine("Longest Word : " + longestWord);
        Console.WriteLine("Updated Paragraph: ");
        Console.WriteLine(replaced);
    }

    public static string[] SplitWords(string text)
    {
        return text.Trim().Split(' ');
    }

    public static int CountWords(string[] words)
    {
        int count = 0;
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] != "")
                count++;
        }
        return count;
    }

    public static string LongestWord(string[] words)
    {
        string longest = "";

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > longest.Length)
                longest = words[i];
        }
        return longest;
    }

    public static string Replaced(string[] words, string oldWord, string newWord)
    {
        string result = "";

        for (int i = 0; i < words.Length; i++)
        {
            if (ToLowerString(words[i]) == ToLowerString(oldWord))
                result += newWord + " ";
            else
                result += words[i] + " ";
        }
        return result.Trim();
    }

    public static string ToLowerString(string word)
    {
        string lower = "";
        for (int i = 0; i < word.Length; i++)
            lower += ToLower(word[i]);
        return lower;
    }
}
