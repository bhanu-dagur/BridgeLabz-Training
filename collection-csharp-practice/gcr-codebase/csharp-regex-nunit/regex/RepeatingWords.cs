using System;
using System.Text.RegularExpressions;

class RepeatingWords
{
    static void Main()
    {
        string text = "This is is a repeated repeated word test.";
        foreach (Match m in Regex.Matches(text, @"\b(\w+)\s+\1\b", RegexOptions.IgnoreCase))
        {
            Console.WriteLine(m.Value);
        }
    }
}
