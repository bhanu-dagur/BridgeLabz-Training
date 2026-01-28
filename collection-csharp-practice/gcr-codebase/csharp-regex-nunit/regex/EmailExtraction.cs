using System;
using System.Text.RegularExpressions;

class EmailExtraction
{
    static void Main()
    {
        string text = "Contact us at support@example.com and info@company.org";

        // Regex pattern for email
        string pattern = @"[a-zA-Z0-9._]+@[a-zA-Z]+\.[a-zA-Z]+";

        // Find all matches
        MatchCollection matches = Regex.Matches(text, pattern);

        // Print all emails
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
