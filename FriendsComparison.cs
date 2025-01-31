using System;

public class FriendsComparison
{
    // Method to find the youngest friend
    public static string FindYoungest(string[] names, int[] ages)
    {
        int minAgeIndex = 0;
        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < ages[minAgeIndex])
            {
                minAgeIndex = i;
            }
        }
        return names[minAgeIndex];
    }

    // Method to find the tallest friend
    public static string FindTallest(string[] names, double[] heights)
    {
        int maxHeightIndex = 0;
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > heights[maxHeightIndex])
            {
                maxHeightIndex = i;
            }
        }
        return names[maxHeightIndex];
    }

    public static void Main(string[] args)
    {
        // Names of the friends
        string[] names = { "Amar", "Akbar", "Anthony" };

        // Arrays to store ages and heights
        int[] ages = new int[3];
        double[] heights = new double[3];

        // Taking user input for ages and heights
        Console.WriteLine("Enter the ages and heights for Amar, Akbar, and Anthony:");

        for (int i = 0; i < names.Length; i++)
        {
            Console.Write($"{names[i]}'s age: ");
            bool validAgeInput = int.TryParse(Console.ReadLine(), out ages[i]);
            if (!validAgeInput || ages[i] < 0)
            {
                Console.WriteLine("Invalid input. Age must be a non-negative number. Try again.");
                i--; // Retry the same friend's input
                continue;
            }

            Console.Write($"{names[i]}'s height (in cm): ");
            bool validHeightInput = double.TryParse(Console.ReadLine(), out heights[i]);
            if (!validHeightInput || heights[i] < 0)
            {
                Console.WriteLine("Invalid input. Height must be a non-negative number. Try again.");
                i--; // Retry the same friend's input
                continue;
            }
        }

        // Finding the youngest and tallest friends
        string youngest = FindYoungest(names, ages);
        string tallest = FindTallest(names, heights);

        // Displaying the results
        Console.WriteLine($"\nThe youngest friend is {youngest}.");
        Console.WriteLine($"The tallest friend is {tallest}.");
    }
}
