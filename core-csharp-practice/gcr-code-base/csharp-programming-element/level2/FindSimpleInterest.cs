using System;

class Findinterest
{
    static void Main()
    {
        double principal, rate, time, interest;

        Console.Write("Enter Principal amount: ");
        principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate of Interest: ");
        rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time (in years): ");
        time = Convert.ToDouble(Console.ReadLine());

        interest = (principal * rate * time) / 100;

        Console.WriteLine(
            "The Simple Interest is " + interest +
            " for Principal " + principal +
            ", Rate of Interest " + rate +
            " and Time " + time
        );
    }
}
