using System;

class LargestDigits
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number;

        // Validate user input
        while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }

        const int maxDigits = 10;
        int[] digits = new int[maxDigits];
        int index = 0;

        // Extract digits and store them in the array
        while (number != 0 && index < maxDigits)
        {
            digits[index] = number % 10; // Get the last digit
            number /= 10;               // Remove the last digit
            index++;
        }

        // Initialize variables to store the largest and second largest digits
        int largest = 0;
        int secondLargest = 0;

        // Find the largest and second largest digits
        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest; // Update second largest
                largest = digits[i];     // Update largest
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i]; // Update second largest
            }
        }

        // Display results
        Console.WriteLine($"The largest digit is: {largest}");
        if (secondLargest > 0)
        {
            Console.WriteLine($"The second largest digit is: {secondLargest}");
        }
        else
        {
            Console.WriteLine("There is no second largest digit.");
        }
    }
}
