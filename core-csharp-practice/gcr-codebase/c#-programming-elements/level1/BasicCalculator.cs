using System;
class BasicCalculator
{
	public static void Main(string[] args)
	{
		float number1 = Convert.ToSingle(Console.ReadLine());
		float number2 = Convert.ToSingle(Console.ReadLine());

		float addition = number1 + number2;
        float subtraction = number1 - number2;
        float multiplication = number1 * number2;
        float division = number1 / number2;

        Console.WriteLine(
            "The addition, subtraction, multiplication and division value of 2 numbers " +
            number1 + " and " + number2 + " is " +
            addition + ", " + subtraction + ", " +
            multiplication + ", and " + division
        );
	}
}