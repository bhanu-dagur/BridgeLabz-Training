using System;

class ExceptionPropagation
{
    // static void Method1()
    // {
    //     int x = 10 / 0; //  campile time ArithmeticException
    // }
    static void Method1()
    {
        int a = 10;
        int b = 0;
        int x = a / b;   // Runtime ArithmeticException
    }

    static void Method2()
    {
        Method1();
    }

    static void Main()
    {
        try
        {
            Method2();
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("Handled exception in Main");
        }
    }
}
