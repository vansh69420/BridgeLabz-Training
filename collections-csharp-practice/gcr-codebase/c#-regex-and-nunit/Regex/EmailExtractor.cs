using System;
using System.Text.RegularExpressions;

class EmailExtractor
{
    static void Main()
    {
        string text = "Contact us at support@example.com and info@company.org";
        string pattern = @"\b[\w.-]+@[\w.-]+\.\w+\b";

        foreach (Match m in Regex.Matches(text, pattern))
            Console.WriteLine(m.Value);
    }
}
