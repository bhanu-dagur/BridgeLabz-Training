using System;
class AveragePercentage
{
    public static void Main(String [] args)
    {
        int mathNumber=Convert.ToInt32(Console.ReadLine());
        int chemistryNumber=Convert.ToInt32(Console.ReadLine());
        int physicsNumber=Convert.ToInt32(Console.ReadLine());
        int average=(mathNumber+chemistryNumber+physicsNumber)/3;
        Console.WriteLine("Sam’s average mark in PCM is " + average);

    }
}