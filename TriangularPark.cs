using System;

public class TriangularPark
{
    // Method to compute the perimeter of the triangle
    public static double CalculatePerimeter(double side1, double side2, double side3)
    {
        return side1 + side2 + side3;
    }

    // Method to compute the number of rounds needed to complete a 5 km run
    public static double CalculateRounds(double perimeter, double totalDistance)
    {
        return totalDistance / perimeter;
    }

    public static void Main(string[] args)
    {
        // Taking input for the three sides of the triangle (in meters)
        Console.Write("Enter the first side of the triangle (in meters): ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the second side of the triangle (in meters): ");
        double side2 = double.Parse(Console.ReadLine());

        Console.Write("Enter the third side of the triangle (in meters): ");
        double side3 = double.Parse(Console.ReadLine());

        // The total distance the athlete wants to run is 5 km (5000 meters)
        double totalDistance = 5000;

        // Calculate the perimeter of the triangle
        double perimeter = CalculatePerimeter(side1, side2, side3);

        // Calculate the number of rounds needed to complete the 5 km run
        double rounds = CalculateRounds(perimeter, totalDistance);

        // Display the result
        Console.WriteLine($"The athlete needs to complete {rounds:F2} rounds to cover 5 km.");
    }
}
