using System;

class SpringSeason
{
    static void Main(string[] args)
    {
        // Check if we have two command-line arguments
        if (args.Length == 2)
        {
            // Parse the month and day from the command line arguments
            int month = int.Parse(args[0]);
            int day = int.Parse(args[1]);

            // Check if the given date is within the Spring season (March 20 to June 20)
            if ((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20))
            {
                Console.WriteLine("It's a Spring Season");
            }
            else
            {
                Console.WriteLine("Not a Spring Season");
            }
        }
        else
        {
            Console.WriteLine("Please provide both month and day as command-line arguments.");
        }
    }
}
