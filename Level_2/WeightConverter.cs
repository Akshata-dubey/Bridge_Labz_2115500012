using System;

class WeightConverter
{
    static void Main()
    {
        // Input: Get the weight in pounds
        Console.Write("Enter the weight (in pounds): ");
        double weightInPounds = Convert.ToDouble(Console.ReadLine());

        // Convert pounds to kilograms
        double weightInKg = weightInPounds / 2.2;

        // Output the result
        Console.WriteLine("The weight of the person in pounds is " + weightInPounds + 
                          " and in kilograms is " + weightInKg.ToString("F2") + ".");
    }
}
