using System;
class Program
{
    static void Main()
    {
        Bird[] sanctuaryBirds =
        {
            new Eagle("Golden Eagle"),
            new Sparrow("House Sparrow"),
            new Duck("Mallard Duck"),
            new Penguin("Emperor Penguin"),
            new Seagull("Sea Gull")
        };

        System.Console.WriteLine("=== EcoWing Wildlife Sanctuary ===\n");
        BirdUtility.ProcessBirds(sanctuaryBirds);
    }
}