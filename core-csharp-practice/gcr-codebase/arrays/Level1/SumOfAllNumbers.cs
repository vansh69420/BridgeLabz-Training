using System;
class SumOfAllNumbers
{
    public static void Main(string[] args)
    {
        double[] arr = new double[10];
        double total = 0.0;

        int idx = 0;

        while (true)
        {
            Console.WriteLine("Enter a Number: ");
            double num = Convert.ToDouble(Console.ReadLine());

            if(num <= 0)
            {
                break;
            }
            if(idx == arr.Length)
            {
                Console.WriteLine("Array is Full. Cannot Accept More Numbers.");
                break;
            }

            arr[idx] = num;
            idx++;

        }
        for(int i = 0; i < idx; i++)
            {
                total += arr[i];
            }
            Console.WriteLine("Sum of all Numbers: " + total);
    }
}