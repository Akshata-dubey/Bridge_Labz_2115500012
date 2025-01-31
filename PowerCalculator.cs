using System;

class PowerCalculator
{
    static void Main()
    {
        // Input: Get the base number and power from the user
        Console.Write("Enter the base number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter the power: ");
        int power = int.Parse(Console.ReadLine());

        // Initialize result to 1
        int result = 1;

        // Calculate power using a for loop
        for (int i = 1; i <= power; i++)
        {
            result *= number; // Multiply result with the base number
        }

        // Output the result
        Console.WriteLine($"{number} raised to the power of {power} is {result}.");
    }
}
