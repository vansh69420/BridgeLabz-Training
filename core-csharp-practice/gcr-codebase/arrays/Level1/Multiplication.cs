using System;
class Multiplication
{
    public static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[10];

        for (int i = 1; i <= 10; i++)
        {
            arr[i - 1] = num * i;
        }

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(num + " * " + i + " = " + arr[i - 1]);
        }
    }
}