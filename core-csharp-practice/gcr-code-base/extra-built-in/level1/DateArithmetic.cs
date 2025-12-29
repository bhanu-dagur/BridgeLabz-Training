using System;

class DateArithmetic
{
    static void Main()
    {
        Console.WriteLine("Enter date (yyyy-mm-dd):");
        DateTime date = DateTime.Parse(Console.ReadLine());

        DateTime result = date.AddDays(7);
        result = result.AddMonths(1);
        result = result.AddYears(2);

        result = result.AddDays(-21);

        Console.WriteLine("Final Date: " + result.ToShortDateString());
    }
}
