using System;
class IntOperations
{
	public static void Main(string[] args)
	{
		// Input
		int a = Convert.ToInt32(Console.ReadLine());
		int b = Convert.ToInt32(Console.ReadLine());
		int c = Convert.ToInt32(Console.ReadLine());

		//Perform Operations
		int opt1 = a + b * c;
		int opt2 = a * b + c;
		int opt3 = c + a / b;
		int opt4 = a % b + c;

		Console.WriteLine($"The results of Int Operations are {opt1} , {opt2}, {opt3} and {opt4}");

	}
}