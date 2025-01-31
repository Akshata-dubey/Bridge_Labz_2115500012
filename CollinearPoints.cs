using System;

class CollinearPoints
{
    // Method to check if three points are collinear using the slope formula
    public static bool AreCollinearUsingSlope(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        // Calculate the slope of AB and BC
        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);

        // Check if the slopes are equal, indicating collinearity
        return slopeAB == slopeBC;
    }

    // Method to check if three points are collinear using the area of the triangle formula
    public static bool AreCollinearUsingArea(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        // Calculate the area of the triangle formed by the three points
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));

        // Points are collinear if the area is 0
        return area == 0;
    }

    static void Main()
    {
        // Take inputs for the three points
        Console.Write("Enter x1: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("Enter y1: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("Enter x2: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("Enter y2: ");
        double y2 = double.Parse(Console.ReadLine());

        Console.Write("Enter x3: ");
        double x3 = double.Parse(Console.ReadLine());
        Console.Write("Enter y3: ");
        double y3 = double.Parse(Console.ReadLine());

        // Check if the points are collinear using the slope formula
        if (AreCollinearUsingSlope(x1, y1, x2, y2, x3, y3))
        {
            Console.WriteLine("The points are collinear using the slope formula.");
        }
        else
        {
            Console.WriteLine("The points are not collinear using the slope formula.");
        }

        // Check if the points are collinear using the area formula
        if (AreCollinearUsingArea(x1, y1, x2, y2, x3, y3))
        {
            Console.WriteLine("The points are collinear using the area formula.");
        }
        else
        {
            Console.WriteLine("The points are not collinear using the area formula.");
        }
    }
}
