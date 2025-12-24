using System;
class MoveZero
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter size of an array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Enter element :", i + 1);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int[] result = new int[size];
        int idx = 0;
        for (int i = 0; i < size; i++)
        {
            if (arr[i] != 0)
            {
                result[idx] = arr[i];
                idx++;
            }
        }
        for (int i = 0; i < size; i++)
        {
            Console.Write(result[i] + " ");
        }
    }
}