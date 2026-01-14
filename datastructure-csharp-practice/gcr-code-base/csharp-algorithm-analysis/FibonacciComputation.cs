using System;
using System.Diagnostics;

class FibonacciComputation
{
    static void Main()
    {
        int[] testValues = { 10, 30 };

        foreach (int n in testValues)
        {
            Console.WriteLine("\nFibonacci Number: " + n);

            // Recursive Fibonacci 
            Stopwatch sw1 = Stopwatch.StartNew();
            int recResult = FibonacciRecursive(n);
            sw1.Stop();
            Console.WriteLine("Recursive Result: " + recResult);
            Console.WriteLine("Recursive Time : " + sw1.ElapsedMilliseconds + " ms");

            // Iterative Fibonacci 
            Stopwatch sw2 = Stopwatch.StartNew();
            long iterResult = FibonacciIterative(n);
            sw2.Stop();
            Console.WriteLine("Iterative Result: " + iterResult);
            Console.WriteLine("Iterative Time : " + sw2.ElapsedMilliseconds + " ms");
        }

        //  Large N (Iterative only) 
        int largeN = 50;
        Console.WriteLine("\nFibonacci Number: " + largeN + " (Recursive skipped)");

        Stopwatch sw3 = Stopwatch.StartNew();
        long iterLarge = FibonacciIterative(largeN);
        sw3.Stop();
        Console.WriteLine("Iterative Result: " + iterLarge);
        Console.WriteLine("Iterative Time : " + sw3.ElapsedMilliseconds + " ms");
    }

    //  Recursive Fibonacci 
    public static int FibonacciRecursive(int n)
    {
        if (n <= 1)
            return n;

        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    //  Iterative Fibonacci 
    public static long FibonacciIterative(int n)
    {
        if (n <= 1)
            return n;

        long a = 0, b = 1, sum = 0;

        for (int i = 2; i <= n; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
        }

        return b;
    }
}
