using System;

class GreatestFactor
{
    static void Main()
    {
        // Input: Get the number from the user
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Initialize greatestFactor
        int greatestFactor = 1;

        // Loop to find the greatest factor
        for (int i = number - 1; i > 0; i--)
        {
            if (number % i == 0) // Check if 'i' is a factor
            {
                greatestFactor = i;
                break; // Break the loop once the greatest factor is found
            }
        }

        // Output the greatest factor
        Console.WriteLine($"The greatest factor of {number} (besides itself) is {greatestFactor}.");
    }
}
