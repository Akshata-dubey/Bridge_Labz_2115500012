using System;

class FindFactors
{
    static void Main()
    {
        // Get input for the number
        Console.Write("Enter a number to find its factors: ");
        int number = int.Parse(Console.ReadLine());

        // Initialize maxFactor to 10 and create factors array
        int maxFactor = 10;
        int[] factors = new int[maxFactor];
        int index = 0;

        // Loop through numbers from 1 to the entered number to find factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)  // If i is a factor of the number
            {
                // Check if the array is full
                if (index == maxFactor)
                {
                    // Double the size of the array if it's full
                    maxFactor *= 2;
                    int[] temp = new int[maxFactor];
                    Array.Copy(factors, temp, factors.Length);  // Copy elements to the temp array
                    factors = temp;  // Assign the temp array to factors
                }

                // Store the factor in the array
                factors[index++] = i;
            }
        }

        // Display the factors
        Console.WriteLine("Factors of " + number + ":");
        for (int i = 0; i < index; i++)
        {
            Console.Write(factors[i] + " ");
        }
    }
}
