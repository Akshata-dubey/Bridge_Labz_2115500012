using System;

class Factorial
{
    static void Main()
    {
        // Prompt the user to enter a positive integer
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        // Check if the entered number is positive
        if (number >= 0)
        {
            // Initialize variables
            int factorial = 1;
            int i = number;

            // Compute the factorial using a while loop
            while (i > 0)
            {
                factorial *= i;
                i--;
            }

            // Print the result
            Console.WriteLine("The factorial of " + number + " is: " + factorial);
        }
        else
        {
            // If the input is not a positive integer
            Console.WriteLine("Please enter a non-negative integer.");
        }
    }
}
