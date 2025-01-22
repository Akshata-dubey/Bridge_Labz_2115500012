using System;

class TripDetails
{
    static void Main()
    {
        // Input: Ask the user for their name
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        // Input: Ask for the starting city
        Console.Write("Enter the name of the starting city: ");
        string fromCity = Console.ReadLine();

        // Input: Ask for the via city
        Console.Write("Enter the name of the via city: ");
        string viaCity = Console.ReadLine();

        // Input: Ask for the final city
        Console.Write("Enter the name of the final city: ");
        string toCity = Console.ReadLine();

        // Input: Distance from the starting city to the via city
        Console.Write("Enter the distance from " + fromCity + " to " + viaCity + " in miles: ");
        double fromToVia = Convert.ToDouble(Console.ReadLine());

        // Input: Distance from the via city to the final city
        Console.Write("Enter the distance from " + viaCity + " to " + toCity + " in miles: ");
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        // Input: Total time taken for the journey
        Console.Write("Enter the total time taken for the journey in hours: ");
        double timeTaken = Convert.ToDouble(Console.ReadLine());

        // Calculations
        double totalDistance = fromToVia + viaToFinalCity; // Total distance
        double averageSpeed = totalDistance / timeTaken;   // Average speed

        // Output the results
        Console.WriteLine("\nThe results of the trip are:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Total distance traveled: " + totalDistance + " miles");
        Console.WriteLine("Average speed: " + averageSpeed + " miles per hour");
    }
}
