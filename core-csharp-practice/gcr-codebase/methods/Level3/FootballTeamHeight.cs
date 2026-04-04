using System;

class FootballTeamHeight
{
    static void Main(string[] args)
    {
        int[] heights = new int[11];
        Random random = new Random();

        // Generate random heights between 150 and 250 cm
        for (int i = 0; i < heights.Length; i++)
        {
            heights[i] = random.Next(150, 251);
        }

        Console.WriteLine("Heights of football players (in cm):");
        foreach (int h in heights)
        {
            Console.WriteLine(h);
        }

        int sum = FindSum(heights);
        double mean = FindMean(heights);
        int shortest = FindShortest(heights);
        int tallest = FindTallest(heights);

        Console.WriteLine("\nResults:");
        Console.WriteLine("Sum of heights = " + sum);
        Console.WriteLine("Mean height = " + mean);
        Console.WriteLine("Shortest height = " + shortest);
        Console.WriteLine("Tallest height = " + tallest);
    }

    // c. Method to find sum of heights
    static int FindSum(int[] heights)
    {
        int sum = 0;
        foreach (int h in heights)
        {
            sum += h;
        }
        return sum;
    }

    // d. Method to find mean height
    static double FindMean(int[] heights)
    {
        int sum = FindSum(heights);
        return (double)sum / heights.Length;
    }

    // e. Method to find shortest height
    static int FindShortest(int[] heights)
    {
        int min = heights[0];
        foreach (int h in heights)
        {
            min = Math.Min(min, h);
        }
        return min;
    }

    // f. Method to find tallest height
    static int FindTallest(int[] heights)
    {
        int max = heights[0];
        foreach (int h in heights)
        {
            max = Math.Max(max, h);
        }
        return max;
    }
}
