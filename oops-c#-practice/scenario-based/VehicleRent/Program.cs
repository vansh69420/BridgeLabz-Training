using System;

class Program
{
    static void Main()
    {
        Bike[] bikes =
        {
            new Bike(101, "Yamaha"),
            new Bike(102, "Honda")
        };

        Car[] cars =
        {
            new Car(201, "Hyundai"),
            new Car(202, "Toyota")
        };

        Truck[] trucks =
        {
            new Truck(301, "Tata")
        };

        while (true)
        {
            Console.WriteLine("\n=== VEHICLE RENTAL SYSTEM ===");
            Console.WriteLine("1. Bike");
            Console.WriteLine("2. Car");
            Console.WriteLine("3. Truck");
            Console.WriteLine("4. Exit");
            Console.Write("Choose vehicle type: ");

            int type = int.Parse(Console.ReadLine());

            if (type == 4) break;

            if (type == 1)
                RentVehicle(bikes);
            else if (type == 2)
                RentVehicle(cars);
            else if (type == 3)
                RentVehicle(trucks);
            else
                Console.WriteLine("Invalid choice!");
        }
    }

    static void RentVehicle(Vehicle[] vehicles)
    {
        Console.WriteLine("\nAvailable Vehicles:");
        for (int i = 0; i < vehicles.Length; i++)
        {
            if (vehicles[i].IsAvailable)
            {
                Console.WriteLine(
                    $"ID: {vehicles[i].VehicleId}, Brand: {vehicles[i].Brand}, " +
                    $"Day: ₹{vehicles[i].RentPerDay}, Hour: ₹{vehicles[i].RentPerHour}"
                );
            }
        }

        Console.Write("\nEnter Vehicle ID to rent: ");
        int id = int.Parse(Console.ReadLine());

        Vehicle selected = null;

        for (int i = 0; i < vehicles.Length; i++)
        {
            if (vehicles[i].VehicleId == id && vehicles[i].IsAvailable)
            {
                selected = vehicles[i];
                break;
            }
        }

        if (selected == null)
        {
            Console.WriteLine("Vehicle not available!");
            return;
        }

        Console.WriteLine("1. Rent by Days");
        Console.WriteLine("2. Rent by Hours");
        Console.Write("Choose option: ");
        int option = int.Parse(Console.ReadLine());

        bool isHourly = option == 2;

        Console.Write($"Enter {(isHourly ? "hours" : "days")}: ");
        int duration = int.Parse(Console.ReadLine());

        decimal amount = selected.CalculateRent(duration, isHourly);
        selected.Rent();

        Bill.Print(selected, duration, isHourly, amount);
    }
}
