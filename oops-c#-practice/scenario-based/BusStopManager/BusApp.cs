using System;
class BussApp
{
    public static void Main(string[] args)
    {
        BusRoute route = new BusRoute();

        Console.WriteLine("🚌 Welcome to Bus Route Tracker");
        Console.WriteLine("Role:");
        Console.WriteLine("1. Driver");
        Console.WriteLine("2. Passenger");

        int role = Convert.ToInt32(Console.ReadLine());

        if(role == 1)
        {
            DriverMode(route);
        }else if(role == 2)
        {
            PassengerMode(route);
        }
        else
        {
            Console.WriteLine("Invalid Output");
        }
    }

    static void DriverMode(BusRoute route)
    {
        Console.WriteLine("Driver Started the Journey");
        PassengerJourney(route);
    }

    static void PassengerMode(BusRoute route)
    {
        Console.WriteLine("\nPassenger on board...");
        PassengerJourney(route);
    }

    static void PassengerJourney(BusRoute route)
    {
        char choice = "";
        while(choice != "yes")
        {
            route.AddStopDistance();

            Console.WriteLine("\nBus reached next stop");
            Console.WriteLine("Distance traveled: " + route.GetTotalDistance() + " km");

            Console.Write("Do you want to get off? (yes/no): ");
            choice = Console.ReadLine().ToLower();

        }

        Console.WriteLine("\nPassenger got off.");
        Console.WriteLine("Total Distance Traveled: " + route.GetTotalDistance() + " km");
    }
}