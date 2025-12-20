using System;

class SwapTwoNumber
{
    static void Main()
    {
        int num1, num2, temp;

        Console.Write("Enter first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        temp = num1;
        num1 = num2;
        num2 = temp;

        Console.WriteLine("The swapped numbers are " + num1 + " and " + num2);
    }
}
