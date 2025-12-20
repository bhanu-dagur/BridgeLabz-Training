using System;

class TriangularParkRound
{
    static void Main()
    {
        double side1, side2, side3;
        double perimeter, rounds;
        double totalDistance = 5000; 

        Console.Write("Enter side1 of the triangle (in meters): ");
        side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side2 of the triangle (in meters): ");
        side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side3 of the triangle (in meters): ");
        side3 = Convert.ToDouble(Console.ReadLine());

        perimeter = side1 + side2 + side3;
        rounds = totalDistance / perimeter;

        Console.WriteLine(
            "The total number of rounds the athlete will run is " +
            rounds + " to complete 5 km"
        );
    }
}
