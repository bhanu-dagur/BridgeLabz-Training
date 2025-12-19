using System;

class SquareSide
{
    public static void Main(String []args )
    {
        double perimeter;
        double side;

        Console.Write("Enter the perimeter of the square: ");
        perimeter = Convert.ToDouble(Console.ReadLine());

        // Perimeter = 4 × side
        side = perimeter / 4;

        Console.WriteLine("The length of the side is " + side +
                          " whose perimeter is " + perimeter);
    }
}
