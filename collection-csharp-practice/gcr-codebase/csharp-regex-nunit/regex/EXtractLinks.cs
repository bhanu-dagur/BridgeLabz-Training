using System;
using System.Text.RegularExpressions;

class ExtractLinks
{
    static void Main()
    {
        string text = "Visit https://www.google.com and http://example.org for more info.";
        foreach (Match m in Regex.Matches(text, @"https?://[^\s]+"))
        {
            Console.WriteLine(m.Value);
        }
    }
}
