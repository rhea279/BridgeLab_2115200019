using System;
class TimeZones
{
    static void Main()
    {
        // Get the current UTC time
        DateTimeOffset utcTime = DateTimeOffset.UtcNow;

        // Define different time zones
        TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

        // Convert time to different time zones
        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcTime, istZone);
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcTime, pstZone);

        // Display results
        Console.WriteLine($"GMT (UTC) Time: {utcTime:yyyy-MM-dd HH:mm:ss}");
        Console.WriteLine($"IST (Indian Standard Time): {istTime:yyyy-MM-dd HH:mm:ss}");
        Console.WriteLine($"PST (Pacific Standard Time): {pstTime:yyyy-MM-dd HH:mm:ss}");
    }
}
