using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the word");
        string input = Console.ReadLine();

        try
        {
            string result = StringUtility.CleanseAndInvert(input);
            Console.WriteLine("The generated key is - " + result);
        }
        catch (InvalidInputException)
        {
            Console.WriteLine("Invalid Input");
        }
    }
}
