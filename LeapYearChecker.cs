using System;

class LeapYearChecker
{
    static void Main(string[] args)
    {
        // Take user input
        Console.Write("Enter a year (>= 1582): ");
        int year;
        bool isValidInput = int.TryParse(Console.ReadLine(), out year);

        // Check if input is valid
        if (!isValidInput || year < 1582)
        {
            Console.WriteLine("Invalid input. Please enter a year greater than or equal to 1582.");
            return;
        }

        // Check if the year is a leap year
        bool isLeap = IsLeapYear(year);

        // Output the result
        if (isLeap)
        {
            Console.WriteLine($"{year} is a Leap Year.");
        }
        else
        {
            Console.WriteLine($"{year} is not a Leap Year.");
        }
    }

    // Method to check if a year is a leap year
    static bool IsLeapYear(int year)
    {
        // Leap year is divisible by 4 and not divisible by 100, unless also divisible by 400
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}
