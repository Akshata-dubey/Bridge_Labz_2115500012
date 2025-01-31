using System;

class NaturalNumberCheck
{
    static void Main()
    {
        // Input: Get the number from the user
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Check if the number is a positive integer
        if (number >= 1)
        {
            // Calculate the sum of first 'n' natural numbers using the formula
            int sum = (number * (number + 1)) / 2;

            // Output the sum of first 'n' natural numbers
            Console.WriteLine("The sum of " + number + " natural numbers is " + sum);
        }
        else
        {
            // If the number is not a positive integer
            Console.WriteLine("The number " + number + " is not a natural number");
        }
    }
}
