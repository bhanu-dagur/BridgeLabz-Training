using System;

class FeetToYardMiles
{
    static void Main()
    {
        double distanceInFeet;
        double yards, miles;

        Console.Write("Enter distance in feet: ");
        distanceInFeet = Convert.ToDouble(Console.ReadLine());

        // 1 yard = 3 feet
        yards = distanceInFeet / 3;

        // 1 mile = 1760 yards
        miles = yards / 1760;

        Console.WriteLine("The distance in yards is " + yards +
                          " and in miles is " + miles);
    }
}
