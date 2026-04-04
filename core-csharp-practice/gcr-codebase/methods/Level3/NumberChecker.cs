using System;

class NumberChecker
{
    /* ======================= DIGIT UTILITIES ======================= */

    public static int CountDigits(int number)
    {
        number = Math.Abs(number);
        if (number == 0) return 1;

        int count = 0;
        while (number > 0)
        {
            count++;
            number /= 10;
        }
        return count;
    }

    public static int[] StoreDigits(int number)
    {
        int count = CountDigits(number);
        int[] digits = new int[count];
        number = Math.Abs(number);

        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    public static int SumOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int d in digits) sum += d;
        return sum;
    }

    public static double SumOfSquaresOfDigits(int[] digits)
    {
        double sum = 0;
        foreach (int d in digits) sum += Math.Pow(d, 2);
        return sum;
    }

    /* ======================= DUCK / ARMSTRONG / HARSHAD ======================= */

    public static bool IsDuckNumber(int[] digits)
    {
        foreach (int d in digits)
        {
            if (d == 0) return true;
        }
        return false;
    }

    public static bool IsArmstrong(int number, int[] digits)
    {
        int power = digits.Length;
        int sum = 0;

        foreach (int d in digits)
        {
            sum += (int)Math.Pow(d, power);
        }
        return sum == number;
    }

    public static bool IsHarshad(int number, int[] digits)
    {
        int sum = SumOfDigits(digits);
        return sum != 0 && number % sum == 0;
    }

    /* ======================= LARGEST / SMALLEST ======================= */

    public static void FindLargestSecondLargest(int[] digits, out int largest, out int secondLargest)
    {
        largest = Int32.MinValue;
        secondLargest = Int32.MinValue;

        foreach (int d in digits)
        {
            if (d > largest)
            {
                secondLargest = largest;
                largest = d;
            }
            else if (d > secondLargest && d != largest)
            {
                secondLargest = d;
            }
        }
    }

    public static void FindSmallestSecondSmallest(int[] digits, out int smallest, out int secondSmallest)
    {
        smallest = Int32.MaxValue;
        secondSmallest = Int32.MaxValue;

        foreach (int d in digits)
        {
            if (d < smallest)
            {
                secondSmallest = smallest;
                smallest = d;
            }
            else if (d < secondSmallest && d != smallest)
            {
                secondSmallest = d;
            }
        }
    }

    /* ======================= PALINDROME ======================= */

    public static int[] ReverseArray(int[] arr)
    {
        int[] rev = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            rev[i] = arr[arr.Length - 1 - i];
        }
        return rev;
    }

    public static bool AreArraysEqual(int[] a, int[] b)
    {
        if (a.Length != b.Length) return false;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i]) return false;
        }
        return true;
    }

    public static bool IsPalindrome(int[] digits)
    {
        int[] reversed = ReverseArray(digits);
        return AreArraysEqual(digits, reversed);
    }

    /* ======================= PRIME / SPECIAL NUMBERS ======================= */

    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    public static bool IsNeon(int number)
    {
        int square = number * number;
        int sum = SumOfDigits(StoreDigits(square));
        return sum == number;
    }

    public static bool IsSpy(int[] digits)
    {
        int sum = 0, product = 1;
        foreach (int d in digits)
        {
            sum += d;
            product *= d;
        }
        return sum == product;
    }

    public static bool IsAutomorphic(int number)
    {
        int square = number * number;
        return square.ToString().EndsWith(number.ToString());
    }

    public static bool IsBuzz(int number)
    {
        return number % 7 == 0 || number % 10 == 7;
    }

    /* ======================= FACTORS ======================= */

    public static int[] FindFactors(int number)
    {
        int count = 0;
        for (int i = 1; i <= number; i++)
            if (number % i == 0) count++;

        int[] factors = new int[count];
        int index = 0;

        for (int i = 1; i <= number; i++)
            if (number % i == 0) factors[index++] = i;

        return factors;
    }

    public static int GreatestFactor(int[] factors)
    {
        int max = Int32.MinValue;
        foreach (int f in factors)
            if (f > max) max = f;
        return max;
    }

    public static int SumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int f in factors) sum += f;
        return sum;
    }

    public static long ProductOfFactors(int[] factors)
    {
        long product = 1;
        foreach (int f in factors) product *= f;
        return product;
    }

    public static double ProductOfCubeOfFactors(int[] factors)
    {
        double product = 1;
        foreach (int f in factors)
            product *= Math.Pow(f, 3);
        return product;
    }

    public static bool IsPerfect(int number, int[] factors)
    {
        int sum = 0;
        foreach (int f in factors)
            if (f != number) sum += f;
        return sum == number;
    }

    public static bool IsAbundant(int number, int[] factors)
    {
        int sum = 0;
        foreach (int f in factors)
            if (f != number) sum += f;
        return sum > number;
    }

    public static bool IsDeficient(int number, int[] factors)
    {
        int sum = 0;
        foreach (int f in factors)
            if (f != number) sum += f;
        return sum < number;
    }

    public static bool IsStrong(int number)
    {
        int[] digits = StoreDigits(number);
        int sum = 0;

        foreach (int d in digits)
        {
            int fact = 1;
            for (int i = 1; i <= d; i++) fact *= i;
            sum += fact;
        }
        return sum == number;
    }

    /* ======================= MAIN ======================= */

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] digits = StoreDigits(number);
        int[] factors = FindFactors(number);

        Console.WriteLine("Digit Count: " + CountDigits(number));
        Console.WriteLine("Duck Number: " + IsDuckNumber(digits));
        Console.WriteLine("Armstrong Number: " + IsArmstrong(number, digits));
        Console.WriteLine("Harshad Number: " + IsHarshad(number, digits));
        Console.WriteLine("Palindrome Number: " + IsPalindrome(digits));
        Console.WriteLine("Prime Number: " + IsPrime(number));
        Console.WriteLine("Neon Number: " + IsNeon(number));
        Console.WriteLine("Spy Number: " + IsSpy(digits));
        Console.WriteLine("Automorphic Number: " + IsAutomorphic(number));
        Console.WriteLine("Buzz Number: " + IsBuzz(number));
        Console.WriteLine("Perfect Number: " + IsPerfect(number, factors));
        Console.WriteLine("Abundant Number: " + IsAbundant(number, factors));
        Console.WriteLine("Deficient Number: " + IsDeficient(number, factors));
        Console.WriteLine("Strong Number: " + IsStrong(number));
    }
}
