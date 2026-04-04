using System;

class TripDetails
{
    static void Main()
    {
        // String Inputs
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter From City: ");
        string fromCity = Console.ReadLine();

        Console.Write("Enter Via City: ");
        string viaCity = Console.ReadLine();

        Console.Write("Enter To City: ");
        string toCity = Console.ReadLine();

        // Distance Inputs
        Console.Write("Enter distance from FromCity to ViaCity (miles): ");
        double fromToVia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter distance from ViaCity to ToCity (miles): ");
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        // Time Input
        Console.Write("Enter time taken (hours): ");
        double timeTaken = Convert.ToDouble(Console.ReadLine());

        // Calculations
        double totalDistance = fromToVia + viaToFinalCity;

        // Correct calculation
        double avgSpeed = totalDistance / timeTaken;

        // Precedence example (WRONG logically but useful for learning)
        double precedenceResult = fromToVia + viaToFinalCity / timeTaken;

        // Output
        Console.WriteLine(
            "The results of the trip are: " +
            "Total Distance = " + totalDistance +
            " miles, Average Speed = " + avgSpeed +
            " mph, Precedence Result = " + precedenceResult
        );
    }
}
