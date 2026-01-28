using System;
using System.Text.RegularExpressions;

class ExtractDates
{
    static void Main()
    {
        string text = "The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020.";
        foreach (Match m in Regex.Matches(text, @"\b\d{2}/\d{2}/\d{4}\b"))
        {
            Console.WriteLine(m.Value);
        }
    }
}
