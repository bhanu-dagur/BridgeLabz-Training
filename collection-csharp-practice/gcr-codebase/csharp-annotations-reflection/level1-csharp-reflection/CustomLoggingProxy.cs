using System;
using System.Reflection;

/*

KEY IDEA:
- We use an INTERFACE to define behavior.
- A REAL CLASS implements the interface.
- A PROXY CLASS also implements the same interface.
- The proxy adds LOGGING before calling the real method.
- The real business logic class is NOT modified.

This pattern is used for:
- Logging
- Security checks
- Validation
- Aspect-Oriented Programming (AOP)

====================================================================
*/


// ---------------------------------------------------------------
// STEP 1: Interface
// ---------------------------------------------------------------
// This interface defines the contract.
// Both the real class and the proxy class must implement it.
interface IGreeting
{
    void SayHello();
}


// ---------------------------------------------------------------
// STEP 2: Real Implementation (Business Logic)
// ---------------------------------------------------------------
// This class contains the actual business logic.
// It does NOT know anything about logging or proxy.
class Greeting : IGreeting
{
    public void SayHello()
    {
        Console.WriteLine("Hello");
    }
}


// ---------------------------------------------------------------
// STEP 3: Manual Logging Proxy
// ---------------------------------------------------------------
// This class acts as a PROXY.
// It implements the SAME interface as the real class.
// It holds a reference to the real object.
class LoggingProxy : IGreeting
{
    // Reference to the real object
    private IGreeting target;

    // Constructor receives the real object
    public LoggingProxy(IGreeting target)
    {
        this.target = target;
    }

    // This method intercepts the call
    public void SayHello()
    {
        // 1 LOGGING (Cross-cutting concern)
        Console.WriteLine("Method Name: SayHello");

        // 2 Forward the call to the real object
        target.SayHello();
    }
}


// ---------------------------------------------------------------
// STEP 4: Main Class (Program Execution Starts Here)
// ---------------------------------------------------------------
class CustomLoggingProxy
{
    static void Main()
    {
        // Create the real object
        IGreeting realObj = new Greeting();

        // Wrap the real object inside the proxy
        IGreeting proxy = new LoggingProxy(realObj);

        /*
        IMPORTANT:
        - Method is NOT called directly on the real object.
        - Method is called on the proxy.
        - Proxy adds logging.
        - Proxy then delegates the call to the real object.
        */

        // Call method through proxy
        proxy.SayHello();
    }
}


/*
====================================================================
PROGRAM FLOW SUMMARY (IMPORTANT FOR INTERVIEWS)
====================================================================

1. Main() starts execution.
2. A real object (Greeting) is created.
3. A proxy object (LoggingProxy) is created and wraps the real object.
4. Method is called on the proxy.
5. Proxy logs the method name.
6. Proxy calls the real method.
7. Real method executes business logic.
8. Output is printed.

====================================================================
FLOW DIAGRAM:

Main()
 │
 │ new Greeting()
 ▼
Real Object (Greeting)
 │
 │ new LoggingProxy(realObj)
 ▼
Proxy Object
 │
 │ proxy.SayHello()
 ▼
LoggingProxy.SayHello()
 │
 │ Log: "Method Name: SayHello"
 ▼
Greeting.SayHello()
 │
 ▼
Console Output

====================================================================
OVERVIEW :\\
This is a manual proxy pattern where logging is added by intercepting
method calls through an interface without modifying the real class.
====================================================================
*/
