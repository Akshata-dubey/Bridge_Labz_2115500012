using System;

class OddEvenNumbers
{
    static void Main()
    {
        // Get input from the user
        Console.Write("Enter a number: ");
        int number;
        
        // Check if the input is a valid natural number
        if (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
        {
            Console.WriteLine("Error: Please enter a valid natural number.");
            return;  // Exit the program if input is invalid
        }

        // Create arrays for even and odd numbers with size = number / 2 + 1
        int[] oddNumbers = new int[number / 2 + 1];
        int[] evenNumbers = new int[number / 2 + 1];

        // Index variables for odd and even numbers
        int oddIndex = 0;
        int evenIndex = 0;

        // Loop through numbers from 1 to the input number
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                // Save even number to the evenNumbers array
                evenNumbers[evenIndex++] = i;
            }
            else
            {
                // Save odd number to the oddNumbers array
                oddNumbers[oddIndex++] = i;
            }
        }

        // Print the odd numbers array
        Console.WriteLine("\nOdd Numbers:");
        for (int i = 0; i < oddIndex; i++)
        {
            Console.Write(oddNumbers[i] + " ");
        }

        // Print the even numbers array
        Console.WriteLine("\nEven Numbers:");
        for (int i = 0; i < evenIndex; i++)
        {
            Console.Write(evenNumbers[i] + " ");
        }
    }
}
