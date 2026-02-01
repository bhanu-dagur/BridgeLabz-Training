// Exercise 5: Create and Use a Repeatable Attribute
// Problem Statement: Define an attribute BugReport that can be applied multiple times on a method.
// Steps to Follow:
// Define BugReport with a Description field.
// Use AllowMultiple = true to allow multiple bug reports.
// Apply it twice on a method.
// Retrieve and print all bug reports.

using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method,AllowMultiple =true)]
class BugReportAttribute : Attribute
{
    public string Discription{get;set;}

    public BugReportAttribute(string msg)
    {
        Discription=msg;
    }

}

class BugReportManager
{
    [BugReport("First Bug report")]
    [BugReport("Second Bug report")]

    public void ReportBug()
    {
        Console.WriteLine("Bug reported sucessfully");
    }
}

class BugReport
{
    public static void Main()
    {
        BugReportManager bugReportManager=new BugReportManager();

        Type type=bugReportManager.GetType();

        MethodInfo method=type.GetMethod("ReportBug");

        BugReportAttribute [] reports=
            (BugReportAttribute[])
                method.GetCustomAttributes(typeof(BugReportAttribute),false);

        foreach(BugReportAttribute report in reports)
        {
            Console.WriteLine(report.Discription);
        }

        bugReportManager.ReportBug();
    }
}