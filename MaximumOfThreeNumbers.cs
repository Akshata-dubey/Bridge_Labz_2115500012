using System;

class MaximumOfThreeNumbers
{
    static void Main()
    {
        // Get three integer inputs from the user
        int num1 = GetInput("Enter the first number: ");
        int num2 = GetInput("Enter the second number: ");
        int num3 = GetInput("Enter the third number: ");

        // Find the maximum of the three numbers
        int max = FindMaximum(num1, num2, num3);

        // Display the result
        Console.WriteLine("The maximum value is: " + max);
    }

    // Function to get an integer input from the user
    static int GetInput(string message)
    {
        Console.Write(message);
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }

    // Function to find the maximum of three numbers
    static int FindMaximum(int num1, int num2, int num3)
    {
        int max = num1;

        if (num2 > max)
        {
            max = num2;
        }

        if (num3 > max)
        {
            max = num3;
        }

        return max;
    }
}
