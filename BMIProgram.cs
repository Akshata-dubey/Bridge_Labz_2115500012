using System;

class BMIProgram
{
    static void Main()
    {
        Console.Write("Enter the number of persons: ");
        int numberOfPersons;

        // Validate user input
        while (!int.TryParse(Console.ReadLine(), out numberOfPersons) || numberOfPersons <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }

        // Arrays to store weight, height, BMI, and weight status
        double[] weights = new double[numberOfPersons];
        double[] heights = new double[numberOfPersons];
        double[] bmis = new double[numberOfPersons];
        string[] weightStatuses = new string[numberOfPersons];

        // Input height and weight for each person
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine($"\nPerson {i + 1}:");

            // Input weight
            while (true)
            {
                Console.Write("Enter weight (kg): ");
                if (double.TryParse(Console.ReadLine(), out double weight) && weight > 0)
                {
                    weights[i] = weight;
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }

            // Input height
            while (true)
            {
                Console.Write("Enter height (m): ");
                if (double.TryParse(Console.ReadLine(), out double height) && height > 0)
                {
                    heights[i] = height;
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }

        // Calculate BMI and determine weight status
        for (int i = 0; i < numberOfPersons; i++)
        {
            bmis[i] = weights[i] / (heights[i] * heights[i]); // BMI formula

            // Determine weight status
            if (bmis[i] < 18.5)
                weightStatuses[i] = "Underweight";
            else if (bmis[i] < 24.9)
                weightStatuses[i] = "Normal weight";
            else if (bmis[i] < 29.9)
                weightStatuses[i] = "Overweight";
            else
                weightStatuses[i] = "Obese";
        }

        // Display results
        Console.WriteLine("\nResults:");
        Console.WriteLine("Person\tHeight (m)\tWeight (kg)\tBMI\t\tStatus");
        Console.WriteLine("------------------------------------------------------------");

        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine($"{i + 1}\t{heights[i]:0.00}\t\t{weights[i]:0.00}\t\t{bmis[i]:0.00}\t\t{weightStatuses[i]}");
        }
    }
}
