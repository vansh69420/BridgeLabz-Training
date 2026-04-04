using System;

class Vehicle
{
    public static double RegistrationFee = 2000;

    public readonly string RegistrationNumber;
    public string OwnerName;
    public string VehicleType;

    public Vehicle(string regNo, string owner, string type)
    {
        this.RegistrationNumber = regNo;
        this.OwnerName = owner;
        this.VehicleType = type;
    }

    public static void UpdateRegistrationFee(double fee)
    {
        RegistrationFee = fee;
    }

    public void Display(object obj)
    {
        if (obj is Vehicle)
        {
            Console.WriteLine($"{VehicleType} - {RegistrationNumber}, Owner: {OwnerName}");
        }
    }
}

class Program
{
    static void Main()
    {
        Vehicle v = new Vehicle("UP32AB1234", "Rahul", "Car");
        v.Display(v);
    }
}
