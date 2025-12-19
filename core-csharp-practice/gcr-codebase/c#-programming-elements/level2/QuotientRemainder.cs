using System;
class QuotientRemainder
{
	public static void Main(string[] args)
	{
		// Input
		int num1 = Convert.ToInt32(Console.ReadLine());
		int num2 = Convert.ToInt32(Console.ReadLine());

		// Calculating Quotient and Remainder
		int quotient = num1 / num2;
		int remainder = num1 % num2;

		Console.WriteLine($"The Quotient is {quotient} and Remainder is {remainder} of the two number {num1} and {num2}");


	}
}