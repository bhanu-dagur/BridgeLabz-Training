using System;

class CollinearPoints
{
    // Method using slope formula
    public static bool IsCollinearBySlope(
        double x1, double y1,
        double x2, double y2,
        double x3, double y3)
    {
        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);
        double slopeAC = (y3 - y1) / (x3 - x1);

        return slopeAB == slopeBC && slopeBC == slopeAC;
    }

    // Method using area of triangle
    public static bool IsCollinearByArea(
        double x1, double y1,
        double x2, double y2,
        double x3, double y3)
    {
        double area = 0.5 * (
            x1 * (y2 - y3) +
            x2 * (y3 - y1) +
            x3 * (y1 - y2)
        );

        return area == 0;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter x1: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("Enter y1: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("Enter x2: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("Enter y2: ");
        double y2 = double.Parse(Console.ReadLine());

        Console.Write("Enter x3: ");
        double x3 = double.Parse(Console.ReadLine());
        Console.Write("Enter y3: ");
        double y3 = double.Parse(Console.ReadLine());

        bool slopeResult = IsCollinearBySlope(x1, y1, x2, y2, x3, y3);
        bool areaResult = IsCollinearByArea(x1, y1, x2, y2, x3, y3);

        if (slopeResult && areaResult)
            Console.WriteLine("The given points are Collinear");
        else
            Console.WriteLine("The given points are NOT Collinear");
    }
}
