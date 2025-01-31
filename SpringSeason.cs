using System;

public class SpringSeason
{
    // Method to check if the date falls within the Spring season
    public static bool IsSpringSeason(int month, int day)
    {
        // Spring season starts from March 20 and ends on June 20
        if ((month == 3 && day >= 20) || 
            (month == 4) || 
            (month == 5) || 
            (month == 6 && day <= 20))
        {
            return true; // Return true if the date is in Spring season
        }
        else
        {
            return false; // Return false if the date is not in Spring season
        }
    }

    public static void Main(string[] args)
    {
        // Take month and day as input from the command line arguments
        if (args.Length < 2)
        {
            Console.WriteLine("Please provide both month and day as command line arguments.");
            return;
        }

        // Parse the month and day from the arguments
        int month = int.Parse(args[0]);
        int day = int.Parse(args[1]);

        // Check if the date is within the Spring season
        bool isSpring = IsSpringSeason(month, day);

        // Print the result based on the season check
        if (isSpring)
        {
            Console.WriteLine("It's a Spring Season.");
        }
        else
        {
            Console.WriteLine("Not a Spring Season.");
        }
    }
}
