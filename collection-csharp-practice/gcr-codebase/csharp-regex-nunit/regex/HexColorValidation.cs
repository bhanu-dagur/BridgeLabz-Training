using System;
using System.Text.RegularExpressions;

class HexColorValidation
{
    static void Main()
    {
        Console.Write("Enter hex color code: ");
        string color = Console.ReadLine();

        // Regex pattern for hex color
        string pattern = @"^#[0-9A-Fa-f]{6}$";

        if (Regex.IsMatch(color, pattern))
        {
            Console.WriteLine("Valid hex color code");
        }
        else
        {
            Console.WriteLine("Invalid hex color code");
        }
    }
}
