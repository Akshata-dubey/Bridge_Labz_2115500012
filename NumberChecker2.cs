using System;

public class NumberChecker
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

    // Method to check if the number is a Duck number
    public static bool IsDuckNumber(int number)
    {
        int[] digits = StoreDigits(number);
        foreach (int digit in digits)
        {
            if (digit != 0) // A duck number has at least one non-zero digit
                return true;
        }
        return false;
    }

    // Method to check if the number is an Armstrong number
    public static bool IsArmstrongNumber(int number)
    {
        int[] digits = StoreDigits(number);
        int sum = 0;
        int numDigits = digits.Length;
        foreach (int digit in digits)
        {
            sum += (int)Math.Pow(digit, numDigits); // Sum of digits raised to the power of the number of digits
        }
        return sum == number;
    }

    // Method to find the largest and second largest digits in the array
    public static (int, int) FindLargestAndSecondLargest(int[] digits)
    {
        int largest = Int32.MinValue;
        int secondLargest = Int32.MinValue;

        foreach (int digit in digits)
        {
            if (digit > largest)
            {
                secondLargest = largest;
                largest = digit;
            }
            else if (digit > secondLargest && digit != largest)
            {
                secondLargest = digit;
            }
        }

        return (largest, secondLargest);
    }

    // Method to find the smallest and second smallest digits in the array
    public static (int, int) FindSmallestAndSecondSmallest(int[] digits)
    {
        int smallest = Int32.MaxValue;
        int secondSmallest = Int32.MaxValue;

        foreach (int digit in digits)
        {
            if (digit < smallest)
            {
                secondSmallest = smallest;
                smallest = digit;
            }
            else if (digit < secondSmallest && digit != smallest)
            {
                secondSmallest = digit;
            }
        }

        return (smallest, secondSmallest);
    }

    public static void Main(string[] args)
    {
        // Example number
        int number = 153; // Change this to any number you want to test

        // 1. Count the digits
        int digitCount = CountDigits(number);
        Console.WriteLine($"Number of digits: {digitCount}");

        // 2. Store the digits in an array
        int[] digits = StoreDigits(number);
        Console.WriteLine("Digits: " + string.Join(", ", digits));

        // 3. Check if the number is a Duck number
        bool isDuck = IsDuckNumber(number);
        Console.WriteLine($"Is the number a Duck number? {isDuck}");

        // 4. Check if the number is an Armstrong number
        bool isArmstrong = IsArmstrongNumber(number);
        Console.WriteLine($"Is the number an Armstrong number? {isArmstrong}");

        // 5. Find the largest and second largest digits
        var (largest, secondLargest) = FindLargestAndSecondLargest(digits);
        Console.WriteLine($"Largest Digit: {largest}, Second Largest Digit: {secondLargest}");

        // 6. Find the smallest and second smallest digits
        var (smallest, secondSmallest) = FindSmallestAndSecondSmallest(digits);
        Console.WriteLine($"Smallest Digit: {smallest}, Second Smallest Digit: {secondSmallest}");
    }
}
