using System;

class EuclideanDistance
{
    // Method to find Euclidean distance
    public static double FindDistance(double x1, double y1, double x2, double y2)
    {
        double distance = Math.Sqrt(
            Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)
        );
        return distance;
    }

    // Returns array where index 0 = slope (m), index 1 = intercept (b)
    public static double[] FindLineEquation(double x1, double y1, double x2, double y2)
    {
        double[] result = new double[2];

        double m = (y2 - y1) / (x2 - x1);   
        double b = y1 - (m * x1);          

        result[0] = m;
        result[1] = b;

        return result;
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

        double distance = FindDistance(x1, y1, x2, y2);
        double[] line = FindLineEquation(x1, y1, x2, y2);

        Console.WriteLine("Euclidean Distance = " + distance);
        Console.WriteLine("Slope (m) = " + line[0]);
        Console.WriteLine("Y-Intercept (b) = " + line[1]);
        Console.WriteLine("Equation of line: y = " + line[0] + "x + " + line[1]);
    }
}
