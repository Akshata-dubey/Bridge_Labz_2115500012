using System;

class GCDAndLCMCalculator
{
    static void Main()
    {
        // Get input from the user
        int num1 = GetInput("Enter the first number: ");
        int num2 = GetInput("Enter the second number: ");
        
        // Calculate the GCD and LCM
        int gcd = CalculateGCD(num1, num2);
        int lcm = CalculateLCM(num1, num2, gcd);
        
        // Display the result
        DisplayResult(gcd, lcm, num1, num2);
    }

    // Function to get input from the user
    static int GetInput(string message)
    {
        Console.Write(message);
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number) && number > 0)
            {
                return number;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid positive integer.");
            }
        }
    }

    // Function to calculate the GCD (Greatest Common Divisor) using Euclidean algorithm
    static int CalculateGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Function to calculate the LCM (Least Common Multiple)
    static int CalculateLCM(int a, int b, int gcd)
    {
        return (a * b) / gcd; // LCM formula: LCM(a, b) = |a * b| / GCD(a, b)
    }

    // Function to display the result
    static void DisplayResult(int gcd, int lcm, int num1, int num2)
    {
        Console.WriteLine("The GCD of " + num1 + " and " + num2 + " is: " + gcd);
        Console.WriteLine("The LCM of " + num1 + " and " + num2 + " is: " + lcm);
    }
}
