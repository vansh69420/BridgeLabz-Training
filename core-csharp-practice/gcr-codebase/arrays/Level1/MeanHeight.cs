using System;
class MeanHeight
{
    public static void Main(string[] args)
    {
        double[] heights = new double[11];
        double total = 0.0;

        for (int i = 0; i < heights.Length; i++)
        {
            Console.WriteLine("Enter Height in cm: ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }
        for (int i = 0; i < heights.Length; i++)
        {
            total += heights[i];
        }
        double mean = total / heights.Length;
        Console.WriteLine("Mean Height: " + mean + " cm");
    }
}