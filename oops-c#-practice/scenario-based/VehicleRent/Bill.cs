using System;
public class Bill
{
    public static void Print(Vehicle v, int duration, bool isHourly, decimal amount)
    {
        Console.WriteLine("\n=========== BILL ===========");
        Console.WriteLine($"Vehicle ID : {v.VehicleId}");
        Console.WriteLine($"Brand      : {v.Brand}");
        Console.WriteLine($"Rent Type  : {(isHourly ? "Hourly" : "Daily")}");
        Console.WriteLine($"Duration   : {duration}");
        Console.WriteLine($"Total Cost : ₹{amount}");
        Console.WriteLine("============================\n");
    }
}
