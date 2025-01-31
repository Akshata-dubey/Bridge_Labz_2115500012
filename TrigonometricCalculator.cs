using System;

public class TrigonometricCalculator
{
    // Method to calculate sine, cosine, and tangent of an angle
    public static double[] CalculateTrigonometricFunctions(double angleInDegrees)
    {
        // Convert angle from degrees to radians
        double angleInRadians = angleInDegrees * (Math.PI / 180.0);

        // Calculate sine, cosine, and tangent
        double sine = Math.Sin(angleInRadians);
        double cosine = Math.Cos(angleInRadians);
        double tangent = Math.Tan(angleInRadians);

        // Return the results in an array
        return new double[] { sine, cosine, tangent };
    }

    public static void Main(string[] args)
    {
        // Take user input for angle in degrees
        Console.Write("Enter the angle in degrees: ");
        double angleInDegrees = double.Parse(Console.ReadLine());

        // Call the method to calculate trigonometric functions
        double[] results = CalculateTrigonometricFunctions(angleInDegrees);

        // Display the results
        Console.WriteLine($"Sine: {results[0]:F4}");
        Console.WriteLine($"Cosine: {results[1]:F4}");
        Console.WriteLine($"Tangent: {results[2]:F4}");
    }
}
