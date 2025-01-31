using System;

class FizzBuzz
{
    static void Main()
    {
        // Prompt the user to enter a positive integer
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        // Check if the number is positive
        if (number > 0)
        {
            int i = 1;

            // Using while loop to iterate from 1 to the given number
            while (i <= number)
            {
                // Check for multiples of both 3 and 5
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                // Check for multiples of 3
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                // Check for multiples of 5
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    // Print the number itself if it's not divisible by 3 or 5
                    Console.WriteLine(i);
                }

                // Increment the counter
                i++;
            }
        }
        else
        {
            Console.WriteLine("Please enter a positive integer.");
        }
    }
}
