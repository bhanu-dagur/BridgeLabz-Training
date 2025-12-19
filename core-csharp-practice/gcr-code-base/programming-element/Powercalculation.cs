using System;
class PowerCalculation
{
    static void Main()
    {
        double baseVal, power,result;

        Console.Write("Enter baseVal number: ");
        baseVal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter power: ");
        power = Convert.ToDouble(Console.ReadLine());

        result = Math.Pow(baseVal, power);

        Console.WriteLine("Result = " + result);
    }
}
