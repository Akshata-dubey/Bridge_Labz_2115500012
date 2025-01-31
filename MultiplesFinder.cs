using System;

class MultiplesFinder
{
    static void Main()
    {
        // Input: Get the number from the user
        Console.Write("Enter a number to find its multiples below 100: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"Multiples of {number} below 100 are:");

        // Loop: Run backward from 100 to 1
        for (int i = 100; i >= 1; i--)
        {
            if (i % number == 0) // Check if 'i' is a multiple of 'number'
            {
                Console.WriteLine(i); // Print the multiple
            }
        }
    }
}
