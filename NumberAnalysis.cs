using System;

class NumberAnalysis
{
    static void Main()
    {
        int[] numbers = new int[5];  // Array to store 5 numbers

        // Take user input for 5 numbers
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            string input = Console.ReadLine();

            // Try to parse the input to an integer
            if (int.TryParse(input, out numbers[i]))
            {
                // Check if the number is positive, negative, or zero
                if (numbers[i] > 0)
                {
                    // For positive numbers, check if it's even or odd
                    if (numbers[i] % 2 == 0)
                    {
                        Console.WriteLine("The number " + numbers[i] + " is positive and even.");
                    }
                    else
                    {
                        Console.WriteLine("The number " + numbers[i] + " is positive and odd.");
                    }
                }
                else if (numbers[i] < 0)
                {
                    Console.WriteLine("The number " + numbers[i] + " is negative.");
                }
                else
                {
                    Console.WriteLine("The number " + numbers[i] + " is zero.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                i--; // Decrease the counter to ensure 5 valid numbers are entered
            }
        }

        // Compare the first and last elements of the array
        if (numbers[0] == numbers[4])
        {
            Console.WriteLine("The first and last elements are equal.");
        }
        else if (numbers[0] > numbers[4])
        {
            Console.WriteLine("The first element is greater than the last element.");
        }
        else
        {
            Console.WriteLine("The first element is less than the last element.");
        }
    }
}
