using System;

class Course
{
    // Instance variables
    string courseName;
    int duration;
    int fee;

    // Class (static) variable
    static string instituteName = "GLA UNIVERSITY";

    // Parameterized constructor
    public Course(string courseName, int duration, int fee)
    {
        this.courseName = courseName;
        this.duration = duration;
        this.fee = fee;
    }

    // Instance method
    public void Display()
    {
        Console.WriteLine("COURSE NAME : " + courseName);
        Console.WriteLine("COURSE DURATION (Months) : " + duration);
        Console.WriteLine("COURSE FEES : " + fee);
        Console.WriteLine("INSTITUTE NAME : " + instituteName);
        Console.WriteLine("-----------------------------");
    }

    // Static (class) method
    public static void ModifyInstituteName(string newInstituteName)
    {
        instituteName = newInstituteName;
    }
}

class OnlineCourse
{
    public static void Main()
    {
        Course course1 = new Course("DSA", 2, 1000);
        course1.Display();

        Course course2 = new Course("CLOUD", 3, 1500);
        course2.Display();

        // Update institute name for all courses
        Course.ModifyInstituteName("Capgemini");

        Console.WriteLine("AFTER UPDATING INSTITUTE NAME");
        course1.Display();
        course2.Display();
    }
}
