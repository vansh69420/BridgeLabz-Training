using System;

class Vehicle
{
    // Instance variables
    public string ownerName;
    public string vehicleType;

    // Class variable
    public static double registrationFee = 2500;

    // Constructor
    public Vehicle(string owner, string type)
    {
        ownerName = owner;
        vehicleType = type;
    }

    // Instance method
    public void DisplayVehicleDetails()
    {
        Console.WriteLine("Owner Name: " + ownerName);
        Console.WriteLine("Vehicle Type: " + vehicleType);
        Console.WriteLine("Registration Fee: ₹" + registrationFee);
    }

    // Class method
    public static void UpdateRegistrationFee(double newFee)
    {
        registrationFee = newFee;
    }
}

class Program
{
    static void Main()
    {
        Vehicle v1 = new Vehicle("Vansh", "Car");
        Vehicle v2 = new Vehicle("Amit", "Bike");

        Vehicle.UpdateRegistrationFee(3000);

        v1.DisplayVehicleDetails();
        Console.WriteLine();

        v2.DisplayVehicleDetails();
    }
}
