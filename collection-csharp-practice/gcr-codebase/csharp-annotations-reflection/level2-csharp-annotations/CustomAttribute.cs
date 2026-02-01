using System;
using System.Reflection;

/*
[AttributeUsage(AttributeTargets.Mathod)]
class TaskInfoAttribute : Attribute
{
    public string Priority{get;}
    public string AssignedTo{get;}

    public TaskInfoAttribute(string priority,string assignedTo)
    {
        this.Priority=Priority;
        this.AssignedTo=AssignedTo;
    }
}

class TaskManager
{
    [TaskInfo("High","Bhanu Dagur")] 
    public void CompleteTask()
    {
        Console.WriteLine("Task Completed Successfully");
    }
    
}

class CustomAttribute
{
    static void Main()
    {
        TaskManager manager = new TaskManager();

        // Get Type info
        Type type = typeof(TaskManager);

        // Get Method info
        MethodInfo method = type.GetMethod("CompleteProject");

        // Get Custom Attribute

        // type casting because it returns object
        TaskInfoAttribute taskInfo=
           (TaskInfoAttribute)Attribute.GetCustomAttribute(
                method,typeof(TaskInfoAttribute));

        //  Isliye hum pass karte hain:
        // 1️ method->Bata raha hai kis element se attribute uthana hai

        // 2️ typeof(TaskInfoAttribute)-> Bata raha hai kaunsa attribute chahiye
            


        // Display attribute data
        Console.WriteLine("Task Details:");
        Console.WriteLine("Priority: " + taskInfo.Priority);
        Console.WriteLine("Assigned To: " + taskInfo.AssignedTo);

        // Call method
        manager.CompleteProject();
    }
}

*/



//  Custom Attribute (Allow multiple usage)
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class TaskInfoAttribute : Attribute
{
    public string Priority { get; set; }
    public string AssignedTo { get;set; }

    public TaskInfoAttribute(string priority, string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}

// Class where attribute is applied
class TaskManager
{
    [TaskInfo("High", "Bhanu")]
    [TaskInfo("High", "Rohit")]
    public void CompleteProject()
    {
        Console.WriteLine("Project completed successfully.");
    }
}

// 3 Main Program (Reflection)
class CustomAttribute
{
    static void Main()
    {
        Type type = typeof(TaskManager);
        MethodInfo method = type.GetMethod("CompleteProject");

        // Get all TaskInfo attributes applied on method
        TaskInfoAttribute[] tasks =
            (TaskInfoAttribute[])method.GetCustomAttributes(
                typeof(TaskInfoAttribute), false);

        Console.WriteLine("Task Information:");

        foreach (var task in tasks)
        {
            Console.WriteLine(
                "Priority: " + task.Priority + ", Assigned To: " + task.AssignedTo);
        }

        // Call the method
        TaskManager manager = new TaskManager();
        manager.CompleteProject();
    }
}



