using System;
using System.Text.RegularExpressions;

class UsernameValidation
{
    static void Main()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        // Regex pattern
        string pattern = @"^[a-zA-Z][a-zA-Z0-9_]{4,14}$";

        // Match the pattern
        if (Regex.IsMatch(username, pattern))
        {
            Console.WriteLine("Valid username");
        }
        else
        {
            Console.WriteLine("Invalid username");
        }
    }
}
