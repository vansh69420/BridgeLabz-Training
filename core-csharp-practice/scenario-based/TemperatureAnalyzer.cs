using System;
class TemperatureAnalyzer
{
    public static void Main(string[] args)
    {
        float[,] temperatures =
        {
            {30,31,32,33,34,35,36,37,38,39,40,41,42,41,40,39,38,37,36,35,34,33,32,31},
            {29,30,31,32,33,34,35,36,37,38,39,40,41,40,39,38,37,36,35,34,33,32,31,30},
            {28,29,30,31,32,33,34,35,36,37,38,39,40,39,38,37,36,35,34,33,32,31,30,29},
            {27,28,29,30,31,32,33,34,35,36,37,38,39,38,37,36,35,34,33,32,31,30,29,28},
            {26,27,28,29,30,31,32,33,34,35,36,37,38,37,36,35,34,33,32,31,30,29,28,27},
            {25,26,27,28,29,30,31,32,33,34,35,36,37,36,35,34,33,32,31,30,29,28,27,26},
            {24,25,26,27,28,29,30,31,32,33,34,35,36,35,34,33,32,31,30,29,28,27,26,25}
        };

        FindHotAndCold(temperatures);
        FindAverage(temperatures);
    }

    public static void FindHotAndCold(float[,] temps)
    {
        float hottest = temps[0, 0];
        float coldest = temps[0, 0];
        int hotDay = 0;
        int coldDay = 0;

        for(int i = 0; i < 7; i++)
        {
            for(int j = 0; j < 24; j++)
            {
                if(temps[i, j] > hottest)
                {
                    hottest = temps[i,j];
                    hotDay = i;
                }
                if(temps[i, j] < coldest)
                {
                    coldest = temps[i, j];
                    coldDay = i;
                }
            }
        }

        Console.WriteLine("Hottest Day: Day " + (hotDay + 1) + " with temperature " + hottest);
        Console.WriteLine("Coldest Day: Day " + (coldDay + 1) + " with temperature " + coldest);
    }

    public static void FindAverage(float[,] temps)
    {
        Console.WriteLine("\nAverage Temperature per Day: ");
        for(int i = 0; i < 7; i++)
        {
            float  sum = 0;
            for(int j = 0; j < 24; j++)
            {
                sum += temps[i, j];
            }
            float avg = sum / 24;
            Console.WriteLine($"Day {i + 1} : {avg}");

        }
    }
}