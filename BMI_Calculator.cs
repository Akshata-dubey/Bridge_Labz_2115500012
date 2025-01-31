using System;

public class BMI_Calculator
{
    // Method to calculate BMI for each person and populate the array
    public static void CalculateBMI(double[,] data)
    {
        for (int i = 0; i < 10; i++)
        {
            double weight = data[i, 0]; // weight in kg
            double heightInCm = data[i, 1]; // height in cm
            double heightInM = heightInCm / 100; // converting height to meters

            // BMI formula: weight (kg) / height (m) ^ 2
            double bmi = weight / (heightInM * heightInM);
            data[i, 2] = bmi; // storing the BMI in the third column
        }
    }

    // Method to determine the BMI status for each person
    public static string[] GetBMIStatus(double[,] data)
    {
        string[] status = new string[10];

        for (int i = 0; i < 10; i++)
        {
            double bmi = data[i, 2]; // BMI value

            if (bmi < 18.5)
            {
                status[i] = "Underweight";
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                status[i] = "Normal weight";
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                status[i] = "Overweight";
            }
            else
            {
                status[i] = "Obesity";
            }
        }

        return status;
    }

    public static void Main(string[] args)
    {
        // 2D array to store weight (kg), height (cm), and BMI
        double[,] data = new double[10, 3];

        Console.WriteLine("Enter the weight (kg) and height (cm) for 10 persons:");

        // Taking input for 10 persons
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"\nPerson {i + 1}:\n");

            Console.Write("Weight (in kg): ");
            while (!double.TryParse(Console.ReadLine(), out data[i, 0]) || data[i, 0] <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid weight (positive number).");
                Console.Write("Weight (in kg): ");
            }

            Console.Write("Height (in cm): ");
            while (!double.TryParse(Console.ReadLine(), out data[i, 1]) || data[i, 1] <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid height (positive number).");
                Console.Write("Height (in cm): ");
            }
        }

        // Calculate BMI for each person
        CalculateBMI(data);

        // Get BMI statuses
        string[] statuses = GetBMIStatus(data);

        // Display the result
        Console.WriteLine("\nBMI and Status of Each Person:");
        for (int i = 0; i < 10; i++)
        {
            double weight = data[i, 0];
            double height = data[i, 1];
            double bmi = data[i, 2];
            Console.WriteLine($"\nPerson {i + 1}:");
            Console.WriteLine($"Weight: {weight} kg");
            Console.WriteLine($"Height: {height} cm");
            Console.WriteLine($"BMI: {bmi:F2}");
            Console.WriteLine($"Status: {statuses[i]}");
        }
    }
}
