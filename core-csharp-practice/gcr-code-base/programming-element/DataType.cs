using System;
class DataType
{
    public static void Main(String [] args)
    {
        // Intege type
        int a = 10; 
        long b = 1234567890;
        short c = 5;
        byte d = 255;

        // Floating Types
        float f = 10.5f;
        double db = 99.99;

        // Boolean
        bool isPassed = true;

        // Character
        char grade = 'A';

        // String
        string name = "Bhanu";

        // Object
        object obj1 = 100;
        object obj2 = "Hello";

        // var
        var num = 20;
        var text = "CSharp";

        // Output
        Console.WriteLine("int: " + a);
        Console.WriteLine("long: " + b);
        Console.WriteLine("short: " + c);
        Console.WriteLine("byte: " + d);
        Console.WriteLine("float: " + f);
        Console.WriteLine("double: " + db);
        Console.WriteLine("bool: " + isPassed);
        Console.WriteLine("char: " + grade);
        Console.WriteLine("string: " + name);
        Console.WriteLine("object1: " + obj1);
        Console.WriteLine("object2: " + obj2);
        Console.WriteLine("var num: " + num);
        Console.WriteLine("var text: " + text);
        Console.WriteLine("Type Casting ");
        TypeCasting();
        
    }
    public static void TypeCasting()
    {
        int x= 10;
        // int → double (automatic || implicitly type casting)
        double y = x;   
        Console.WriteLine(y);

        
        double d= 10.75;
        // double → int (explicitly )
        int i = (int)d;   
        Console.WriteLine(i);

        // String to integer
        string s = "25";
        int num = Convert.ToInt32(s);
        Console.WriteLine(num);

        string str = "50";
        int n = int.Parse(str);
        Console.WriteLine(n);


    
    }
}
