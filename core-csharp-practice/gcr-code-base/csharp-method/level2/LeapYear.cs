using System;
class LeapYear
{
    public static bool IsLeapYear(int year)
    {
        if (year < 1582)
        {
            Console.WriteLine("Please enter th e yeargreater than  1582 .");
            return false;
        }

        // Leap year conditions
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        bool isLeap = IsLeapYear(year);

        if (isLeap)
            Console.WriteLine(year +" is a Leap Year.");
        else
            Console.WriteLine(year +" is not a Leap Year.");
    }
}
