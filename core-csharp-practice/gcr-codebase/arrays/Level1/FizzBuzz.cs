using System;
class FizzBuzz
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a Number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        string[] fizzBuzzArr = new string[num + 1];

        for (int i = 1; i <= num; i++)
        {
            if(i == 0)
            {
                fizzBuzzArr[0] = "0";
            }
            else if(i % 3 == 0 && i % 5 == 0)
            {
                fizzBuzzArr[i] = "FizzBuzz";
            }else if(i % 3 == 0)
            {
                fizzBuzzArr[i] = "Fizz";
            }else if(i % 5 == 0)
            {
                fizzBuzzArr[i] = "Buzz";
            }
            else
            {
                fizzBuzzArr[i] = i.ToString();
            }
        }
        for (int i = 1; i < fizzBuzzArr.Length; i++)
        {
            Console.WriteLine(fizzBuzzArr[i]);
        }
    }
}