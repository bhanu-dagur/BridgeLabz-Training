using System;

class CheckNumberPosNeg
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int result = CheckNumber(number);

        if (result == 1)
            Console.WriteLine("The number is Positive");
        else if (result == -1)
            Console.WriteLine("The number is Negative");
        else
            Console.WriteLine("The number is Zero");
    }

    static int CheckNumber(int num)
    {
        if (num > 0)
            return 1;
        else if (num < 0)
            return -1;
        else
            return 0;
    }
}
