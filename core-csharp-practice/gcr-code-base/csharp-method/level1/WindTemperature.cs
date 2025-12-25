using System;

class WindTemperature
{
    static void Main()
    {
        Console.Write("Enter Temperature in Fahrenheit : ");
        double temp = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Wind Speed in mph: ");
        double windSpeed = Convert.ToDouble(Console.ReadLine());

        double result = FindWindTemp(temp, windSpeed);

        Console.WriteLine("Wind Chill temperature: " + result);
    }

    public static double FindWindTemp(double temp, double windSpeed)
    {
        double windChill = 35.74 + 0.6215 * temp + (0.4275 * temp - 35.75) * Math.Pow(windSpeed, 0.16);

        return windChill;
    }
}
