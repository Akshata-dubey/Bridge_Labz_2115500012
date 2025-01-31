using System;

public class QuotientAndRemainder
{
    // Method to find the quotient and remainder of two numbers
    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        // Initialize an array to store the quotient and remainder
        int[] result = new int[2];

        // Calculate the quotient using division operator
        result[0] = number / divisor;

        // Calculate the remainder using modulus operator
        result[1] = number % divisor;

        return result;
    }

    public static void Main(string[] args)
    {
        // Take user input for two numbers
        Console.Write("Enter the dividend: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter the divisor: ");
        int divisor = int.Parse(Console.ReadLine());

        // Call the method to find the quotient and remainder
        int[] result = FindRemainderAndQuotient(number, divisor);

        // Display the quotient and remainder
        Console.WriteLine($"The quotient is: {result[0]}");
        Console.WriteLine($"The remainder is: {result[1]}");
    }
}
