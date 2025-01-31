using System;

class FizzBuzz
{
    static void Main()
    {
        // Take input for the number
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        // Check if the number is positive
        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;  // Exit the program if not a positive integer
        }

        // Create a string array to store the results
        string[] result = new string[number + 1];

        // Loop through numbers from 0 to the entered number
        for (int i = 0; i <= number; i++)
        {
            // Check for multiples of 3 and 5
            if (i % 3 == 0 && i % 5 == 0)
            {
                result[i] = "FizzBuzz";
            }
            else if (i % 3 == 0)
            {
                result[i] = "Fizz";
            }
            else if (i % 5 == 0)
            {
                result[i] = "Buzz";
            }
            else
            {
                result[i] = i.ToString();  // Store the number itself if not a multiple of 3 or 5
            }
        }

        // Loop to display the results with their index positions
        for (int i = 0; i <= number; i++)
        {
            Console.WriteLine($"Position {i} = {result[i]}");
        }
    }
}
