using System;
class FactorialUsingWhile
{
    static void Main()
    {
        Console.WriteLine("Enter the Positive Number");
        int number=int.Parse(Console.ReadLine());

        int fact=1;

        if (number > 0)
        {

            while (number > 0)
            {
                fact=fact*number;
                number--;
            }
            Console.WriteLine("Factorial  of the number is "+ fact);
        }
        else
        {
            Console.WriteLine("Please enter the positive number");
        }
    }
}