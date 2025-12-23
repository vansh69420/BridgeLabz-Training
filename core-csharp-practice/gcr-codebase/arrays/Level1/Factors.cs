using System;
class Factors
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a Number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int maxFactors = 10;
        int[] factors = new int[maxFactors];
        int idx = 0;


        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                if (idx == maxFactors)
                {
                    maxFactors = maxFactors * 2;
                    int[] temp = new int[maxFactors];
                    for (int j = 0; j < factors.Length; j++)
                    {
                        temp[j] = factors[j];
                    }

                    factors = temp;
                }

                factors[idx] = i;
                idx++;
                
            }
        }
        for (int i = 0; i < idx; i++)
        {
            Console.WriteLine(factors[i]);
        }
    }
}