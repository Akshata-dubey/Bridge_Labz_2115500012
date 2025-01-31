using System;

class FactorCalculator
{
    static void Main(string[] args)
    {
        // Take user input
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Find factors and store them in an array
        int[] factors = FindFactors(number);

        // Display factors
        Console.WriteLine("Factors of " + number + ":");
        foreach (int factor in factors)
        {
            Console.Write(factor + " ");
        }
        Console.WriteLine();

        // Calculate and display results
        Console.WriteLine("Sum of factors: " + SumOfFactors(factors));
        Console.WriteLine("Sum of square of factors: " + SumOfSquareOfFactors(factors));
        Console.WriteLine("Product of factors: " + ProductOfFactors(factors));
    }

    // Method to find factors of a number and return them as an array
    static int[] FindFactors(int number)
    {
        int count = 0;

        // First loop to count the number of factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        // Initialize the array with the size of the number of factors
        int[] factors = new int[count];
        int index = 0;

        // Second loop to store the factors in the array
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index] = i;
                index++;
            }
        }

        return factors;
    }

    // Method to calculate the sum of the factors
    static int SumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    // Method to calculate the product of the factors
    static long ProductOfFactors(int[] factors)
    {
        long product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    // Method to calculate the sum of the square of the factors
    static double SumOfSquareOfFactors(int[] factors)
    {
        double sum = 0;
        foreach (int factor in factors)
        {
            sum += Math.Pow(factor, 2);
        }
        return sum;
    }
}
