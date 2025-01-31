using System;

class MultiDimensionalArrayExample
{
    static void Main()
    {
        // Get input for rows and columns
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of columns: ");
        int columns = int.Parse(Console.ReadLine());

        // Create a 2D array (Matrix)
        int[,] matrix = new int[rows, columns];

        // Take user input to fill the 2D array
        Console.WriteLine("Enter the elements of the matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Enter element at position ({i}, {j}): ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Create a 1D array to store the elements from the 2D array
        int[] oneDArray = new int[rows * columns];

        // Index variable for the 1D array
        int index = 0;

        // Copy elements from the 2D array into the 1D array
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                oneDArray[index++] = matrix[i, j];  // Copy element and increment index
            }
        }

        // Display the 1D array
        Console.WriteLine("\nThe 1D array after copying elements from the 2D array:");
        for (int i = 0; i < oneDArray.Length; i++)
        {
            Console.Write(oneDArray[i] + " ");
        }
    }
}
