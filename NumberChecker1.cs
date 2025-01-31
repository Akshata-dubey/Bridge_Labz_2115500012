using System;

public class NumberChecker
{
    // Method to check whether a number is positive, negative, or zero
    public static int CheckNumber(int number)
    {
        if (number < 0)
        {
            return -1; // Return -1 if the number is negative
        }
        else if (number > 0)
        {
            return 1; // Return 1 if the number is positive
        }
        else
        {
            return 0; // Return 0 if the number is zero
        }
    }

    public static void Main(string[] args)
    {
        // Get input from the user
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Call the method to check the number
        int result = CheckNumber(number);

        // Display the result
        if (result == -1)
        {
            Console.WriteLine("The number is negative.");
        }
        else if (result == 1)
        {
            Console.WriteLine("The number is positive.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
    }
}
