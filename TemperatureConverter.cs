using System;

class TemperatureConverter
{
    static void Main()
    {
        // Get input from the user
        Console.WriteLine("Temperature Converter");
        Console.WriteLine("Choose conversion type:");
        Console.WriteLine("1. Fahrenheit to Celsius");
        Console.WriteLine("2. Celsius to Fahrenheit");
        
        int choice = GetInput("Enter your choice (1 or 2): ");
        
        if (choice == 1)
        {
            // Fahrenheit to Celsius
            double fahrenheit = GetInput("Enter temperature in Fahrenheit: ");
            double celsius = FahrenheitToCelsius(fahrenheit);
            DisplayResult(fahrenheit, celsius, "Fahrenheit", "Celsius");
        }
        else if (choice == 2)
        {
            // Celsius to Fahrenheit
            double celsius = GetInput("Enter temperature in Celsius: ");
            double fahrenheit = CelsiusToFahrenheit(celsius);
            DisplayResult(celsius, fahrenheit, "Celsius", "Fahrenheit");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please enter 1 or 2.");
        }
    }

    // Function to get input from the user
    static double GetInput(string message)
    {
        Console.Write(message);
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out double value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }

    // Function to convert Fahrenheit to Celsius
    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    // Function to convert Celsius to Fahrenheit
    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    // Function to display the result
    static void DisplayResult(double input, double result, string inputUnit, string resultUnit)
    {
        Console.WriteLine($"{input} degrees {inputUnit} is equal to {result} degrees {resultUnit}.");
    }
}
