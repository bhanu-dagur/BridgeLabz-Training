using System;
using System.Reflection;

class Configuration
{
    private static string API_KEY="OldKey";
    
    public static void ShowDetails()
    {
        Console.WriteLine("API KEY inside class: " + API_KEY);
    }
}
class ModifyStaticFields
{
    public static void Main()
    {
        Type type=typeof(Configuration);
        FieldInfo field=type.GetField("API_KEY",BindingFlags.NonPublic | BindingFlags.Static);

        string ans=(string)field.GetValue(null);

        Console.WriteLine("API kEY value from Reflection : "+ans);

        field.SetValue(null,"new key value");

        ans=(string)field.GetValue(null);

        Console.WriteLine("API kEY value from Reflection : "+ans);

        Configuration.ShowDetails();



    }
}
/*
1. BindingFlags.NonPublic
Allows access to private members

2.BindingFlags.Static
Required because the field is static

3.field.SetValue(null, "NEW_SECRET_API_KEY");
null is passed because:
Static fields belong to the class
Not to any object

Rule:

Instance field → pass object

Static field → pass null
*/