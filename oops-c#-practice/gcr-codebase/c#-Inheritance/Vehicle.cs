using System;

class Vehicle
{
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Generic Vehicle");
    }
}

class Car : Vehicle
{
    public override void DisplayInfo()
    {
        Console.WriteLine("Car with 4 seats");
    }
}

class Truck : Vehicle
{
    public override void DisplayInfo()
    {
        Console.WriteLine("Truck with heavy payload");
    }
}

class Motorcycle : Vehicle
{
    public override void DisplayInfo()
    {
        Console.WriteLine("Motorcycle with 2 wheels");
    }
}

class Program
{
    static void Main()
    {
        Vehicle[] vehicles =
        {
            new Car(),
            new Truck(),
            new Motorcycle()
        };

        foreach (Vehicle v in vehicles)
        {
            v.DisplayInfo();
        }
    }
}
