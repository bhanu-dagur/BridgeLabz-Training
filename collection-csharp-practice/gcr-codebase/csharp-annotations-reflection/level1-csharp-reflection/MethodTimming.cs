using System;
using System.Reflection;
using System.Diagnostics;
using System.Threading;

class SampleService
{
    public void FastMethod()
    {
        Thread.Sleep(100); // simulate work
    }

    public void SlowMethod()
    {
        Thread.Sleep(500); // simulate slow work
    }
}

class MethodTimer
{
    public static void MeasureExecutionTime(object obj)
    {
        Type type = obj.GetType();

        // Get all public instance methods
        MethodInfo[] methods =
            type.GetMethods(BindingFlags.Public | BindingFlags.Instance);

        foreach (MethodInfo method in methods)
        {
            // Skip methods inherited from Object class
            if (method.DeclaringType == typeof(object))
                continue;

            // Measure execution time
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            // Invoke method dynamically (no parameters)
            method.Invoke(obj, null);

            stopwatch.Stop();

            Console.WriteLine(
                "Method: " + method.Name +
                " | Execution Time: " +
                stopwatch.ElapsedMilliseconds + " ms"
            );
        }
    }
}

class MethodTimming
{
    static void Main()
    {
        SampleService service = new SampleService();

        MethodTimer.MeasureExecutionTime(service);
    }
}
