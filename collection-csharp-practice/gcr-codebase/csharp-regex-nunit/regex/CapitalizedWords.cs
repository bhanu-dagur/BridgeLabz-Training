using System;
using System.Text.RegularExpressions;

class CapitalizedWords
{
    static void Main()
    {
        string text = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";
        foreach (Match m in Regex.Matches(text, @"\b[A-Z][a-z]*\b"))
        {
            Console.WriteLine(m.Value);
        }
    }
}
