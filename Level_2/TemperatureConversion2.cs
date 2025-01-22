using System;

class TemperatureConversion2
{
    static void Main()
    {
        // Input: Ask the user to enter the temperature in Fahrenheit
        Console.Write("Enter the temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        // Formula to convert Fahrenheit to Celsius
        double celsiusResult = (fahrenheit - 32) * 5 / 9;

        // Output the result
        Console.WriteLine("The " + fahrenheit + " Fahrenheit is " + celsiusResult + " Celsius.");
    }
}
