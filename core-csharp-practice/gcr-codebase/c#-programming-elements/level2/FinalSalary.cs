using System;
class FinalSalary
{
	public static void Main(string[] args)
	{
		// Input
		double salary = Convert.ToDouble(Console.ReadLine());

		double bonus = Convert.ToDouble(Console.ReadLine());

		//Calculating Final Salary
		double finalSalary = salary + bonus;

		Console.WriteLine($"The Salary is INR {salary} and bonus is INR {bonus}. Hence Total income is INR {finalSalary}");

	}
}