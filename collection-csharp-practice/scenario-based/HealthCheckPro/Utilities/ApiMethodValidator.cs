namespace HealthCheckPro.Utilities;

using System.Reflection;
using HealthCheckPro.Attributes;

public class ApiMethodValidator
{
    public static string GetStatus(MethodInfo method)
    {
        bool isPublic =
            method.IsDefined(typeof(PublicAPIAttribute), false);

        bool isAuth =
            method.IsDefined(typeof(AuthAPIAttribute), false);

        if (isPublic || isAuth)
            return "OK";

        return "MISSING";
    }
}
