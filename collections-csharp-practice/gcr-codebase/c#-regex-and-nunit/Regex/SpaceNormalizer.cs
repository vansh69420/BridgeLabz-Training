using System;
using System.Text.RegularExpressions;

class SpaceNormalizer
{
    static void Main()
    {
        string input = "This   is   an   example.";
        string output = Regex.Replace(input, @"\s+", " ");

        Console.WriteLine(output);
    }
}
