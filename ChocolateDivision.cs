using System;

public class ChocolateDivision
{
    // Method to calculate the chocolates each child gets and the remaining chocolates
    public static int[] FindChocolatesAndRemainder(int numberOfChocolates, int numberOfChildren)
    {
        // Initialize an array to store the number of chocolates each child gets and the remaining chocolates
        int[] result = new int[2];

        // Calculate the number of chocolates each child gets using division
        result[0] = numberOfChocolates / numberOfChildren;

        // Calculate the remaining chocolates using modulus
        result[1] = numberOfChocolates % numberOfChildren;

        return result;
    }

    public static void Main(string[] args)
    {
        // Take user input for number of chocolates and number of children
        Console.Write("Enter the number of chocolates: ");
        int numberOfChocolates = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of children: ");
        int numberOfChildren = int.Parse(Console.ReadLine());

        // Call the method to find the chocolates each child gets and the remaining chocolates
        int[] result = FindChocolatesAndRemainder(numberOfChocolates, numberOfChildren);

        // Display the number of chocolates each child gets and the remaining chocolates
        Console.WriteLine($"Each child gets {result[0]} chocolates.");
        Console.WriteLine($"The remaining chocolates are {result[1]}.");
    }
}
