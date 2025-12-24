using System;
class Frequency
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number : ");
        int n = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for (int i = 0; i <= n; i++)
        {
            count++;
        }
        int[] digits = new int[count];
        int idx = 0;
        while (n > 0)
        {
            digits[idx] = n % 10;
            n = n / 10;
            idx++;
        }
        int[] freq = new int[10];
        for (int i = 0; i < idx; i++)
        {
            freq[digits[i]]++;
        }
        for (int i = 0; i < 10; i++)
        {
            if (freq[i] > 0)
            {
                Console.WriteLine("Frequency of " + i + " is: " + freq[i]);
            }
        }
    }
}