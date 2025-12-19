using System;
class ConvertDistance
{
    public static void Main(string[] args)
    {
        double km=Convert.ToDouble(Console.ReadLine());
        double miles=km*1.6;
        Console.WriteLine("The distance" + km +"km in miles is "+ miles);
    }
}