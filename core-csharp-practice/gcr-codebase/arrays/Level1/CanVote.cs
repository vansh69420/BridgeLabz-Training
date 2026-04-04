// 23rd Dec 2025

using System;
using System.Security.Cryptography;
class CanVote
{
    static void Main(string[] args)
    {
        int[] arr = new int[10];
        
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Enter Age :");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                Console.WriteLine("Invalid Age: " + arr[i]);
                continue;
            }
            if (arr[i] >= 18)
            {
                Console.WriteLine("Eligible to Vote: " + arr[i]);
            }
            else
            {
                Console.WriteLine("Not Eligible to Vote: " + arr[i]);
            }
        }
    }
}