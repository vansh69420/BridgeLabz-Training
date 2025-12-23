using System;
class MultiDimensional
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number of rows and columns: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        int cols = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[rows, cols];
        Console.WriteLine("Enter elements of the matrix: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        int[] arr = new int[rows * cols];
        int idx = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                arr[idx] = matrix[i, j];
                idx++;
            }
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}