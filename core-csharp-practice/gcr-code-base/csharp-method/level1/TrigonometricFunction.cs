using System;

class TrigonometricFunction
{
    public static double[] FindValues(double angle)
    {
        double radian = angle * Math.PI / 180;

        double sin = Math.Sin(radian);
        double cos = Math.Cos(radian);
        double tan = Math.Tan(radian);

        return new double[] { sin, cos, tan};
    }

    static void Main()
    {
        Console.Write("Enter angle in degrees: ");
        double angle = Convert.ToDouble(Console.ReadLine());

        double[] result = FindValues(angle);

        Console.WriteLine("Sine: " + result[0]);
        Console.WriteLine("Cosine: " + result[1]);
        Console.WriteLine("Tangent: " + result[2]);
    }
}
