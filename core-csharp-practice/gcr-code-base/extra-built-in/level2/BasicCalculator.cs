using System;

class BasicCalculator
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Choose operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
            Console.WriteLine("Result: " + Add(num1, num2));
        else if (choice == 2)
            Console.WriteLine("Result: " + Subtract(num1, num2));
        else if (choice == 3)
            Console.WriteLine("Result: " + Multiply(num1, num2));
        else if (choice == 4)
            Console.WriteLine("Result: " + Divide(num1, num2));
        else
            Console.WriteLine("Invalid Choice");
    }

    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Subtract(int a, int b)
    {
        return a - b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static int Divide(int a, int b)
    {
        return a / b;
    }
}
