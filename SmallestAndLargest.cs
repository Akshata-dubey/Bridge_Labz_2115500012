using System;

public class SmallestAndLargest
{
    // Method to find the smallest and largest of three numbers
    public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
    {
        // Initialize an array to store the smallest and largest values
        int[] result = new int[2];

        // Finding the smallest number
        result[0] = Math.Min(number1, Math.Min(number2, number3));

        // Finding the largest number
        result[1] = Math.Max(number1, Math.Max(number2, number3));

        return result;
    }

    public static void Main(string[] args)
    {
        // Take user input for 3 numbers
        Console.Write("Enter the first number: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int number2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int number3 = int.Parse(Console.ReadLine());

        // Call the method to find the smallest and largest numbers
        int[] result = FindSmallestAndLargest(number1, number2, number3);

        // Display the smallest and largest numbers
        Console.WriteLine($"The smallest number is: {result[0]}");
        Console.WriteLine($"The largest number is: {result[1]}");
    }
}
