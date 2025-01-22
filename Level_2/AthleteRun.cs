using System;

class AthleteRun
{
    static void Main()
    {
        // Input: Take the lengths of the sides of the triangular park
        Console.Write("Enter the length of side 1 in meters: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 2 in meters: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 3 in meters: ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        // Calculate the perimeter of the triangular park
        double perimeter = side1 + side2 + side3;

        // Convert the distance to complete (5 km) to meters
        double distanceToComplete = 5000; // 5 km = 5000 meters

        // Calculate the total number of rounds needed
        double rounds = distanceToComplete / perimeter;

        // Output the result (rounding up to the nearest whole number)
        Console.WriteLine("The total number of rounds the athlete will run is " + Math.Ceiling(rounds) + " to complete 5 km.");
    }
}
