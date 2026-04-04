using System;
class AreaOftriangle
{
	public static void Main(string[] args)
	{
		double baseInches = Convert.ToDouble(Console.ReadLine());

		double heightInches = Convert.ToDouble(Console.ReadLine());

		// Area in square inches
        double areaInches = 0.5 * baseInches * heightInches;

        // Convert area to square centimeters (1 inch = 2.54 cm)
        double areaCm = areaInches * Math.Pow(2.54, 2);

        Console.WriteLine(
            "The area of triangle is " + areaInches + " square inches and " + areaCm + " square centimeters"
        );

	}
}