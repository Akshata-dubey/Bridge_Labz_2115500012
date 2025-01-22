using System;

class YardsAndMile
{
    static void Main()
    {
        // Ask the user to input the distance in feet
        Console.Write("Enter the distance in feet: ");
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());

        // Convert the distance to yards (1 yard = 3 feet)
        double distanceInYards = distanceInFeet / 3;

        // Convert the distance to miles (1 mile = 1760 yards)
        double distanceInMiles = distanceInYards / 1760;

        // Display the results
        Console.WriteLine("The distance of " + distanceInFeet + " feet is " + 
                          distanceInYards.ToString("F2") + " yards and " + 
                          distanceInMiles.ToString("F2") + " miles.");
    }
}
