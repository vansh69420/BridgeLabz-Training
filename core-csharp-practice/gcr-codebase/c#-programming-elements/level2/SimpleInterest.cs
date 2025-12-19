using System;
class SimpleInterest
{
	public static void Main(string[] args)

	{
		// Input
		double principal = Convert.ToDouble(Console.ReadLine());

		double rate = Convert.ToDouble(Console.ReadLine());

		double time = Convert.ToDouble(Console.ReadLine());

		// Calculating SI

		double si = (principal * rate * time) / 100;

		Console.WriteLine($"The Simple Interest is {si} for Principal {principal}, Rate of Interest {rate} and Time {time}");
	}
}