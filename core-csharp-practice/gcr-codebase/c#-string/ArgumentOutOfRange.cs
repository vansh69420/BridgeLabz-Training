using System;
class ArgumentOutOfRange
{
    public static void Main(string[] args)
    {
        DemonstrateArgumentOutOfRange();
    }

    public static void DemonstrateArgumentOutOfRange()
    {
        try
        {
            string str = "Vansh";
            string substring = str.Substring(6, 2);
            Console.WriteLine("Substring: " + substring);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Message: " + ex.Message);
        }
    }
}