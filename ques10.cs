Q10. Write a program that takes the distance in kilometers as input from the user
and converts it into miles using the formula:
Ans
using System;
class KilometersToMiles
{
    static void Main(string[] args)
    {
        Console.Write("Enter distance in kilometers: ");
        double kilometers = double.Parse(Console.ReadLine());
        double miles = kilometers * 0.621371;
        Console.WriteLine($"{kilometers} kilometers is equal to {miles} miles.");
    }
}
