using System;

class Circle
{
    // Attribute (Field)
    private double radius;

    // Constructor to initialize the radius
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Method to calculate the area of the circle
    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    // Method to calculate the circumference of the circle
    public double CalculateCircumference()
    {
        return 2 * Math.PI * radius;
    }

    // Method to display details
    public void DisplayDetails()
    {
        Console.WriteLine("Radius: " + radius);
        Console.WriteLine("Area: " + CalculateArea());
        Console.WriteLine("Circumference: " + CalculateCircumference());
    }

    static void Main()
    {
        // Taking user input for radius
        Console.Write("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        // Creating Circle object
        Circle circle = new Circle(radius);

        // Displaying the circle details
        Console.WriteLine("\nCircle Details:");
        circle.DisplayDetails();
    }
}
