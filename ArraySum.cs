using System;

class ArraySum
{
    static void Main()
    {
        double[] numbers = new double[10];  // Array to store up to 10 numbers
        double total = 0.0;  // Variable to store the sum
        int index = 0;  // Index variable to track array position

        // Infinite while loop
        while (true)
        {
            // Take input from the user
            Console.Write("Enter a number (or 0 or a negative number to stop): ");
            double input = double.Parse(Console.ReadLine());

            // Break if the input is 0 or negative or if the array is full
            if (input <= 0 || index >= 10)
            {
                break;
            }

            // Store the number in the array and increment the index
            numbers[index] = input;
            index++;
        }

        // Calculate the total and display the numbers
        Console.WriteLine("\nThe numbers you entered are:");
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(numbers[i]);
            total += numbers[i];  // Add the number to the total
        }

        // Display the sum of all numbers
        Console.WriteLine("\nThe total sum of the numbers is: " + total);
    }
}
