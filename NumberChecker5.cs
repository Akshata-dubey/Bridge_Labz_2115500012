using System;

public class NumberChecker5
{
    // Method to find the count of digits in a number
    public static int CountDigits(int number)
    {
        int count = 0;
        while (number != 0)
        {
            number /= 10;
            count++;
        }
        return count;
    }

    // Method to store the digits of the number in an array
    public static int[] StoreDigits(int number)
    {
        int numDigits = CountDigits(number);
        int[] digits = new int[numDigits];
        for (int i = numDigits - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    // Method to find the sum of digits of a number using the digits array
    public static int SumOfDigits(int number)
    {
        int[] digits = StoreDigits(number);
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += digit;
        }
        return sum;
    }

    // Method to find the sum of the squares of the digits of a number using the digits array
    public static double SumOfSquaresOfDigits(int number)
    {
        int[] digits = StoreDigits(number);
        double sumOfSquares = 0;
        foreach (int digit in digits)
        {
            sumOfSquares += Math.Pow(digit, 2); // Square of the digit
        }
        return sumOfSquares;
    }

    // Method to check if a number is a Harshad number using the digits array
    public static bool IsHarshadNumber(int number)
    {
        int sumOfDigits = SumOfDigits(number);
        return number % sumOfDigits == 0;
    }

    // Method to find the frequency of each digit in the number
    public static void FindDigitFrequency(int number)
    {
        int[] digits = StoreDigits(number);
        int[,] frequency = new int[10, 2]; // 2D array to store digit and frequency

        foreach (int digit in digits)
        {
            frequency[digit, 0] = digit; // Store the digit in the first column
            frequency[digit, 1]++; // Increment the frequency count in the second column
        }

        // Display the frequency of each digit
        Console.WriteLine("Digit Frequencies:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i, 1] > 0)
            {
                Console.WriteLine($"Digit {frequency[i, 0]}: {frequency[i, 1]} times");
            }
        }
    }

    // Main method to test the utility class
    public static void Main(string[] args)
    {
        // Example number
        int number = 21; // Change this to any number you want to test

        // 1. Count the digits
        int digitCount = CountDigits(number);
        Console.WriteLine($"Number of digits: {digitCount}");

        // 2. Store the digits in an array
        int[] digits = StoreDigits(number);
        Console.WriteLine("Digits: " + string.Join(", ", digits));

        // 3. Find the sum of digits
        int sumOfDigits = SumOfDigits(number);
        Console.WriteLine($"Sum of digits: {sumOfDigits}");

        // 4. Find the sum of squares of digits
        double sumOfSquares = SumOfSquaresOfDigits(number);
        Console.WriteLine($"Sum of squares of digits: {sumOfSquares}");

        // 5. Check if the number is a Harshad number
        bool isHarshad = IsHarshadNumber(number);
        Console.WriteLine($"Is the number a Harshad number? {isHarshad}");

        // 6. Find the frequency of each digit
        FindDigitFrequency(number);
    }
}
