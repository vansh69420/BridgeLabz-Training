using System;
using System.Text.RegularExpressions;

class LanguageExtractor
{
    static void Main()
    {
        string text = "I love Java, Python, JavaScript, and Go.";
        string pattern = @"\b(JavaScript|Java|Python|Go)\b";

        foreach (Match m in Regex.Matches(text, pattern))
            Console.WriteLine(m.Value);
    }
}
