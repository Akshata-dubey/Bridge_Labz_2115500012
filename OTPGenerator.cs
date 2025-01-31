using System;

class OTPGenerator
{
    // Method to generate a 6-digit OTP number
    public static int GenerateOTP()
    {
        // Generate a random number between 100000 and 999999 (inclusive)
        Random rand = new Random();
        return rand.Next(100000, 1000000);  // Generates a number between 100000 and 999999
    }

    // Method to ensure that the OTP numbers are unique
    public static bool AreUniqueOTPs(int[] otps)
    {
        // Check if there are any duplicates in the array
        for (int i = 0; i < otps.Length; i++)
        {
            for (int j = i + 1; j < otps.Length; j++)
            {
                if (otps[i] == otps[j])
                {
                    return false;  // If any OTP is the same, return false
                }
            }
        }
        return true;  // If all OTPs are unique, return true
    }

    static void Main(string[] args)
    {
        // Create an array to store the 10 OTP numbers
        int[] otps = new int[10];

        // Generate OTP numbers 10 times
        for (int i = 0; i < 10; i++)
        {
            otps[i] = GenerateOTP();
        }

        // Display the OTP numbers generated
        Console.WriteLine("Generated OTP Numbers:");
        foreach (var otp in otps)
        {
            Console.WriteLine(otp);
        }

        // Check if the OTP numbers are unique
        if (AreUniqueOTPs(otps))
        {
            Console.WriteLine("All OTPs are unique.");
        }
        else
        {
            Console.WriteLine("Some OTPs are not unique.");
        }
    }
}
