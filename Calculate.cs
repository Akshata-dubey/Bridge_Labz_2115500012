using System;

class Calculate
{
    static void Main()
    {
        // Declare variables for the two numbers
        double number1, number2;

        // Ask the user to input the first number
        Console.Write("Enter the first number: ");
        number1 = Convert.ToDouble(Console.ReadLine());

        // Ask the user to input the second number
        Console.Write("Enter the second number: ");
        number2 = Convert.ToDouble(Console.ReadLine());

        // Perform the arithmetic operations
        double addition = number1 + number2;
        double subtraction = number1 - number2;
        double multiplication = number1 * number2;
        double division = number1 / number2;

        // Display the results of all operations
        Console.WriteLine("The addition, subtraction, multiplication, and division values of " + 
                          "the two numbers " + number1 + " and " + number2 + " are " + 
                          addition + ", " + subtraction + ", " + multiplication + ", and " + division);
    }
}
