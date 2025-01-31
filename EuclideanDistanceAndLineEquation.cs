using System;

class EuclideanDistanceAndLineEquation
{
    // Method to calculate the Euclidean distance between two points
    public static double CalculateEuclideanDistance(double x1, double y1, double x2, double y2)
    {
        // Formula for Euclidean distance: sqrt((x2 - x1)^2 + (y2 - y1)^2)
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return distance;
    }

    // Method to find the equation of the line given two points (x1, y1) and (x2, y2)
    public static double[] CalculateLineEquation(double x1, double y1, double x2, double y2)
    {
        // Calculate the slope (m) using the formula: m = (y2 - y1) / (x2 - x1)
        double m = (y2 - y1) / (x2 - x1);

        // Calculate the y-intercept (b) using the formula: b = y1 - m * x1
        double b = y1 - m * x1;

        // Return an array containing the slope and y-intercept
        return new double[] { m, b };
    }

    static void Main()
    {
        // Take inputs for two points (x1, y1) and (x2, y2)
        Console.Write("Enter the x-coordinate of the first point (x1): ");
        double x1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the y-coordinate of the first point (y1): ");
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the x-coordinate of the second point (x2): ");
        double x2 = double.Parse(Console.ReadLine());

        Console.Write("Enter the y-coordinate of the second point (y2): ");
        double y2 = double.Parse(Console.ReadLine());

        // Calculate the Euclidean distance
        double distance = CalculateEuclideanDistance(x1, y1, x2, y2);
        Console.WriteLine($"Euclidean Distance between the points: {distance}");

        // Calculate the equation of the line (slope and y-intercept)
        double[] lineEquation = CalculateLineEquation(x1, y1, x2, y2);
        double slope = lineEquation[0];
        double intercept = lineEquation[1];

        // Display the equation of the line
        Console.WriteLine($"Equation of the line: y = {slope}x + {intercept}");
    }
}
