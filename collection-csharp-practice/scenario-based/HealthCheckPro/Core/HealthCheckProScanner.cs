namespace HealthCheckPro.Core;

// using System;
// using System.Reflection;
// using HealthCheckPro.Utilities;

public class HealthCheckProScanner : IScanner
{
    public void Scan(Type controllerType)
    {
        // reuse utility
        Console.WriteLine("Controller scanning : " + controllerType.Name);
        var methods = controllerType.GetMethods(
            BindingFlags.Public |
            BindingFlags.Instance |
            BindingFlags.DeclaredOnly
        );

        foreach (var method in methods)
        {
            string status = ApiMethodValidator.GetStatus(method);
            Console.WriteLine("Method : " + method.Name + " Status : " + status);
        }
    }
}
