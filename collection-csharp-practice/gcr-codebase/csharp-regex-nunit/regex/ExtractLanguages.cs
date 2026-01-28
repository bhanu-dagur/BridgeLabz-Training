using System;
using System.Text.RegularExpressions;

class ExtractLanguages
{
    static void Main()
    {
        string text = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
        foreach (Match m in Regex.Matches(text, @"JavaScript|Java|Python|Go"))
        {
            Console.WriteLine(m.Value);
        }
    }
}
