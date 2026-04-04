using System;
using System.Text.RegularExpressions;

class UsernameValidator
{
    static void Main()
    {
        string username = "user_123";
        string pattern = @"^[A-Za-z][A-Za-z0-9_]{4,14}$";

        Console.WriteLine(Regex.IsMatch(username, pattern)
            ? "Valid Username"
            : "Invalid Username");
    }
}
