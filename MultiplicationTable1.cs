using System;

class MultiplicationTable
{
    static void Main()
    {
        // Take integer input from the user
        Console.Write("Enter a number to find its multiplication table from 6 to 9: ");
        int number = int.Parse(Console.ReadLine());

        // Define an array to store the multiplication results
        int[] multiplicationResult = new int[4];  // Array to store results for 6 to 9

        // Find the multiplication results and store them in the array
        for (int i = 6; i <= 9; i++)
        {
            multiplicationResult[i - 6] = number * i;  // Store result for number * i
        }

        // Display the multiplication results
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine(number + " * " + i + " = " + multiplicationResult[i - 6]);
        }
    }
}
