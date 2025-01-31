using System;

public class QuadraticSolver
{
    // Method to calculate the roots of the quadratic equation
    public static double[] FindRoots(double a, double b, double c)
    {
        // Calculate the discriminant (delta)
        double delta = Math.Pow(b, 2) - 4 * a * c;

        // Case 1: Delta is positive (two real roots)
        if (delta > 0)
        {
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return new double[] { root1, root2 };
        }
        // Case 2: Delta is zero (one real root)
        else if (delta == 0)
        {
            double root = -b / (2 * a);
            return new double[] { root };
        }
        // Case 3: Delta is negative (no real roots)
        else
        {
            return new double[] { };
        }
    }

    public static void Main(string[] args)
    {
        // Take input for a, b, and c
        Console.Write("Enter the value for a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter the value for b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter the value for c: ");
        double c = double.Parse(Console.ReadLine());

        // Call the method to find the roots
        double[] roots = FindRoots(a, b, c);

        // Display the results
        if (roots.Length == 2)
        {
            Console.WriteLine($"The roots of the quadratic equation are: {roots[0]} and {roots[1]}");
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine($"The root of the quadratic equation is: {roots[0]}");
        }
        else
        {
            Console.WriteLine("The quadratic equation has no real roots.");
        }
    }
}
