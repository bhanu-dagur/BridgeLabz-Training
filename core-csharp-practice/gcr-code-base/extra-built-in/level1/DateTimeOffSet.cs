using System;

class DateTimeOffSet
{
    static void Main()
    {
        DateTimeOffset utcTime = DateTimeOffset.UtcNow;

        Console.WriteLine("GMT Time : " + utcTime);

        TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcTime, istZone);
        Console.WriteLine("IST Time : " + istTime);

        TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcTime, pstZone);
        Console.WriteLine("PST Time : " + pstTime);
    }
}
