using System;

class Factorial
{
    static void Main()
    {
        // Prompt the user to enter a positive integer
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        // Check if the entered number is non-negative
        if (number >= 0)
        {
            // Initialize factorial variable
            int factorial = 1;

            // Compute the factorial using a for loop
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            // Print the result
            Console.WriteLine("The factorial of " + number + " is: " + factorial);
        }
        else
        {
            // If the input is not a non-negative integer
            Console.WriteLine("Please enter a non-negative integer.");
        }
    }
}
