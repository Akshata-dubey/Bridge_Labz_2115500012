using System;

class FactorsFinder
{
    static void Main()
    {
        // Input: Get the number from the user
        Console.Write("Enter a number to find its factors: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"Factors of {number} are:");

        // Loop to find factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0) // Check if 'number' is perfectly divisible by 'i'
            {
                Console.WriteLine(i); // Print the factor
            }
        }
    }
}
