using System;
class VolumeCylinder
{
    public static void Main(string[] args)
    {
        double radius = 5.0;
        double height = 10.0;
        double volume = Math.PI * radius * radius * height;
        Console.WriteLine("Volume of the cylinder: " + volume);
    }
}