using System;
class NullReference
{
    public static void Main(string[] args)
    {
        DemonstrateNullReference();
    }
    public static void DemonstrateNullReference()
    {
        try
        {
            string str = null;
            Console.WriteLine("Length of the string: " + str.Length);
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("Caught a NullReferenceException: " + ex.Message);
        }
    }
}