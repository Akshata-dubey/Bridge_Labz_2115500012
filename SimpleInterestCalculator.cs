using System;

public class SimpleInterestCalculator
{
    // Method to calculate Simple Interest
    public static double CalculateSimpleInterest(double principal, double rate, double time)
    {
        return (principal * rate * time) / 100;
    }

    public static void Main(string[] args)
    {
        // Taking user input for Principal, Rate, and Time
        Console.Write("Enter the Principal amount: ");
        double principal = double.Parse(Console.ReadLine());

        Console.Write("Enter the Rate of Interest: ");
        double rate = double.Parse(Console.ReadLine());

        Console.Write("Enter the Time (in years): ");
        double time = double.Parse(Console.ReadLine());

        // Calculate Simple Interest
        double simpleInterest = CalculateSimpleInterest(principal, rate, time);

        // Output the result
        Console.WriteLine($"\nThe Simple Interest is {simpleInterest} for Principal {principal}, Rate of Interest {rate}, and Time {time} years.");
    }
}
