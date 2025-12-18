using System;

class Volumeofcylinder
{
    public static void Main()
    {
        double radius, height, volume;

        Console.Write("Enter radius of cylinder: ");
        radius = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height of cylinder: ");
        height = Convert.ToDouble(Console.ReadLine());

        volume = 3.14 * radius * radius * height;

        Console.WriteLine("Volume of Cylinder is: " + volume);
    }
}
