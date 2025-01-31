using System;

class PrimeNumberCheck
{
    static void Main()
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Prime numbers are greater than 1
        if (number <= 1)
        {
            Console.WriteLine(number + " is not a prime number.");
            return;
        }

        // Boolean variable to store the result
        bool isPrime = true;

        // Loop to check divisors
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false; // Number is divisible by 'i', so it's not prime
                break;
            }
        }

        // Output the result
        if (isPrime)
        {
            Console.WriteLine(number + " is a prime number.");
        }
        else
        {
            Console.WriteLine(number + " is not a prime number.");
        }
    }
}
