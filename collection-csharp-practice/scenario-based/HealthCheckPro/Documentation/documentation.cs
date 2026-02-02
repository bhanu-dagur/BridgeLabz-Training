namespace HealthCheckPro.Documentation;

using System;
using System.Reflection;
using HealthCheckPro.Utilities;

public class ApiDocumentation
{
    public static void Generate(Type controllerType)
    {
        Console.WriteLine("\n--- API DOCUMENTATION ---");
        Console.WriteLine("Controller: " + controllerType.Name);
        Console.WriteLine("-----------------------------------");

        MethodInfo[] methods = controllerType.GetMethods(
            BindingFlags.Public |
            BindingFlags.Instance |
            BindingFlags.DeclaredOnly);

        foreach (var method in methods)
        {
            string status = ApiMethodValidator.GetStatus(method);
            Console.WriteLine($"Endpoint: {method.Name} → {status}");
        }
    }
}
