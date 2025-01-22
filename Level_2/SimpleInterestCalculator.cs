using System;

class SimpleInterestCalculator
{
    static void Main()
    {
        // Input: Get the principal amount
        Console.Write("Enter the Principal amount (INR): ");
        double principal = Convert.ToDouble(Console.ReadLine());

        // Input: Get the rate of interest
        Console.Write("Enter the Rate of Interest (%): ");
        double rate = Convert.ToDouble(Console.ReadLine());

        // Input: Get the time in years
        Console.Write("Enter the Time (in years): ");
        double time = Convert.ToDouble(Console.ReadLine());

        // Calculate the Simple Interest
        double simpleInterest = (principal * rate * time) / 100;

        // Output the result
        Console.WriteLine("The Simple Interest is INR " + simpleInterest + 
                          " for Principal INR " + principal + 
                          ", Rate of Interest " + rate + "%, and Time " + time + " years.");
    }
}
