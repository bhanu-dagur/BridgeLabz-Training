using System;
class FactorialUsingFor
{
    static void Main()
    {
        Console.WriteLine("Enter the Positive Number");
        int number=int.Parse(Console.ReadLine());

        int fact=1;

        if (number > 0)
        {

            for(int i=1;i<=number;i++)
            {
                fact=fact*i;


            }
            Console.WriteLine("Factorial  of the number is "+ fact);
        }
        else
        {
            Console.WriteLine("Please enter the positive number");
        }
    }
}