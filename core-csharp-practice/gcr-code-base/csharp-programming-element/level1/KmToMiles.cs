using System;

class KmToMiles
{
    static void Main()
    {
        double km;
        double miles;

        Console.Write("Enter distance in kilometers: ");
        km = Convert.ToDouble(Console.ReadLine());

        // 1 km=1.6
        miles = km / 1.6;

        Console.WriteLine("The total miles is " + miles + " mile for the given " + km + " km");
    }
}
