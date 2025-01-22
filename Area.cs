using System;

class Area
{
    static void Main()
    {
        // Ask the user to input the base of the triangle in inches
        Console.Write("Enter the base of the triangle (in inches): ");
        double baseLength = Convert.ToDouble(Console.ReadLine());

        // Ask the user to input the height of the triangle in inches
        Console.Write("Enter the height of the triangle (in inches): ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Calculate the area of the triangle in square inches
        double areaInches = 0.5 * baseLength * height;

        // Convert the area to square centimeters (1 square inch = 6.4516 square cm)
        double areaCm = areaInches * 6.4516;

        // Display the results
        Console.WriteLine("The area of the triangle is " + areaInches.ToString("F2") + " square inches and " + areaCm.ToString("F2") + " square centimeters.");
    }
}
