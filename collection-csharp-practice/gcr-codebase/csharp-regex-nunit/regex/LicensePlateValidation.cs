using System;
using System.Text.RegularExpressions;

class LicensePlateValidation
{
    static void Main()
    {
        Console.Write("Enter license plate number: ");
        string plate = Console.ReadLine();

        // Regex pattern for license plate
        string pattern = @"^[A-Z]{2}[0-9]{4}$";

        if (Regex.IsMatch(plate, pattern))
        {
            Console.WriteLine("Valid license plate number");
        }
        else
        {
            Console.WriteLine("Invalid license plate number");
        }
    }
}
