using System;
class IndexOutOfRangeArrays
{
    public static void Main(string[] args)
    {
        DemonstrateIndexOutOfRangeArrays();
    }

    public static void DemonstrateIndexOutOfRangeArrays()
    {
        try
        {
            string[] arr = { "Vansh", "is", "learning", "C#" };
            Console.WriteLine("Accessing element at index 5: " + arr[5]);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Caught an IndexOutOfRangeException: " + ex.Message);
        }
    }
}