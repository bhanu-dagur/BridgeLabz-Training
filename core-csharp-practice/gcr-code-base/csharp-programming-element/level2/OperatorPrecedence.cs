using System;

class OperatorPrecedence
{
    static void Main()
    {
        string name, fromCity, viaCity, toCity;
        double fromToVia, viaToFinalCity, totalDistance, timeTaken, averageSpeed;

        Console.Write("Enter your name: ");
        name = Console.ReadLine();

        Console.Write("Enter starting city: ");
        fromCity = Console.ReadLine();

        Console.Write("Enter via city: ");
        viaCity = Console.ReadLine();

        Console.Write("Enter destination city: ");
        toCity = Console.ReadLine();

        Console.Write("Enter distance from start city to via city (miles): ");
        fromToVia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter distance from via city to destination city (miles): ");
        viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter time taken for the journey (hours): ");
        timeTaken = Convert.ToDouble(Console.ReadLine());

        totalDistance = fromToVia + viaToFinalCity;
        averageSpeed = totalDistance / timeTaken;

        Console.WriteLine(
            "The results of the trip are: " +
            totalDistance + " miles, " + timeTaken + " hours, and " + averageSpeed + " miles/hour"
        );
    }
}
