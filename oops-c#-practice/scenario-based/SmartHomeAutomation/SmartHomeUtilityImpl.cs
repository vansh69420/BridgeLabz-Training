using System;

public class SmartHomeUtilityImpl : IControllable
{
    public void ControlAppliance(Appliance[] appliances, int choice, bool turnOn)
    {
        if (choice < 1 || choice > appliances.Length)
        {
            Console.WriteLine("Invalid appliance selection");
            return;
        }

        Appliance appliance = appliances[choice - 1];
        appliance.SetStatus(turnOn);

        switch (appliance.GetType())
        {
            case "Light":
                Console.WriteLine(turnOn
                    ? "Light turned ON with soft brightness"
                    : "Light turned OFF");
                break;

            case "Fan":
                Console.WriteLine(turnOn
                    ? "Fan started at medium speed"
                    : "Fan turned OFF");
                break;

            case "AC":
                Console.WriteLine(turnOn
                    ? "AC cooling room to 22°C"
                    : "AC turned OFF");
                break;

            default:
                Console.WriteLine("Unknown appliance");
                break;
        }
    }
}
