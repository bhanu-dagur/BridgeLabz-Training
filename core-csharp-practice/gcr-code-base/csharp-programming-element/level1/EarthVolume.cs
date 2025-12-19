using System;
class EarthVolume
{
    public static void Main()
    {
        double radiusKm=6378;
        //1km=1.6 miles
        double radiusMiles=1.6*radiusKm;
        double volumeKm=(double)(4.0/3.0)*Math.PI*Math.Pow(radiusKm,3);
        double volumeMiles=(double)(4/3)*Math.PI* Math.Pow(radiusMiles,3);
        Console.WriteLine("The Vol of earth in km is "+volumeKm+ "and in miles is " + volumeMiles);
    }
}