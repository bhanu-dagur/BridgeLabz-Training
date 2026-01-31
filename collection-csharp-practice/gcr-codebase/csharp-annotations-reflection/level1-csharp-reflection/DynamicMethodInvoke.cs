using System;
using System.Reflection;      
using System.Transactions;

class MathOperation
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    private int Multiply(int a, int b)
    {
        return a * b;
    }
}
class DynamicMethodInvoke
{
    public static void Main()
    {
        Type type=typeof(MathOperation);
        // Activator  .NET ka built-in class
        // CreateInstance() Runtime par object create karne ke kaam aata hai
        object obj=Activator.CreateInstance(type);

        // Q: Why does it return object?
        // A: Because the actual type is resolved at runtime, not at compile time.

        // MathOperation math=(MathOperation)obj;

        Console.WriteLine("Enter first number: ");
        int a=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        int b=Convert.ToInt32(Console.ReadLine());

        object [] parameters={a,b};

        Console.WriteLine("Enter \n1 for Add, \n2 for Subtract, \n3 for Multiply: ");
        int choice=Convert.ToInt32(Console.ReadLine());

        int result=0;
        if (choice == 1)
        {
            MethodInfo method=type.GetMethod("Add");
            result=(int)method.Invoke(obj,parameters);
        }
        else if (choice == 2)
        {
            MethodInfo method=type.GetMethod("Subtract");
            result=(int)method.Invoke(obj,parameters);
        }
        else
        {
            MethodInfo method=type.GetMethod("Multiply",BindingFlags.NonPublic | BindingFlags.Instance);
            result=(int)method.Invoke(obj,parameters);
        }
        Console.WriteLine("result : "+result);
    }
}
