using System;
using System.Collections;

// Disable warning for obsolete usage
#pragma warning disable CS0618

class Program
{
    static void Main()
    {
        // Non-generic ArrayList (unchecked operation)
        ArrayList list = new ArrayList();

        list.Add(10);
        list.Add("Hello");
        list.Add(3.14);

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}

// Enable warning again (good practice)
#pragma warning restore CS0618

/*
# confusion in warning java and csharp
In Java:
ArrayList list = new ArrayList();  // unchecked warning aati hai


Java me generics compile-time  hote hain,
isliye unchecked warnings aati hain.

C# me:
ArrayList list = new ArrayList();


C# me:

ArrayList .NET ka valid, supported class hai

Ye [Obsolete] mark nahi hai

Isliye compiler warning nahi deta

Microsoft ne warning force nahi ki
Developer ko khud decision lene diya
*/