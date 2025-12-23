using System;

class PowerCalculatorUsingFor
{
    static void Main()
    {
        int number, power;
        int result = 1;

        Console.Write("Enter the number: ");
        number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the power: ");
        power = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= power; i++)
        {
            result = result * number;
        }

        Console.WriteLine(result);
    }
}
