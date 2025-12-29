using System;

class CompareDate
{
    static void Main()
    {
        Console.WriteLine("Enter first date (yyyy-mm-dd):");
        DateTime date1 = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Enter second date (yyyy-mm-dd):");
        DateTime date2 = DateTime.Parse(Console.ReadLine());

        int result = DateTime.Compare(date1, date2);

        if (result < 0)
        {
            Console.WriteLine("First date is BEFORE second date");
        }
        else if (result > 0)
        {
            Console.WriteLine("First date is AFTER second date");
        }
        else
        {
            Console.WriteLine("Both dates are SAME");
        }
    }
}
