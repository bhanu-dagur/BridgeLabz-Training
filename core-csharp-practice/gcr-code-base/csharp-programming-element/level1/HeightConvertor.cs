using System;
using System.IO.Compression;
class HeightConvertor
{
    public static void Main(String[] args)
    {
        double heightCm=Convert.ToDouble(Console.ReadLine());
        // 1 foot = 12 inches and 1 inch = 2.54 cm
        double heightInches=heightCm/2.25;
        double heightFeet=heightCm/(12*2.54);
        Console.WriteLine("Your height in cm is "+ heightCm + 
        " and in inches is "+ heightInches+ " and height in feet is "+ heightFeet);

    }
}