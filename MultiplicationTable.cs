using System;

class MultiplicationTable
{
    static void Main()
    {
        // Get the number from the user
        Console.Write("Enter a number to print its multiplication table: ");
        int number = int.Parse(Console.ReadLine());

        // Define an array to store the multiplication results
        int[] multiplicationTable = new int[10];

        // Loop through 1 to 10 and store the results in the array
        for (int i = 0; i < 10; i++)
        {
            multiplicationTable[i] = number * (i + 1);  // Store the result of number * (i+1)
        }

        // Display the multiplication table
        Console.WriteLine("Multiplication table of " + number + ":");
        for (int i = 0; i < multiplicationTable.Length; i++)
        {
            Console.WriteLine(number + " * " + (i + 1) + " = " + multiplicationTable[i]);
        }
    }
}
