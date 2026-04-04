using System;
class IndexOutOfRange
{
    public static void Main(string[] args)
    {
        DemonstrateIndexOutOfRange();
    }
    public static void DemonstrateIndexOutOfRange()
    {
        try
        {
            string str = "Vansh";
            char ch = str[10];
            Console.WriteLine("Character at index 10: " + ch);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Caught an IndexOutOfRangeException: " + ex.Message);
        }
    }
}