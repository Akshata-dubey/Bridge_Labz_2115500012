using System;

class KilometerToMiles
{
    static void Main()
    {
        // Declare a variable to store the distance in kilometers
        double km;

        // Prompt user to enter distance in kilometers
        Console.Write("Enter the distance in kilometers: ");
        
        // Take user input
        km = Convert.ToDouble(Console.ReadLine());

        // Conversion factor from kilometers to miles
        double miles = km / 1.6;

        // Output the result
        Console.WriteLine("The total miles is " + miles.ToString("F2") + " mile for the given " + km + " km");
    }
}
