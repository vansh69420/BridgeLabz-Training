using System;
class HeightConverter
{
	public static void Main(string[] args)
	{
		double heightCm = Convert.ToDouble(Console.ReadLine());

		double heightInches = heightCm / 2.54;

		int feet = (int)(heightInches / 12);
		// double roundFeet = Math.Round(feet,2);

		double inches = heightInches - (feet * 12);

		Console.WriteLine(
            "Your Height in cm is " + heightCm +
            " while in feet is " + feet +
            " and inches is " + inches
        );
	}
}