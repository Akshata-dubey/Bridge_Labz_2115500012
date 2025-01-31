using System;

class UnitConverter
{
    // Convert kilometers to miles
    public static double ConvertKmToMiles(double km)
    {
        double km2miles = 0.621371;
        return km * km2miles;
    }

    // Convert miles to kilometers
    public static double ConvertMilesToKm(double miles)
    {
        double miles2km = 1.60934;
        return miles * miles2km;
    }

    // Convert meters to feet
    public static double ConvertMetersToFeet(double meters)
    {
        double meters2feet = 3.28084;
        return meters * meters2feet;
    }

    // Convert feet to meters
    public static double ConvertFeetToMeters(double feet)
    {
        double feet2meters = 0.3048;
        return feet * feet2meters;
    }

    static void Main(string[] args)
    {
        // Test the UnitConverter class

        // Convert kilometers to miles
        double kilometers = 5.0;
        Console.WriteLine($"{kilometers} kilometers is {ConvertKmToMiles(kilometers):F2} miles.");

        // Convert miles to kilometers
        double miles = 3.1;
        Console.WriteLine($"{miles} miles is {ConvertMilesToKm(miles):F2} kilometers.");

        // Convert meters to feet
        double meters = 10.0;
        Console.WriteLine($"{meters} meters is {ConvertMetersToFeet(meters):F2} feet.");

        // Convert feet to meters
        double feet = 16.4;
        Console.WriteLine($"{feet} feet is {ConvertFeetToMeters(feet):F2} meters.");
    }
}
