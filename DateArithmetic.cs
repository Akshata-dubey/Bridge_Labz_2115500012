using System;

class DateArithmetic
{
    static void Main()
    {
        // Input: Accepting a date
        Console.Write("Enter a date (yyyy-mm-dd): ");
        string inputDate = Console.ReadLine();
        
        DateTime parsedDate;
        if (DateTime.TryParse(inputDate, out parsedDate))
        {
            // Add 7 days, 1 month, and 2 years
            DateTime result = parsedDate.AddDays(7);  // Add 7 days
            result = result.AddMonths(1);  // Add 1 month
            result = result.AddYears(2);  // Add 2 years

            // Subtract 3 weeks (3 weeks = 21 days)
            result = result.AddDays(-21);  // Subtract 3 weeks (21 days)

            // Output the final result
            Console.WriteLine("The resulting date is: " + result.ToString("yyyy-MM-dd"));
        }
        else
        {
            Console.WriteLine("Invalid date format. Please enter a valid date.");
        }
    }
}
