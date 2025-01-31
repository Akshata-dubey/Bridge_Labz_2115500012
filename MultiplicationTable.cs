using System;

class MultiplicationTable
{
    static void Main()
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Using a for loop to generate the multiplication table from 6 to 9
        for (int i = 6; i <= 9; i++)
        {
            // Print the multiplication result
            Console.WriteLine(number + " * " + i + " = " + (number * i));
        }
    }
}
