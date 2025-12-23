using System;

class CountNumberOfDigit
{
    static void Main()
    {
        int number;
        int count = 0;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number == 0)
        {
            count = 1;
        }
        else
        {
            while (number != 0)
            {
                number = number / 10; 
                count++;
            }
        }

        Console.WriteLine("Number of digits = " + count);
    }
}
