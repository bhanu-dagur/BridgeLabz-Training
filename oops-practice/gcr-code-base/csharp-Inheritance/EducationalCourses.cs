using System;
class Course
{
    protected string CourseName;
    protected int Duration; 

    public Course(string courseName, int duration)
    {
        CourseName = courseName;
        Duration = duration;
    }

    public void DisplayCourse()
    {
        Console.WriteLine("Course Name : " + CourseName);
        Console.WriteLine("Duration    : " + Duration + " hours");
    }
}
class OnlineCourse : Course
{
    protected string Platform;
    protected bool IsRecorded;

    public OnlineCourse(string courseName, int duration, string platform, bool isRecorded)
        : base(courseName, duration)
    {
        Platform = platform;
        IsRecorded = isRecorded;
    }

    public void DisplayOnlineCourse()
    {
        DisplayCourse();
        Console.WriteLine("Platform    : " + Platform);
        Console.WriteLine("Recorded    : " + (IsRecorded ? "Yes" : "No"));
    }
}
class PaidOnlineCourse : OnlineCourse
{
    private double Fee;
    private double Discount;

    public PaidOnlineCourse(string courseName, int duration, string platform,
                            bool isRecorded, double fee, double discount)
        : base(courseName, duration, platform, isRecorded)
    {
        Fee = fee;
        Discount = discount;
    }

    public void DisplayPaidCourse()
    {
        DisplayOnlineCourse();
        Console.WriteLine("Course Fee  : " + Fee);
        Console.WriteLine("Discount   : " + Discount + "%");

        double finalFee = Fee - (Fee * Discount / 100);
        Console.WriteLine("Final Fee  : " + finalFee);
    }
}
class Program
{
    static void Main()
    {
        PaidOnlineCourse poc = new PaidOnlineCourse(
            "Full Stack Development",
            120,
            "Udemy",
            true,
            10000,
            20
        );

        Console.WriteLine("---- Paid Online Course Details ----");
        poc.DisplayPaidCourse();
    }
}
