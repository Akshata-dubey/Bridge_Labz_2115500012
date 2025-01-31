using System;

class NumberGuessingGame
{
    static int lowerBound = 1;
    static int upperBound = 100;

    static void Main()
    {
        Console.WriteLine("Think of a number between 1 and 100, and I will try to guess it.");

        while (true)
        {
            int guess = GenerateGuess();
            string feedback = GetFeedback(guess);

            if (feedback == "correct")
            {
                Console.WriteLine("I guessed your number correctly!");
                break;
            }
            else
            {
                AdjustBounds(feedback, guess);
            }
        }
    }

    // Generates a guess based on the current bounds
    static int GenerateGuess()
    {
        Random random = new Random();
        int guess = (lowerBound + upperBound) / 2;
        Console.WriteLine($"Is your number {guess}? (high/low/correct): ");
        return guess;
    }

    // Gets feedback from the user
    static string GetFeedback(int guess)
    {
        string feedback = Console.ReadLine().ToLower();
        while (feedback != "high" && feedback != "low" && feedback != "correct")
        {
            Console.WriteLine("Invalid input. Please respond with 'high', 'low', or 'correct'.");
            feedback = Console.ReadLine().ToLower();
        }
        return feedback;
    }

    // Adjusts the search bounds based on the user's feedback
    static void AdjustBounds(string feedback, int guess)
    {
        if (feedback == "high")
        {
            upperBound = guess - 1; // The number is lower than the guess
        }
        else if (feedback == "low")
        {
            lowerBound = guess + 1; // The number is higher than the guess
        }
    }
}
