using System;

class DigitFrequency
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        // Validate the input for a valid number
        long number;
        while (!long.TryParse(input, out number) || number < 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
            input = Console.ReadLine();
        }

        // Initialize frequency array
        int[] frequency = new int[10];

        // Loop through each digit of the number
        while (number > 0)
        {
            int digit = (int)(number % 10); // Get the last digit
            frequency[digit]++;           // Increment frequency of the digit
            number /= 10;                 // Remove the last digit
        }

        // Display the frequency of each digit
        Console.WriteLine("\nDigit Frequency:");
        for (int i = 0; i < frequency.Length; i++)
        {
            if (frequency[i] > 0) // Display only digits with non-zero frequency
            {
                Console.WriteLine($"Digit {i}: {frequency[i]} time(s)");
            }
        }
    }
}
