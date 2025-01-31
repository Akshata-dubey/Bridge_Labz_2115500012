using System;

class BMICalculator
{
    static void Main()
    {
        // Prompt the user to input weight and height
        Console.Write("Enter your weight in kilograms (kg): ");
        double weight = double.Parse(Console.ReadLine());

        Console.Write("Enter your height in centimeters (cm): ");
        double heightInCm = double.Parse(Console.ReadLine());

        // Convert height from cm to meters
        double heightInMeters = heightInCm / 100;

        // Calculate BMI
        double bmi = weight / (heightInMeters * heightInMeters);

        // Display the calculated BMI
        Console.WriteLine($"Your BMI is: {bmi:F2}");

        // Determine the weight status based on BMI
        if (bmi < 18.5)
        {
            Console.WriteLine("Weight Status: Underweight");
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            Console.WriteLine("Weight Status: Normal weight");
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            Console.WriteLine("Weight Status: Overweight");
        }
        else
        {
            Console.WriteLine("Weight Status: Obesity");
        }
    }
}
