using System;

class DateComparison
{
    static void Main()
    {
        // Take two date inputs from the user
        Console.Write("Enter the first date (yyyy-mm-dd): ");
        string inputDate1 = Console.ReadLine();

        Console.Write("Enter the second date (yyyy-mm-dd): ");
        string inputDate2 = Console.ReadLine();

        DateTime date1, date2;

        // Try parsing the inputs
        if (DateTime.TryParse(inputDate1, out date1) && DateTime.TryParse(inputDate2, out date2))
        {
            // Compare the two dates
            int comparisonResult = DateTime.Compare(date1, date2);

            // Output the result based on comparison
            if (comparisonResult < 0)
            {
                Console.WriteLine("The first date is before the second date.");
            }
            else if (comparisonResult > 0)
            {
                Console.WriteLine("The first date is after the second date.");
            }
            else
            {
                Console.WriteLine("Both dates are the same.");
            }
        }
        else
        {
            Console.WriteLine("One or both dates are invalid. Please enter valid dates.");
        }
    }
}
