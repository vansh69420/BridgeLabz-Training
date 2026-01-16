using System;

public class TrafficUtilityImpl : ITrafficManager
{
    private UniversalLinkedList waitingQueue;
    private UniversalLinkedList roundabout;

    public TrafficUtilityImpl()
    {
        waitingQueue = new UniversalLinkedList();
        roundabout = new UniversalLinkedList();
    }

    public void AddVehicleToQueue()
    {
        Console.Write("Enter vehicle number: ");
        string num = Console.ReadLine();

        Vehicle v = new Vehicle();
        v.SetVehicleNumber(num);

        waitingQueue.AddLast(v);
        Console.WriteLine("Vehicle added to waiting queue.");
    }

    public void AllowVehicleIntoRoundabout()
    {
        if (waitingQueue.IsEmpty())
        {
            Console.WriteLine("No vehicles waiting.");
            return;
        }

        Vehicle v = (Vehicle)waitingQueue.RemoveFirst();
        roundabout.AddLast(v);

        Console.WriteLine("Vehicle entered roundabout: " + v.GetVehicleNumber());
    }

    public void ExitVehicleFromRoundabout()
    {
        if (roundabout.IsEmpty())
        {
            Console.WriteLine("Roundabout is empty.");
            return;
        }

        Vehicle v = (Vehicle)roundabout.RemoveFirst();
        Console.WriteLine("Vehicle exited roundabout: " + v.GetVehicleNumber());
    }

    public void PrintRoundabout()
    {
        UniversalLinkedList.Node temp = roundabout.GetHead();

        if (temp == null)
        {
            Console.WriteLine("Roundabout is empty.");
            return;
        }

        Console.Write("Roundabout State: ");

        while (temp != null)
        {
            Vehicle v = (Vehicle)temp.GetData();
            Console.Write(v.GetVehicleNumber() + " → ");
            temp = temp.GetNext();
        }

        Console.WriteLine("(end)");
    }
}
