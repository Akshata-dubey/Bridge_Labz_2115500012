using System;

class PrimeNumberChecker
{
    static void Main()
    {
        // Get the number from the user
        int number = GetInput("Enter a number to check if it's prime: ");
        
        // Check if the number is prime
        bool isPrime = IsPrime(number);
        
        // Display the result
        if (isPrime)
        {
            Console.WriteLine(number + " is a prime number.");
        }
        else
        {
            Console.WriteLine(number + " is not a prime number.");
        }
    }

    // Function to get input from the user
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

    // Function to check if a number is prime
    static bool IsPrime(int number)
    {
        // Handle numbers less than 2 (they are not prime)
        if (number <= 1)
        {
            return false;
        }

        // Check divisibility from 2 to the square root of the number
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                return false; // Number is divisible by i, so it's not prime
            }
        }

        return true; // Number is prime if no divisors were found
    }
}
