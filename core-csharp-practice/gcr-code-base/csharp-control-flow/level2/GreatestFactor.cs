using System;

class GreatestFactor
{
    static void Main()
    {
        int number;
        int greatestFactor = 1;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        for (int i = number - 1; i >= 1; i--)
        {
            if (number % i == 0)
            {
                greatestFactor = i;
                break;
            }
        }

        Console.WriteLine( "The greatest factor of number: "+ greatestFactor);
    }
}
