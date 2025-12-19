using System;
class Operator
{
    public static void Main(String [] args)
    {
        ArithmeticOperation(2,3);
        RelationalOperator(2,3);
        LogicalOperator(false,true);
        UnaryOperator(5);
        TernaryOperator(10,12);
        AssignmentOperator(2,3);
        IsOperator();

    }
    static void ArithmeticOperation(int a,int b)
    {
        Console.WriteLine("Addition: " + (a + b)); 
        Console.WriteLine("Subtraction: " + (a - b)); 
        Console.WriteLine("Multiplication: " + (a * b)); 
        Console.WriteLine("Division: " + (a / b)); 
        Console.WriteLine("Modulus: " + (a % b));
    } 
    static void  RelationalOperator(int a,int b)
    {
        Console.WriteLine(" double equal operation of a==b "+ (a==b));
        Console.WriteLine("Not equal operation of a!=b" + (a!=b));
        Console.WriteLine("Greater than operation of a>b" +(a>b));
        Console.WriteLine("Greater than equal to operation of  a>=b" + (a>=b));
        Console.WriteLine("Less than  operation of a<b" +(a<b));
        Console.WriteLine("Less than Equal to operation of a<=b" + (a<=b));
        
    }
    static void LogicalOperator(bool a,bool b)
    {
        Console.WriteLine(" And operation of a && b"+ (a&&b));
        Console.WriteLine("Or operation of a||b"+ (a||b));
        Console.WriteLine("Logical Not operation ofa + " +(!a));
    }
    static void UnaryOperator(int a)
    {
        Console.WriteLine("a: " + a);
        Console.WriteLine("pre-increment operation on a (++a): " + ++a); 
        Console.WriteLine("prost-increment operation on a (a++): " + a++); 
        Console.WriteLine("pre decrement operation on a (--a): " + --a); 
        Console.WriteLine("post decrement operation on a (a--): " + a--); 
        Console.WriteLine("a: " + a); 
    }
    static void AssignmentOperator(int a,int b)
    {
        //Addition assignment
        a += b; 
        Console.WriteLine("a += b: " + a); 

        //Subtraction assignment
        a -= b; 
        Console.WriteLine("a -= b: " + a); 

        //Multiplication assignment
        a *= b; 
        Console.WriteLine("a *= b: " + a); 

        //Division assignment
        a /= b; 
        Console.WriteLine("a /= b: " + a);

        // Modulus assingment
        a %= b; 
        Console.WriteLine("a %= b: " + a); 
    }
    static void IsOperator()
    {
        object obj = "Bhanu";
        if (obj is string)
        {
            Console.WriteLine("obj is a string");
        }
    }
    static void TernaryOperator(int a,int b)
    {
        int max = (a > b) ? a : b;
        Console.WriteLine("Max value from a and b " + max); 

    }

    
    


}