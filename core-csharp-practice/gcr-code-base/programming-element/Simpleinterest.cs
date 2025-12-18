using System;

class Simpleinterest
{
    public static void Main()
    {
        double principle, rate, time,interest;

        Console.Write("Enter principle of interest: ");
        principle = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter rate of interest: ");
        rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter timetaken: ");
        time = Convert.ToDouble(Console.ReadLine());

        interest= (principle * rate * time)/100;

        Console.WriteLine("Simple interest is : " + interest);
    }
}
