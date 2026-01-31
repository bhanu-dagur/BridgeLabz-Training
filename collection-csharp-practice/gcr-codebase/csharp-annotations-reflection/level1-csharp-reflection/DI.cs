using System;
using System.Reflection;


// ---------------------------------------------------------------
// STEP 1: Custom Inject Attribute
// ---------------------------------------------------------------
// This attribute marks a field where dependency should be injected
[AttributeUsage(AttributeTargets.Field)]
class InjectAttribute : Attribute
{
    
}

// STEP 2: Dependency / Service Class
class MessageService
{
    public void Send()
    {
        Console.WriteLine("Message Sent");
    }
}


// ---------------------------------------------------------------
// STEP 3: Class That Needs Dependency
// ---------------------------------------------------------------
class Notification
{
    // Dependency will be injected automatically
    [Inject]
    private MessageService service;

    public void Notify()
    {
        service.Send();
    }
}


// ---------------------------------------------------------------
// STEP 4: Simple DI Container (Core Logic)
// ---------------------------------------------------------------
class DIContainer
{
    public static T Resolve<T>()
    {
        // Create object of requested class
        T obj = (T)Activator.CreateInstance(typeof(T));

        //  Get all private instance fields
        FieldInfo[] fields =
            typeof(T).GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

        // 3 Scan each field
        foreach (FieldInfo field in fields)
        {
            //  Check if field has [Inject] attribute
            if (Attribute.IsDefined(field, typeof(InjectAttribute)))
            {
                // 5 Create dependency object dynamically
                object dependency =
                    Activator.CreateInstance(field.FieldType);

                // 6 Inject dependency into the field
                field.SetValue(obj, dependency);
            }
        }

        return obj;
    }
}

// ------------ MAIN CLASS ------------------------------------
class DI
{
    static void Main()
    {
        // Object is created using DI container (not using new)
        Notification notification =
            DIContainer.Resolve<Notification>();

        // Dependency is already injected
        notification.Notify();
    }
}

