using System;

class SumOfNaturalNumber
{
    static void Main()
    {
        int number;
        int sum;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        // Check for natural number (positive integer)
        if (number >= 0)
        {
            sum = number * (number + 1) / 2;

            Console.WriteLine("The sum of " + number +" natural numbers is " + sum);
        }
        else
        {
            Console.WriteLine("The number " + number +" is not a natural number");
        }
    }
}
