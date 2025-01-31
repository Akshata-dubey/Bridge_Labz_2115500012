using System;

public class NumberChecker6
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

    // Method to reverse the digits array
    public static int[] ReverseDigits(int[] digits)
    {
        int[] reversedDigits = new int[digits.Length];
        for (int i = 0; i < digits.Length; i++)
        {
            reversedDigits[i] = digits[digits.Length - 1 - i];
        }
        return reversedDigits;
    }

    // Method to compare two arrays and check if they are equal
    public static bool AreArraysEqual(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
        {
            return false;
        }
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i])
            {
                return false;
            }
        }
        return true;
    }

    // Method to check if a number is a palindrome
    public static bool IsPalindrome(int number)
    {
        int[] digits = StoreDigits(number);
        int[] reversedDigits = ReverseDigits(digits);
        return AreArraysEqual(digits, reversedDigits);
    }

    // Method to check if a number is a duck number
    public static bool IsDuckNumber(int number)
    {
        int[] digits = StoreDigits(number);
        foreach (int digit in digits)
        {
            if (digit != 0)
            {
                return true; // Non-zero digit is found
            }
        }
        return false; // If only zeroes are present
    }

    // Main method to test the utility class
    public static void Main(string[] args)
    {
        // Example number
        int number = 12021; // Change this to any number you want to test

        // 1. Count the digits
        int digitCount = CountDigits(number);
        Console.WriteLine($"Number of digits: {digitCount}");

        // 2. Store the digits in an array
        int[] digits = StoreDigits(number);
        Console.WriteLine("Digits: " + string.Join(", ", digits));

        // 3. Reverse the digits array
        int[] reversedDigits = ReverseDigits(digits);
        Console.WriteLine("Reversed digits: " + string.Join(", ", reversedDigits));

        // 4. Check if the number is a palindrome
        bool isPalindrome = IsPalindrome(number);
        Console.WriteLine($"Is the number a palindrome? {isPalindrome}");

        // 5. Check if the number is a duck number
        bool isDuckNumber = IsDuckNumber(number);
        Console.WriteLine($"Is the number a duck number? {isDuckNumber}");
    }
}
