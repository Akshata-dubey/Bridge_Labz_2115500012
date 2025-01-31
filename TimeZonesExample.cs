using System;

class TimeZonesExample
{
    static void Main()
    {
        // Get the current time in UTC (GMT)
        DateTimeOffset currentUtcTime = DateTimeOffset.UtcNow;
        Console.WriteLine("Current GMT Time: " + currentUtcTime);

        // Get the current time in IST (Indian Standard Time)
        TimeZoneInfo istTimeZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(currentUtcTime, istTimeZone);
        Console.WriteLine("Current IST Time: " + istTime);

        // Get the current time in PST (Pacific Standard Time)
        TimeZoneInfo pstTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(currentUtcTime, pstTimeZone);
        Console.WriteLine("Current PST Time: " + pstTime);
    }
}
