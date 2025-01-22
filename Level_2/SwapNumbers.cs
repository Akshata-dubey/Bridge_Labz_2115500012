using System;

class SwapNumbers
{
    static void Main()
    {
        // Input: Ask the user to enter the first number
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        // Input: Ask the user to enter the second number
        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        // Display original numbers
        Console.WriteLine("Before swapping: Number1 = " + number1 + ", Number2 = " + number2);

        // Swapping the numbers
        int temp = number1; // Store number1 in a temporary variable
        number1 = number2;  // Assign number2 to number1
        number2 = temp;     // Assign temp (original number1) to number2

        // Output the swapped numbers
        Console.WriteLine("After swapping: Number1 = " + number1 + ", Number2 = " + number2);
    }
}
