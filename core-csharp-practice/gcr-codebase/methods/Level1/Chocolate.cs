using System;
class Chocolate
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of chocolate: ");
        int chocolate = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the number of students: ");
        int students = Convert.ToInt32(Console.ReadLine());

        int[] result = CalculateQuotientRemainder(chocolate, students);
        Console.WriteLine("Number of Chocolate get: " + result[0]);
        Console.WriteLine("Number of chocolate remaining: " + result[1]);
    }
    static int[] CalculateQuotientRemainder(int dividend, int divisor)
    {
        int quotient = dividend / divisor;
        int remainder = dividend % divisor;
        int[] result = { quotient, remainder };
        return result;
        
    }
}