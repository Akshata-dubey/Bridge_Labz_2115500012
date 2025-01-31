using System;

class BMIProgram2DArray
{
    static void Main()
    {
        Console.Write("Enter the number of persons: ");
        int numberOfPersons;

        // Validate user input for the number of persons
        while (!int.TryParse(Console.ReadLine(), out numberOfPersons) || numberOfPersons <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }

        // Multi-dimensional array to store weight, height, and BMI
        double[,] personData = new double[numberOfPersons, 3];
        string[] weightStatus = new string[numberOfPersons];

        // Input weight and height for each person
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine($"\nPerson {i + 1}:");

            // Input weight
            while (true)
            {
                Console.Write("Enter weight (kg): ");
                if (double.TryParse(Console.ReadLine(), out double weight) && weight > 0)
                {
                    personData[i, 0] = weight; // Store weight in the first column
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
                    personData[i, 1] = height; // Store height in the second column
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }

        // Calculate BMI and determine weight status
        for (int i = 0; i < numberOfPersons; i++)
        {
            double weight = personData[i, 0];
            double height = personData[i, 1];

            // Calculate BMI and store in the third column
            double bmi = weight / (height * height);
            personData[i, 2] = bmi;

            // Determine weight status
            if (bmi < 18.5)
                weightStatus[i] = "Underweight";
            else if (bmi < 24.9)
                weightStatus[i] = "Normal weight";
            else if (bmi < 29.9)
                weightStatus[i] = "Overweight";
            else
                weightStatus[i] = "Obese";
        }

        // Display results
        Console.WriteLine("\nResults:");
        Console.WriteLine("Person\tHeight (m)\tWeight (kg)\tBMI\t\tStatus");
        Console.WriteLine("------------------------------------------------------------");

        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine($"{i + 1}\t{personData[i, 1]:0.00}\t\t{personData[i, 0]:0.00}\t\t{personData[i, 2]:0.00}\t\t{weightStatus[i]}");
        }
    }
}
