using System;
class FindPositive
{
    public static void Main(string[] args)
    {
        int[] arr = new int[5];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Enter Number :");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] > 0)
            {
                if(arr[i] % 2 == 0)
                {
                    Console.WriteLine("Positive Even Number: " + arr[i]);
                }
                else
                {
                    Console.WriteLine("Positive Odd Number: " + arr[i]);
                }
            }else if(arr[i] < 0)
            {
                Console.WriteLine("Negative Number: " + arr[i]);
            }
            else
            {
                Console.WriteLine("Zero: " + arr[i]);
            }
        }
            if(arr[0] == arr[arr.Length - 1])
            {
                Console.WriteLine("Both First and Last Element is : " + arr[0]);
            }else if(arr[0] > arr[arr.Length - 1])
            {
                Console.WriteLine("Element " + arr[0] + " is Greater than Last Element " + arr[arr.Length - 1]);
            }
            else
            {
                Console.WriteLine("Element " + arr[0] + " is Less than Last Element " + arr[arr.Length - 1]);
            }
    }
}