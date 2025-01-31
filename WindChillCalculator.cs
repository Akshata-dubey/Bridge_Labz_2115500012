using System;

public class WindChillCalculator
{
    // Method to calculate the wind chill temperature
    public static double CalculateWindChill(double temperature, double windSpeed)
    {
        // Applying the wind chill formula
        double windChill = 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);

        return windChill;
    }

    public static void Main(string[] args)
    {
        // Taking user input for temperature and wind speed
        Console.Write("Enter the temperature (in Fahrenheit): ");
        double temperature = double.Parse(Console.ReadLine());

        Console.Write("Enter the wind speed (in miles per hour): ");
        double windSpeed = double.Parse(Console.ReadLine());

        // Call the method to calculate the wind chill
        double windChill = CalculateWindChill(temperature, windSpeed);

        // Display the wind chill temperature
        Console.WriteLine($"The wind chill temperature is: {windChill:F2}°F");
    }
}
