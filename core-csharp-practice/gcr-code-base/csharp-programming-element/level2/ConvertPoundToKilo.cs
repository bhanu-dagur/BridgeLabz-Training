using System;

class ConvertPoundToKilo
{
    static void Main()
    {
        double pound, kg;

        Console.Write("Enter weight in pound: ");
        pound = Convert.ToDouble(Console.ReadLine());

        kg = pound / 2.2;  

        Console.WriteLine( "The weight of the person in pounds is " + pounds +" and in kg is " + kg);
    }
}
