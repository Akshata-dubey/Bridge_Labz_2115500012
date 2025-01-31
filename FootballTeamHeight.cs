using System;

class FootballTeamHeight
{
    static void Main()
    {
        // Define an array to store the heights of the players (11 players)
        double[] heights = new double[11];
        double sum = 0.0;  // Variable to store the sum of heights

        // Take input for the heights of all 11 players
        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write("Enter the height of player " + (i + 1) + ": ");
            heights[i] = double.Parse(Console.ReadLine());
        }

        // Calculate the sum of all heights
        for (int i = 0; i < heights.Length; i++)
        {
            sum += heights[i];
        }

        // Calculate the mean height
        double meanHeight = sum / heights.Length;

        // Display the mean height
        Console.WriteLine("\nThe mean height of the football team is: " + meanHeight);
    }
}
