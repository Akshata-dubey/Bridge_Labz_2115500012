Q5. Write a program to calculate the volume of a cylinder. Take the radius and
height as inputs and use the formula:
Ans 	
using System;
class CylinderVolume
{
    static void Main(string[] args)
    {
        Console.Write("Enter the radius of the cylinder: ");
        double radius = double.Parse(Console.ReadLine());
        Console.Write("Enter the height of the cylinder: ");
        double height = double.Parse(Console.ReadLine());
        double volume = Math.PI * Math.Pow(radius, 2) * height;
        Console.WriteLine($"The volume of the cylinder is: {volume}");
    }
}
