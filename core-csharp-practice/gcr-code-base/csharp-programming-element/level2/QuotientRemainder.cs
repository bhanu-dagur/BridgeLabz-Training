using System;

class Quotientremainder
{
    static void Main()
    {
        int num1, num2;
        int quotient, remainder;

        Console.Write("Enter first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        quotient = num1 / num2;   // division
        remainder = num1 % num2;  // modulus

        Console.WriteLine(
            "The Quotient is " + quotient +
            " and Remainder is " + remainder +
            " of two numbers " + num1 +
            " and " + num2);
    }
}
