using System;

class TemperatureConversion
{
    static void Main()
    {
        // Input: Ask the user to enter the temperature in Celsius
        Console.Write("Enter the temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        // Formula to convert Celsius to Fahrenheit
        double fahrenheitResult = (celsius * 9 / 5) + 32;

        // Output the result
        Console.WriteLine("The " + celsius + " Celsius is " + fahrenheitResult + " Fahrenheit.");
    }
}
