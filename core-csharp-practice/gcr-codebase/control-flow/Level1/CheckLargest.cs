using System;
class CheckLargest
{
	public static void Main(string[] args)
	{
		int num1 = Convert.ToInt32(Console.ReadLine());
		int num2 = Convert.ToInt32(Console.ReadLine());
		int num3 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine(
			"Is the first number the largest? " + (num1 > num2 && num1 > num3) + "\n" + 
			"Is the second number the largest? " + (num2 > num1 && num2 > num3) + "\n" + 
			"Is the third number the largest? " + (num3 > num1 && num3 > num2)
			);
	}
}