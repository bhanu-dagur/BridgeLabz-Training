using System;

class AthleteTriangularPark
{
    static void Main()
    {
        Console.Write("Enter side 1 (in meters): ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 2 (in meters): ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 3 (in meters): ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        double rounds = FindNoOfRounds(side1, side2, side3);

        Console.WriteLine("The athlete needs to complete " + rounds + " rounds to complete 5 km run.");
    }

    static double FindNoOfRounds(double s1, double s2, double s3)
    {
        double perimeter = s1 + s2 + s3;   // triangle perimeter
        double distance = 5000;             // 5 km = 5000 meters

        return distance / perimeter;
    }
}
