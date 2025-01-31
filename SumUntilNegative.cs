using System;

class SumUntilNegative
{
    static void Main()
    {
        // Initialize total to 0.0
        double total = 0.0;

        // Variable to store user input
        double number;

        // Infinite loop to take input
        while (true)
        {
            // Prompt the user to enter a number
            Console.Write("Enter a number (or 0/negative number to stop): ");
            number = double.Parse(Console.ReadLine());

            // Check if the entered number is 0 or negative
            if (number <= 0)
            {
                break; // Exit the loop
            }

            // Add the number to the total
            total += number;
        }

        // Display the total sum
        Console.WriteLine("The total sum is: " + total);
    }
}
