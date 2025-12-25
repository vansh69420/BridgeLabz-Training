using System;
class QuotientRemainder
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the dividend: ");
        int dividend = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the divisor: ");
        int divisor = Convert.ToInt32(Console.ReadLine());

        int[] result = CalculateQuotientRemainder(dividend, divisor);
        Console.WriteLine("Quotient: " + result[0]);
        Console.WriteLine("Remainder: " + result[1]);
    }
    static int[] CalculateQuotientRemainder(int dividend, int divisor)
    {
        int quotient = dividend / divisor;
        int remainder = dividend % divisor;
        int[] result = { quotient, remainder };
        return result;
        
    }
}