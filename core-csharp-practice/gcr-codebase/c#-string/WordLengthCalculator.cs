using System;

class WordLengthCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();

        string[,] result = SplitWordsAndLengths(input);

        Console.WriteLine("\nWord\tLength");
        Console.WriteLine("----------------");
        for (int i = 0; i < result.GetLength(0); i++)
        {
            Console.WriteLine(result[i, 0] + "\t" + result[i, 1]);
        }
    }

    // Method to split text into words WITHOUT using string.Split()
    public static string[,] SplitWordsAndLengths(string text)
    {
        // Step 1: Count number of words
        int wordCount = CountWords(text);

        string[,] wordsWithLength = new string[wordCount, 2];

        int index = 0;
        string currentWord = "";

        // Step 2: Extract words
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != ' ')
            {
                currentWord += text[i];
            }
            else if (currentWord != "")
            {
                wordsWithLength[index, 0] = currentWord;
                wordsWithLength[index, 1] = CalculateLength(currentWord).ToString();
                index++;
                currentWord = "";
            }
        }

        // Last word
        if (currentWord != "")
        {
            wordsWithLength[index, 0] = currentWord;
            wordsWithLength[index, 1] = CalculateLength(currentWord).ToString();
        }

        return wordsWithLength;
    }

    public static int CalculateLength(string word)
    {
        int count = 0;
        foreach (char c in word)
        {
            count++;
        }
        return count;
    }

    public static int CountWords(string text)
    {
        int count = 0;
        bool inWord = false;

        foreach (char c in text)
        {
            if (c != ' ' && !inWord)
            {
                count++;
                inWord = true;
            }
            else if (c == ' ')
            {
                inWord = false;
            }
        }
        return count;
    }
}
