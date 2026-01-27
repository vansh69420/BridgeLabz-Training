using System;
using System.Text.RegularExpressions;

class LinkExtractor
{
    static void Main()
    {
        string text = "Visit https://www.google.com and http://example.org";
        string pattern = @"https?://\S+";

        foreach (Match m in Regex.Matches(text, pattern))
            Console.WriteLine(m.Value);
    }
}
