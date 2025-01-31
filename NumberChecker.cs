using System;

public class NumberChecker
{
    // Method to check whether the number is positive or negative
    public static string IsPositive(int number)
    {
        if (number < 0)
        {
            return "Negative";
        }
        else
        {
            return "Positive";
        }
    }

    // Method to check whether the number is even or odd
    public static string IsEven(int number)
    {
        if (number % 2 == 0)
        {
            return "Even";
        }
        else
        {
            return "Odd";
        }
    }

    // Method to compare two numbers
    public static int Compare(int num1, int num2)
    {
        if (num1 > num2)
        {
            return 1; // num1 is greater
        }
        else if (num1 == num2)
        {
            return 0; // both are equal
        }
        else
        {
            return -1; // num1 is smaller
        }
    }

    public static void Main(string[] args)
    {
        // Array to store 5 numbers
        int[] numbers = new int[5];

        Console.WriteLine("Enter 5 numbers:");

        // Taking user input for 5 numbers
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            bool validInput = int.TryParse(Console.ReadLine(), out numbers[i]);

            if (!validInput)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                i--; // Retry the same index if input is invalid
                continue;
            }
        }

        // Loop through the array to check each number
        for (int i = 0; i < numbers.Length; i++)
        {
            string positivity = IsPositive(numbers[i]);

            Console.WriteLine($"\nNumber {i + 1}: {numbers[i]}");

            // If positive, check if it's even or odd
            if (positivity == "Positive")
            {
                string evenOdd = IsEven(numbers[i]);
                Console.WriteLine($"The number is {evenOdd}.");
            }
            else
            {
                Console.WriteLine("The number is Negative.");
            }
        }

        // Comparing the first and last elements of the array
        int result = Compare(numbers[0], numbers[numbers.Length - 1]);

        if (result == 1)
        {
            Console.WriteLine($"\nThe first number {numbers[0]} is greater than the last number {numbers[numbers.Length - 1]}.");
        }
        else if (result == 0)
        {
            Console.WriteLine($"\nThe first number {numbers[0]} is equal to the last number {numbers[numbers.Length - 1]}.");
        }
        else
        {
            Console.WriteLine($"\nThe first number {numbers[0]} is less than the last number {numbers[numbers.Length - 1]}.");
        }
    }
}
