using System;
using System.ComponentModel;
using System.Reflection;

class Calculator
{
    private int Multiply(int a,int b)
    {
        // Console.WriteLine(a*b);
        return a*b;
    }
}
class InvokePrivateMethod
{
    public static void Main()
    {
        Calculator c=new Calculator();

        Type type=typeof(Calculator);

        MethodInfo  method=type.GetMethod("Multiply",BindingFlags.NonPublic | BindingFlags.Instance);

        object [] parameters={2,3};

        int result=(int)method.Invoke(c,parameters);

        Console.WriteLine(result);
    }
}