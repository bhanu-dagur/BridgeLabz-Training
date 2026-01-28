using System;
using System.Text.RegularExpressions;

class ExtractCurrency
{
    static void Main()
    {
        string text = "The price is $45.99, and the discount is $ 10.50.";
        foreach (Match m in Regex.Matches(text, @"\$?\s?\d+(\.\d{2})?"))
        {
            Console.WriteLine(m.Value);
        }
    }
}
