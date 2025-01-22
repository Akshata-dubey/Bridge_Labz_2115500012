using System;

class Volume
{
    static void Main()
    {
        // Radius of Earth in kilometers
        double radiusKm = 6378;

        // Volume of a sphere formula: (4/3) * pi * r^3
        double volumeKm3 = (4.0 / 3.0) * Math.PI * Math.Pow(radiusKm, 3);

        // Conversion factor from cubic kilometers to cubic miles
        double kmToMilesCubed = 0.621371 * 0.621371 * 0.621371; // (1 km)^3 in miles^3

        // Volume in cubic miles
        double volumeMiles3 = volumeKm3 * kmToMilesCubed;

        // Output the result
        Console.WriteLine("The volume of earth in cubic kilometers is " + volumeKm3.ToString("F2") + " and cubic miles is " + volumeMiles3.ToString("F2"));
    }
}
