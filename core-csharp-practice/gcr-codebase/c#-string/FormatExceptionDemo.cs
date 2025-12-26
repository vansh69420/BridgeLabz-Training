using System;
class FormatExceptionDemo
{
    public static void Main(string[] args)
    {
        DemonstrateFormatException();
    }

    public static void DemonstrateFormatException()
    {
        try
        {
            string str = "Vansh";
            int num = int.Parse(str);
            Console.WriteLine("Parsed number: " + num);
        }
        catch(FormatException ex)
        {
            Console.WriteLine("Caught a FormatException: " + ex.Message);
        }
    }
}