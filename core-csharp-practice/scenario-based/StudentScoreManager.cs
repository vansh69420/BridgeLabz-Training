using System;
class StudentScoreManager
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of students");
        int students = Convert.ToInt32(Console.ReadLine());

        int[] scores = new int[students];

        ReadScores(scores);

        double avg = StudentAverage(scores);
        int highest = HighestScore(scores);
        int lowest = LowestScore(scores);

        Console.WriteLine("Average Score of Students : " + avg);
        Console.WriteLine("Highest Score: " + highest);
        Console.WriteLine("Lowest Score: " + lowest);

        DisplayAboveAvg(avg, scores);
    }

    static void ReadScores(int[] scores)
    {
        for(int i = 0; i < scores.Length; i++)
        {
            Console.WriteLine("Enter score for student " + (i+1) + ": ");
            int score = Convert.ToInt32(Console.ReadLine());

            if(score < 0)
            {
                Console.WriteLine("Invalid Input");
                i--;
            }
            else
            {
                scores[i] = score;
            }

        }
    }

    static double StudentAverage(int[] scores)
    {
        int sum = 0;
        for(int i = 0; i < scores.Length; i++)
        {
            sum += scores[i];
        }

        double avg = (double)sum / scores.Length;
        return avg;
    }

    static int HighestScore(int[] scores)
    {
        int highest = scores[0];

        for(int i = 0; i < scores.Length; i++)
        {
            if(scores[i] > highest)
            {
                highest = scores[i];
            }
        }
        return highest;
    }

    static int LowestScore(int[] scores)
    {
        int lowest = scores[0];
        for(int i = 0; i < scores.Length; i++)
        {
            if(scores[i] < lowest)
            {
                lowest = scores[i];
            }
        }
        return lowest;
    }

    static void DisplayAboveAvg(double avg, int[] scores)
    {
        Console.WriteLine("Scores above average : ");
        for(int i = 0; i < scores.Length; i++)
        {
            if(scores[i] > avg)
            {
                Console.WriteLine(scores[i]);
            }
        }
    }
}