using System;

class SumNumbers
{
    static void Main()
    {
        // Initialize total to 0.0
        double total = 0.0;

        // Create a variable to store the user's input
        double number;

        // Loop to continuously take input until the user enters 0
        while (true)
        {
            // Ask the user for input
            Console.Write("Enter a number (or 0 to stop): ");
            number = double.Parse(Console.ReadLine());

            // If the user enters 0, break the loop
            if (number == 0)
            {
                break;
            }

            // Add the entered number to the total
            total += number;
        }

        // Display the total sum
        Console.WriteLine("The total sum is: " + total);
    }
}
