using System;
using System.Text.RegularExpressions;

class CreditCardValidator
{
    static void Main()
    {
        string card = "4111111111111111";
        string pattern = @"^(4\d{15}|5\d{15})$";

        Console.WriteLine(Regex.IsMatch(card, pattern)
            ? "Valid Credit Card"
            : "Invalid Credit Card");
    }
}
