using System;

class Perimeter
{
    static void Main()
    {
        // Ask the user to input the perimeter of the square
        Console.Write("Enter the perimeter of the square: ");
        double perimeter = Convert.ToDouble(Console.ReadLine());

        // Calculate the side length of the square
        double side = perimeter / 4;

        // Display the result
        Console.WriteLine("The length of the side is " + side.ToString("F2") + " whose perimeter is " + perimeter.ToString("F2"));
    }
}
