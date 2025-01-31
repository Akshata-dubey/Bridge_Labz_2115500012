using System;

class UnitConverter1
{
    // Convert Fahrenheit to Celsius
    public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    // Convert Celsius to Fahrenheit
    public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    // Convert pounds to kilograms
    public static double ConvertPoundsToKilograms(double pounds)
    {
        double pounds2kilograms = 0.453592;
        return pounds * pounds2kilograms;
    }

    // Convert kilograms to pounds
    public static double ConvertKilogramsToPounds(double kilograms)
    {
        double kilograms2pounds = 2.20462;
        return kilograms * kilograms2pounds;
    }

    // Convert gallons to liters
    public static double ConvertGallonsToLiters(double gallons)
    {
        double gallons2liters = 3.78541;
        return gallons * gallons2liters;
    }

    // Convert liters to gallons
    public static double ConvertLitersToGallons(double liters)
    {
        double liters2gallons = 0.264172;
        return liters * liters2gallons;
    }

    static void Main(string[] args)
    {
        // Test the UnitConverter class

        // Convert Fahrenheit to Celsius
        double fahrenheit = 100.0;
        Console.WriteLine($"{fahrenheit} °F is {ConvertFahrenheitToCelsius(fahrenheit):F2} °C.");

        // Convert Celsius to Fahrenheit
        double celsius = 37.0;
        Console.WriteLine($"{celsius} °C is {ConvertCelsiusToFahrenheit(celsius):F2} °F.");

        // Convert pounds to kilograms
        double pounds = 150.0;
        Console.WriteLine($"{pounds} pounds is {ConvertPoundsToKilograms(pounds):F2} kilograms.");

        // Convert kilograms to pounds
        double kilograms = 68.0;
        Console.WriteLine($"{kilograms} kilograms is {ConvertKilogramsToPounds(kilograms):F2} pounds.");

        // Convert gallons to liters
        double gallons = 5.0;
        Console.WriteLine($"{gallons} gallons is {ConvertGallonsToLiters(gallons):F2} liters.");

        // Convert liters to gallons
        double liters = 20.0;
        Console.WriteLine($"{liters} liters is {ConvertLitersToGallons(liters):F2} gallons.");
    }
}
