using System;

public class NumberChecker
{
    // Method to find factors of a number and return them as an array
    public static int[] FindFactors(int number)
    {
        int[] temp = new int[number];
        int count = 0;

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                temp[count] = i;
                count++;
            }
        }

        int[] factors = new int[count];
        Array.Copy(temp, factors, count);
        return factors;
    }

    // Method to find the greatest factor of a number using the factors array
    public static int FindGreatestFactor(int number)
    {
        int[] factors = FindFactors(number);
        return factors[factors.Length - 1];
    }

    // Method to find the sum of the factors using the factors array
    public static int FindSumOfFactors(int number)
    {
        int[] factors = FindFactors(number);
        int sum = 0;
        foreach (var factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    // Method to find the product of the factors using the factors array
    public static int FindProductOfFactors(int number)
    {
        int[] factors = FindFactors(number);
        int product = 1;
        foreach (var factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    // Method to find the product of the cubes of the factors using the factors array
    public static double FindProductOfCubeOfFactors(int number)
    {
        int[] factors = FindFactors(number);
        double product = 1.0;
        foreach (var factor in factors)
        {
            product *= Math.Pow(factor, 3);
        }
        return product;
    }

    // Method to check if a number is a perfect number
    public static bool IsPerfectNumber(int number)
    {
        int sum = FindSumOfFactors(number) - number; // Exclude the number itself
        return sum == number;
    }

    // Method to check if a number is an abundant number
    public static bool IsAbundantNumber(int number)
    {
        int sum = FindSumOfFactors(number) - number; // Exclude the number itself
        return sum > number;
    }

    // Method to check if a number is a deficient number
    public static bool IsDeficientNumber(int number)
    {
        int sum = FindSumOfFactors(number) - number; // Exclude the number itself
        return sum < number;
    }

    // Method to check if a number is a strong number
    public static bool IsStrongNumber(int number)
    {
        int sum = 0;
        int temp = number;
        while (temp > 0)
        {
            int digit = temp % 10;
            sum += Factorial(digit);
            temp /= 10;
        }
        return sum == number;
    }

    // Helper method to calculate the factorial of a number
    public static int Factorial(int n)
    {
        if (n == 0)
            return 1;
        int fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }
        return fact;
    }

    // Main method to test the utility class
    public static void Main(string[] args)
    {
        // Example number to test
        int number = 28; // Change this to any number you want to test

        // 1. Find the factors of the number
        int[] factors = FindFactors(number);
        Console.WriteLine($"Factors of {number}: " + string.Join(", ", factors));

        // 2. Find the greatest factor
        int greatestFactor = FindGreatestFactor(number);
        Console.WriteLine($"Greatest factor of {number}: {greatestFactor}");

        // 3. Find the sum of the factors
        int sumOfFactors = FindSumOfFactors(number);
        Console.WriteLine($"Sum of factors of {number}: {sumOfFactors}");

        // 4. Find the product of the factors
        int productOfFactors = FindProductOfFactors(number);
        Console.WriteLine($"Product of factors of {number}: {productOfFactors}");

        // 5. Find the product of the cubes of the factors
        double productOfCubeOfFactors = FindProductOfCubeOfFactors(number);
        Console.WriteLine($"Product of cubes of factors of {number}: {productOfCubeOfFactors}");

        // 6. Check if the number is a perfect number
        bool isPerfect = IsPerfectNumber(number);
        Console.WriteLine($"Is {number} a perfect number? {isPerfect}");

        // 7. Check if the number is an abundant number
        bool isAbundant = IsAbundantNumber(number);
        Console.WriteLine($"Is {number} an abundant number? {isAbundant}");

        // 8. Check if the number is a deficient number
        bool isDeficient = IsDeficientNumber(number);
        Console.WriteLine($"Is {number} a deficient number? {isDeficient}");

        // 9. Check if the number is a strong number
        bool isStrong = IsStrongNumber(number);
        Console.WriteLine($"Is {number} a strong number? {isStrong}");
    }
}
