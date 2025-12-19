using System;
class DoubleOperations
{
	public static void Main(string[] args)
	{
		//Input
		double a = Convert.ToDouble(Console.ReadLine());
		double b = Convert.ToDouble(Console.ReadLine());
		double c = Convert.ToDouble(Console.ReadLine());

		// Perform Operations
		double opt1 = a + b * c;
		double opt2 = a * b + c;
		double opt3 = c + a / b;
		double opt4 = a % b + c;

		Console.WriteLine($"The results of Double Operations are {opt1} , {opt2}, {opt3} and {opt4}");

	}
}