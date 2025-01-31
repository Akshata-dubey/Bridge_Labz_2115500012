using System;

class Harshad
{
    static void Main()
    {
        // Taking the input value
        Console.Write("Enter the input value: ");
        int number = int.Parse(Console.ReadLine());

        // Store the original number for the final check
        int originalNumber = number;

        // Initializing the sum with 0
        int sum = 0;

        // Iterating to access each digit of the number
        while (number != 0)
        {
			// Extract the last digit
            int remainder = number % 10; 
			 // Add the digit to the sum
            sum += remainder;   
		   // Remove the last digit
            number /= 10;             
        }

        // Check if the original number is divisible by the sum of its digits
        if (originalNumber % sum == 0)
        {
            Console.WriteLine("The number is a Harshad number.");
        }
        else
        {
            Console.WriteLine("The number is not a Harshad number.");
        }
    }
}
