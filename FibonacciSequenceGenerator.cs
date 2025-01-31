using System;

class FibonacciSequenceGenerator
{
    static void Main()
    {
        // Get the number of terms for the Fibonacci sequence
        int terms = GetInput("Enter the number of terms for the Fibonacci sequence: ");
        
        // Generate and print the Fibonacci sequence
        GenerateFibonacci(terms);
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

    // Function to generate and print the Fibonacci sequence
    static void GenerateFibonacci(int terms)
    {
        int first = 0, second = 1;

        Console.WriteLine("Fibonacci sequence up to " + terms + " terms:");

        // Print the first term
        if (terms >= 1)
        {
            Console.Write(first + " ");
        }

        // Print the second term
        if (terms >= 2)
        {
            Console.Write(second + " ");
        }

        // Calculate and print the remaining terms
        for (int i = 3; i <= terms; i++)
        {
            int nextTerm = first + second;
            Console.Write(nextTerm + " ");
            first = second;
            second = nextTerm;
        }

        Console.WriteLine(); // For newline after the sequence
    }
}
