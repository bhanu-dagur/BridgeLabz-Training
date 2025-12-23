using System;

class SumUntilZero
{
    static void Main()
    {
        double total = 0.0;
        double number;

        Console.Write("Enter a number : ");
        number = Convert.ToDouble(Console.ReadLine());

        while (number != 0)
        {
            total = total + number;

            Console.Write("Re enter a number: ");
            number = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("The total sum is: " + total);
    }
}
