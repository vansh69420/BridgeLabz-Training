using System;

class Device
{
    public string DeviceId;
    public string Status;

    public virtual void DisplayStatus()
    {
        Console.WriteLine($"Device {DeviceId}: {Status}");
    }
}

class Thermostat : Device
{
    public int TemperatureSetting;

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine("Temperature: " + TemperatureSetting);
    }
}
