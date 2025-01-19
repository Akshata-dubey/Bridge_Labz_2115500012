Q3. Write a program that takes the temperature in Celsius as input and converts
it to Fahrenheit using the formula:
Ans) 	
using System;
class CelsiusToFahrenheit
{
    static void Main(string[] args)
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");
    }
}
