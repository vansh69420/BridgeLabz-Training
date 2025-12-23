using System;
class OddEven
{
    public static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());

        if(num < 0)
        {
            Console.Error.WriteLine("Invalid grade.");
            Environment.Exit(0);
        }

        int[] even = new int[(num / 2) + 1];
        int[] odd = new int[(num / 2) + 1];
        int evenIdx = 0;
        int oddIdx = 0;

        for (int i = 0; i <= num; i++)
        {
            if(i % 2 == 0)
            {
                even[evenIdx] = i;
                evenIdx++;
            }
            else
            {
                odd[oddIdx] = i;
                oddIdx++;
            }
        }

        Console.WriteLine("Even Numbers:");
        for (int i = 0; i < evenIdx; i++)
        {
            Console.WriteLine(even[i]);
        }
        Console.WriteLine("Odd Numbers:");
        for (int i = 0; i < oddIdx; i++)
        {
            Console.WriteLine(odd[i]);
        }
    }
}