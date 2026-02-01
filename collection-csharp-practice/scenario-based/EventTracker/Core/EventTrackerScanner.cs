namespace EventTracker.Core;

using System;
using System.Reflection;
using System.Text.Json;
using EventTracker.Attributes;
using EventTracker.Models;
using EventTracker.Actions;

public class EventTrackerScanner
{
    public static void Scan(Type targetType)
    {
        MethodInfo[] methods = targetType.GetMethods(
            BindingFlags.Public |
            BindingFlags.Instance |
            BindingFlags.DeclaredOnly);

        foreach (var method in methods)
        {
            var auditAttr =
                method.GetCustomAttribute<AuditTrailAttribute>();

            if (auditAttr != null)
            {
                AuditLog log = new AuditLog
                {
                    Action = auditAttr.ActionName,
                    Method = method.Name,
                    Class = targetType.Name,
                    Timestamp = DateTime.Now
                };

                string jsonLog = JsonSerializer.Serialize(
                    log, new JsonSerializerOptions { WriteIndented = true });

                Console.WriteLine(jsonLog);
            }
        }
    }
}
