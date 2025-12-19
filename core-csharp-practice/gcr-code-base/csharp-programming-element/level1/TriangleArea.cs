using System;
class TriangleArea
{
    public static void Main(String[] args)
    {
        double baseCm =Convert.ToDouble(Console.ReadLine());
        double heightCm=Convert.ToDouble(Console.ReadLine());
        double AreaCm=0.5*baseCm*heightCm;
        //1 inches=2.54cm
        double AreaInches=AreaCm/(2.54*2.54);
        Console.WriteLine("Area of triangle in cm is "+ AreaCm + " and in Inches is "+ AreaInches);
    }
}