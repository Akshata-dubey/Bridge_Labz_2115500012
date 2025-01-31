using System;

class CalendarGenerator
{
    // Method to get the name of the month
    public static string GetMonthName(int month)
    {
        string[] months = {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        };
        return months[month - 1];
    }

    // Method to get the number of days in a month, considering leap year for February
    public static int GetNumberOfDaysInMonth(int month, int year)
    {
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        if (month == 2 && IsLeapYear(year))
        {
            return 29; // Leap year, February has 29 days
        }

        return daysInMonth[month - 1];
    }

    // Method to check if a year is a leap year
    public static bool IsLeapYear(int year)
    {
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                    return true;
                else
                    return false;
            }
            else
                return true;
        }
        return false;
    }

    // Method to calculate the first day of the month using the Gregorian calendar algorithm
    public static int GetFirstDayOfMonth(int month, int year)
    {
        int y = year;
        int m = month;

        if (m < 3)
        {
            m += 12;
            y--;
        }

        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (1 + x + 31 * m0 / 12) % 7;

        return d0; // Returns a value from 0 (Sunday) to 6 (Saturday)
    }

    // Method to print the calendar for the given month and year
    public static void PrintCalendar(int month, int year)
    {
        string monthName = GetMonthName(month);
        int daysInMonth = GetNumberOfDaysInMonth(month, year);
        int firstDay = GetFirstDayOfMonth(month, year);

        // Displaying the month and year
        Console.WriteLine($"{monthName} {year}");
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        // Print initial spaces for the first day of the month
        for (int i = 0; i < firstDay; i++)
        {
            Console.Write("    "); // Print spaces for empty days
        }

        // Print the days of the month
        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write($"{day,3} "); // Right-align the day in a width of 3 characters
            if ((firstDay + day) % 7 == 0)
            {
                Console.WriteLine(); // Move to the next line after Saturday
            }
        }

        Console.WriteLine(); // Print an extra line after the calendar
    }

    static void Main()
    {
        // Taking month and year as input from the user
        Console.Write("Enter the month (1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter the year: ");
        int year = int.Parse(Console.ReadLine());

        // Printing the calendar for the given month and year
        PrintCalendar(month, year);
    }
}
