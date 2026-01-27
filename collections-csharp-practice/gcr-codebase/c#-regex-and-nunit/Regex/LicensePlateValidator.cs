using System;
using System.Text.RegularExpressions;

class LicensePlateValidator
{
    static void Main()
    {
        string plate = "AB1234";
        string pattern = @"^[A-Z]{2}\d{4}$";

        Console.WriteLine(Regex.IsMatch(plate, pattern)
            ? "Valid License Plate"
            : "Invalid License Plate");
    }
}
