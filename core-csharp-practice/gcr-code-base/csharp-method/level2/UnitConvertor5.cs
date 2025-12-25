using System;

class UnitConvertor5
{
    static void Main(string[] args)
    {
        Console.Write("Enter yards: ");
        double yards = double.Parse(Console.ReadLine());
        Console.WriteLine(yards + " yards = " + ConvertYardsToFeet(yards) + " feet");

        Console.Write("Enter feet: ");
        double feet = double.Parse(Console.ReadLine());
        Console.WriteLine(feet + " feet = " + ConvertFeetToYards(feet) + " yards");

        Console.Write("Enter meters: ");
        double meters = double.Parse(Console.ReadLine());
        Console.WriteLine(meters + " meters = " + ConvertMetersToInches(meters) + " inches");

        Console.Write("Enter inches: ");
        double inches = double.Parse(Console.ReadLine());
        Console.WriteLine(inches + " inches = " + ConvertInchesToMeters(inches) + " meters");
        Console.WriteLine(inches + " inches = " + ConvertInchesToCentimeters(inches) + " centimeters");
    }
        public static double ConvertYardsToFeet(double yards)
    {
        double yardsToFeet = 3;
        return yards * yardsToFeet;
    }

    // Convert feet to yards
    public static double ConvertFeetToYards(double feet)
    {
        double feetToYards = 0.333333;
        return feet * feetToYards;
    }

    // Convert meters to inches
    public static double ConvertMetersToInches(double meters)
    {
        double metersToInches = 39.3701;
        return meters * metersToInches;
    }

    // Convert inches to meters
    public static double ConvertInchesToMeters(double inches)
    {
        double inchesToMeters = 0.0254;
        return inches * inchesToMeters;
    }

    // Convert inches to centimeters
    public static double ConvertInchesToCentimeters(double inches)
    {
        double inchesToCm = 2.54;
        return inches * inchesToCm;
    }
}
