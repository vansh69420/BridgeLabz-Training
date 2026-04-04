using System;

class OTPGenerator
{
    // a. Method to generate 6-digit OTP
    public static int GenerateOTP()
    {
        Random random = new Random();
        // Generates number between 100000 and 999999
        return random.Next(100000, 1000000);
    }

    // c. Method to check if all OTPs are unique
    public static bool AreOTPsUnique(int[] otps)
    {
        for (int i = 0; i < otps.Length; i++)
        {
            for (int j = i + 1; j < otps.Length; j++)
            {
                if (otps[i] == otps[j])
                {
                    return false;
                }
            }
        }
        return true;
    }

    // Main Method
    static void Main(string[] args)
    {
        int[] otpArray = new int[10];

        // b. Generate OTPs 10 times
        for (int i = 0; i < otpArray.Length; i++)
        {
            otpArray[i] = GenerateOTP();
        }

        Console.WriteLine("Generated OTPs:");
        for (int i = 0; i < otpArray.Length; i++)
        {
            Console.WriteLine("OTP " + (i + 1) + ": " + otpArray[i]);
        }

        bool isUnique = AreOTPsUnique(otpArray);

        if (isUnique)
        {
            Console.WriteLine("\nAll OTPs are UNIQUE ");
        }
        else
        {
            Console.WriteLine("\nDuplicate OTP found ");
        }
    }
}
