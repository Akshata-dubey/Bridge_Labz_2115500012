using System;

class NumberCheck
{
    static void Main()
    {
        // Input: Get an integer from the user
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Check if the number is positive, negative, or zero
        if (number > 0)
        {
            // Output: If the number is positive
            Console.WriteLine("positive");
        }
        else if (number < 0)
        {
            // Output: If the number is negative
            Console.WriteLine("negative");
        }
        else
        {
            // Output: If the number is zero
            Console.WriteLine("zero");
        }
    }
}
