using System;

class OddEvenNumbers
{
    static void Main()
    {
        // Prompt the user to enter a number
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        // Check if the number is a natural number (positive integer)
        if (number > 0)
        {
            // Iterate from 1 to the entered number
            for (int i = 1; i <= number; i++)
            {
                // Check if the number is odd or even
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " is an even number.");
                }
                else
                {
                    Console.WriteLine(i + " is an odd number.");
                }
            }
        }
        else
        {
            // If the number is not a natural number
            Console.WriteLine("Please enter a natural number greater than 0.");
        }
    }
}
