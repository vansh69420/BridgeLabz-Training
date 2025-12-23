using System;
class Table
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a Number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        // Array to store multiplication results for 6 to 9
        int[] multipicationResult = new int[4];

        int idx = 0;
        for (int i = 6; i <= 9; i++)
        {
            multipicationResult[idx] = num * i;
            idx++;
        }
        idx = 0;
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine(num + " * " + i + " = " + multipicationResult[idx]);
            idx++;
        }
    }
}