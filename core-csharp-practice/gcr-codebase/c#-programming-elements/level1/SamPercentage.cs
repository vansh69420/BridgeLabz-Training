using System;
class SamPercentage
{
	public static void Main(string[] args)
	{
		int mathsMarks = 94;
		int physicsMarks = 95;
		int chemistryMarks = 96;

		int totalMarks = mathsMarks + physicsMarks + chemistryMarks;

		double averagePercent = (totalMarks/300.0) * 100;

		Console.WriteLine("Sam’s average mark in PCM is " + averagePercent);
	}
}