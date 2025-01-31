using System;

class BasicCalculator
{
    static void Main()
    {
        // Display options and prompt the user to choose an operation
        Console.WriteLine("Basic Calculator");
        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        int choice = GetInput("Enter your choice (1/2/3/4): ");

        // Get numbers from the user
        double num1 = GetInput("Enter the first number: ");
        double num2 = GetInput("Enter the second number: ");

        // Perform the selected operation
        double result = 0;
        switch (choice)
        {
            case 1:
                result = Add(num1, num2);
                DisplayResult("Addition", result);
                break;
            case 2:
                result = Subtract(num1, num2);
                DisplayResult("Subtraction", result);
                break;
            case 3:
                result = Multiply(num1, num2);
                DisplayResult("Multiplication", result);
                break;
            case 4:
                if (num2 != 0)
                {
                    result = Divide(num1, num2);
                    DisplayResult("Division", result);
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter a valid option (1/2/3/4).");
                break;
        }
    }

    // Function to get input from the user
    static double GetInput(string message)
    {
        Console.Write(message);
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out double value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }

    // Function for addition
    static double Add(double a, double b)
    {
        return a + b;
    }

    // Function for subtraction
    static double Subtract(double a, double b)
    {
        return a - b;
    }

    // Function for multiplication
    static double Multiply(double a, double b)
    {
        return a * b;
    }

    // Function for division
    static double Divide(double a, double b)
    {
        return a / b;
    }

    // Function to display the result
    static void DisplayResult(string operation, double result)
    {
        Console.WriteLine($"The result of {operation} is: {result}");
    }
}
