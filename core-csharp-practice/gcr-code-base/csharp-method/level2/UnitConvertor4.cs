using System;

class UnitConvertor4
{
    static void Main(string[] args)
    {
        Console.Write("Enter kilometers: ");
        double km = double.Parse(Console.ReadLine());
        Console.WriteLine(km + " km = " + ConvertKmToMiles(km) + " miles");

        Console.Write("Enter miles: ");
        double miles = double.Parse(Console.ReadLine());
        Console.WriteLine(miles + " miles = " + ConvertMilesToKm(miles) + " km");

        Console.Write("Enter meters: ");
        double meters = double.Parse(Console.ReadLine());
        Console.WriteLine(meters + " meters = " + ConvertMetersToFeet(meters) + " feet");

        Console.Write("Enter feet: ");
        double feet = double.Parse(Console.ReadLine());
        Console.WriteLine(feet + " feet = " + ConvertFeetToMeters(feet) + " meters");
    }
        // Convert kilometers to miles
    public static double ConvertKmToMiles(double km)
    {
        double kmToMile = 0.621371;
        return km * kmToMile;
    }

    // Convert miles to kilometers
    public static double ConvertMilesToKm(double miles)
    {
        double milesToKm = 1.60934;
        return miles * milesToKm;
    }

    // Convert meters to feet
    public static double ConvertMetersToFeet(double meters)
    {
        double metersToFeet = 3.28084;
        return meters * metersToFeet;
    }

    // Convert feet to meters
    public static double ConvertFeetToMeters(double feet)
    {
        double feetToMeter = 0.3048;
        return feet * feetToMeter;
    }
}
