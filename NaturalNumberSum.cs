using System;

class NaturalNumberSum
{
    static void Main(string[] args)
    {
        // Take user input
        Console.Write("Enter a natural number: ");
        int n;
        bool isValidInput = int.TryParse(Console.ReadLine(), out n);

        // Check if input is a valid natural number
        if (!isValidInput || n <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a natural number (greater than 0).");
            return;
        }

        // Compute the sum using recursion
        int recursiveSum = SumUsingRecursion(n);

        // Compute the sum using the formula
        int formulaSum = SumUsingFormula(n);

        // Display results
        Console.WriteLine($"Sum of first {n} natural numbers using recursion: {recursiveSum}");
        Console.WriteLine($"Sum of first {n} natural numbers using formula: {formulaSum}");

        // Compare results
        if (recursiveSum == formulaSum)
        {
            Console.WriteLine("Both computations match. The result is correct.");
        }
        else
        {
            Console.WriteLine("The results do not match. There might be an error in computation.");
        }
    }

    // Method to calculate sum using recursion
    static int SumUsingRecursion(int n)
    {
        if (n == 1)
            return 1;
        return n + SumUsingRecursion(n - 1);
    }

    // Method to calculate sum using the formula n*(n+1)/2
    static int SumUsingFormula(int n)
    {
        return n * (n + 1) / 2;
    }
}
