using System;

public class NumberChecker7
{
    // Method to check if a number is prime
    public static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    // Method to check if a number is a neon number
    public static bool IsNeon(int number)
    {
        int square = number * number;
        int sum = 0;
        while (square > 0)
        {
            sum += square % 10;
            square /= 10;
        }
        return sum == number;
    }

    // Method to check if a number is a spy number
    public static bool IsSpy(int number)
    {
        int sum = 0;
        int product = 1;
        while (number > 0)
        {
            int digit = number % 10;
            sum += digit;
            product *= digit;
            number /= 10;
        }
        return sum == product;
    }

    // Method to check if a number is an automorphic number
    public static bool IsAutomorphic(int number)
    {
        int square = number * number;
        string numberStr = number.ToString();
        string squareStr = square.ToString();
        return squareStr.EndsWith(numberStr);
    }

    // Method to check if a number is a buzz number
    public static bool IsBuzz(int number)
    {
        return (number % 7 == 0 || number % 10 == 7);
    }

    // Main method to test the utility class
    public static void Main(string[] args)
    {
        // Example number to test
        int number = 28; // Change this to any number you want to test

        // 1. Check if the number is prime
        bool isPrime = IsPrime(number);
        Console.WriteLine($"Is {number} a prime number? {isPrime}");

        // 2. Check if the number is neon
        bool isNeon = IsNeon(number);
        Console.WriteLine($"Is {number} a neon number? {isNeon}");

        // 3. Check if the number is spy
        bool isSpy = IsSpy(number);
        Console.WriteLine($"Is {number} a spy number? {isSpy}");

        // 4. Check if the number is automorphic
        bool isAutomorphic = IsAutomorphic(number);
        Console.WriteLine($"Is {number} an automorphic number? {isAutomorphic}");

        // 5. Check if the number is buzz
        bool isBuzz = IsBuzz(number);
        Console.WriteLine($"Is {number} a buzz number? {isBuzz}");
    }
}
