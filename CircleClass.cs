using System;

class MyCircle  // Renamed from 'Circle' to 'MyCircle' to avoid conflicts
{
    public double Radius { get; set; }

    // Default Constructor
    public MyCircle() : this(1.0) { }

    // Parameterized Constructor
    public MyCircle(double radius)
    {
        Radius = radius;
    }

    // Method to calculate the area of the circle
    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

// Main program to test the MyCircle class
class Program
{
    // static void Main()
    // {
        // // Using the default constructor
        // MyCircle defaultCircle = new MyCircle();
        // Console.WriteLine($"Default Circle - Radius: {defaultCircle.Radius}, Area: {defaultCircle.GetArea()}");

        // // Using the parameterized constructor
        // MyCircle customCircle = new MyCircle(5.0);
        // Console.WriteLine($"Custom Circle - Radius: {customCircle.Radius}, Area: {customCircle.GetArea()}");
    // }
}
