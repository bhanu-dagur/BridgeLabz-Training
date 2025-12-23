using System;
using System.Collections;
using System.Runtime.InteropServices;
class CalculatorProgram
{
    static void Main()
    {
        Console.WriteLine("Enter the First Operend");
        double first=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the second operand");
        double second=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter the Operator");
        String op=Console.ReadLine();

        switch(op)
        {
            case("+"):
            Console.WriteLine("first+second: "+ first+second);
            break;
            case ("-"):
            Console.WriteLine( first-second);
            break;
            case("*"):
            Console.WriteLine("first*second: "+ first*second);
            break;
            case("/"):
            Console.WriteLine("first/second: "+ first/second);
            break;
            default:
            Console.WriteLine("Invalid Operator");
            break;
        }

    }
}