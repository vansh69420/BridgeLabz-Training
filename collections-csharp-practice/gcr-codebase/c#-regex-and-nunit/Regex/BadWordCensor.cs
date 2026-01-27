using System;
using System.Text.RegularExpressions;

class BadWordCensor
{
    static void Main()
    {
        string text = "This is a damn bad example with some stupid words.";
        string pattern = @"\b(damn|stupid)\b";

        Console.WriteLine(Regex.Replace(text, pattern, "****", RegexOptions.IgnoreCase));
    }
}
