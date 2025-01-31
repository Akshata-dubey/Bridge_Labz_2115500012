using System;

class ReverseNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number;

        // Validate user input
        while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }

        // Find the count of digits in the number
        int temp = number;
        int digitCount = 0;

        while (temp != 0)
        {
            temp /= 10; // Remove last digit
            digitCount++;
        }

        // Create an array to store the digits
        int[] digits = new int[digitCount];
        int index = 0;

        // Store the digits in the array
        while (number != 0)
        {
            digits[index] = number % 10; // Get the last digit
            number /= 10;               // Remove the last digit
            index++;
        }

        // Display the array in reverse order
        Console.WriteLine("The reversed number is: ");
        for (int i = 0; i < digitCount; i++)
        {
            Console.Write(digits[i]);
        }

        Console.WriteLine();
    }
}
