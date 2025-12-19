using System;
class TemperatureConverter
{
	public static void Main(string[] args)
	{
		// Input
		double celsiusTemp = Convert.ToDouble(Console.ReadLine());

		// Calculations Farh to Celsius
		double FarhTemp = (celsiusTemp * 9 / 5) + 32;

		Console.WriteLine($"The {celsiusTemp} Celsius is {FarhTemp} Farhenheit");
	}
}