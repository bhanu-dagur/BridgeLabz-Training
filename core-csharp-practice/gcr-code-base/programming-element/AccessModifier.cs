using System;

class AccessDemo
{
    public int publicVar = 10;          // Public
    private int privateVar = 20;         // Private
    protected int protectedVar = 30;     // Protected
    internal int internalVar = 40;       // Internal
    protected internal int proIntVar = 50; // Protected Internal

    public void ShowInsideClass()
    {
        Console.WriteLine("Inside Class:");
        Console.WriteLine(publicVar);
        Console.WriteLine(privateVar);
        Console.WriteLine(protectedVar);
        Console.WriteLine(internalVar);
        Console.WriteLine(proIntVar);
    }
}

// Child Class
class ChildDemo : AccessDemo
{
    public void ShowInChildClass()
    {
        Console.WriteLine("\nInside Child Class:");
        Console.WriteLine(publicVar);
        // Console.WriteLine(privateVar) :Not allowed
        Console.WriteLine(protectedVar);
        Console.WriteLine(internalVar);
        Console.WriteLine(proIntVar);
    }
}

class AccessModifier
{
    static void Main()
    {
        AccessDemo obj = new AccessDemo();
        obj.ShowInsideClass();

        Console.WriteLine("\nInside Main Class:");
        Console.WriteLine(obj.publicVar);
        // Console.WriteLine(obj.privateVar); not allowed
        // Console.WriteLine(obj.protectedVar); not allowed
        Console.WriteLine(obj.internalVar);
        Console.WriteLine(obj.proIntVar);

        ChildDemo child = new ChildDemo();
        child.ShowInChildClass();
    }
}
