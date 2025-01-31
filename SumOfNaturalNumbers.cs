using System;

public class SumOfNaturalNumbers
{
    // Method to calculate the sum of n natural numbers using a loop
    public static int CalculateSum(int n)
    {
        int sum = 0;

        // Loop to calculate the sum of first n natural numbers
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        return sum;
    }

    public static void Main(string[] args)
    {
        // Get integer input from the user
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        // Check if the input is a valid positive integer
        if (n < 1)
        {
            Console.WriteLine("Please enter a valid positive integer.");
        }
        else
        {
            // Call the method to calculate the sum of first n natural numbers
            int sum = CalculateSum(n);

            // Display the result
            Console.WriteLine($"The sum of the first {n} natural numbers is: {sum}");
        }
    }
}
