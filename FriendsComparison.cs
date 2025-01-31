using System;

class FriendsComparison
{
    static void Main()
    {
        string[] friends = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        // Input ages and heights
        for (int i = 0; i < friends.Length; i++)
        {
            Console.WriteLine($"Enter details for {friends[i]}:");

            // Input age
            while (true)
            {
                Console.Write("Enter Age: ");
                if (int.TryParse(Console.ReadLine(), out int age) && age > 0)
                {
                    ages[i] = age;
                    break;
                }
                Console.WriteLine("Invalid input. Age must be a positive number. Please try again.");
            }

            // Input height
            while (true)
            {
                Console.Write("Enter Height (in cm): ");
                if (double.TryParse(Console.ReadLine(), out double height) && height > 0)
                {
                    heights[i] = height;
                    break;
                }
                Console.WriteLine("Invalid input. Height must be a positive number. Please try again.");
            }
        }

        // Find the youngest friend
        int youngestIndex = 0;
        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < ages[youngestIndex])
            {
                youngestIndex = i;
            }
        }

        // Find the tallest friend
        int tallestIndex = 0;
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > heights[tallestIndex])
            {
                tallestIndex = i;
            }
        }

        // Display results
        Console.WriteLine($"\nThe youngest friend is {friends[youngestIndex]} with an age of {ages[youngestIndex]} years.");
        Console.WriteLine($"The tallest friend is {friends[tallestIndex]} with a height of {heights[tallestIndex]} cm.");
    }
}
