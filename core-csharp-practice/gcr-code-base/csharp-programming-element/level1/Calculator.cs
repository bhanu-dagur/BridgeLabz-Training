using System;

class Calculator
{
    static void Main()
    {
        double num1, num2;
        double add, sub, mul, div;

        Console.Write("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        add = num1 + num2;
        sub = num1 - num2;
        mul = num1 * num2;
        div = num1 / num2;

        Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers "
            + num1 + " and " + num2 + " is "
            + add + ", " + sub + ", " + mul + ", and " + div);
    }
}
