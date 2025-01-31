using System;

class FactorialCalculator
{
    static void Main()
    {
        // Get input from the user
        int number = GetInput("Enter a number to calculate its factorial: ");
        
        // Calculate the factorial using recursion
        long factorial = CalculateFactorial(number);
        
        // Display the result
        DisplayResult(factorial, number);
    }

    // Function to get input from the user
    static int GetInput(string message)
    {
        Console.Write(message);
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number) && number >= 0)
            {
                return number;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid non-negative integer.");
            }
        }
    }

    // Function to calculate the factorial using recursion
    static long CalculateFactorial(int number)
    {
        // Base case: factorial of 0 or 1 is 1
        if (number == 0 || number == 1)
        {
            return 1;
        }

        // Recursive case: n! = n * (n-1)!
        return number * CalculateFactorial(number - 1);
    }

    // Function to display the result
    static void DisplayResult(long factorial, int number)
    {
        Console.WriteLine("The factorial of " + number + " is: " + factorial);
    }
}
