using System;
class DistributingChocolate
{
	public static void Main(string[] args)
	{
		// Input 
		int numOfChocolate = Convert.ToInt32(Console.ReadLine());
		int numOfChildren = Convert.ToInt32(Console.ReadLine());

		// Calculating how many chocolate each children gets and how much chocolate is remaining 
		int getChocolate = numOfChocolate / numOfChildren;
		int remainChocolate = numOfChocolate % numOfChildren;

		Console.WriteLine($"The number of chocolates each child gets is {getChocolate} and the number of remaining chocolates is {remainChocolate}");
	}
}