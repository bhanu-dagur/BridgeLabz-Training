using System;

class Temperature
{
    static void Main()
    {
        Console.WriteLine("Enter temperature in Celsius:");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = CelsiusToFahrenheit(celsius);
        Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);

        Console.WriteLine("Enter temperature in Fahrenheit:");
        double f = Convert.ToDouble(Console.ReadLine());

        double c = FahrenheitToCelsius(f);
        Console.WriteLine("Temperature in Celsius: " + c);
    }

    static double CelsiusToFahrenheit(double c)
    {
        return (c * 9 / 5) + 32;
    }

    static double FahrenheitToCelsius(double f)
    {
        return (f - 32) * 5 / 9;
    }
}
