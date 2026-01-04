using System;

class Student
{
    static string universityName = "GLA University";
    static int totalStudents = 0;

    public readonly int rollNumber;
    public string name;
    public double grade;

    public Student(int rollNumber, string name, double grade)
    {
        this.rollNumber = rollNumber;
        this.name = name;
        this.grade = grade;
        totalStudents++;
    }

    public static void DisplayTotalStudent()
    {
        Console.WriteLine("University Name: " + universityName);
        Console.WriteLine("TOTAL STUDENTS: " + totalStudents);
    }
    public void UpdateGrade(double newGrade)
    {
        grade = newGrade;
        Console.WriteLine("Grade updated to: " + grade);
    }
}

class UniversityManagement
{
    public static void Main()
    {
        Student student1 = new Student(1, "Bhanu Dagur", 8.5);
        Student student2 = new Student(2, "Devesh Dagur", 9.0);

        // Static method ko class name se call karna chahiye
        Student.DisplayTotalStudent();
        student1.UpdateGrade(9.2);
        student2.UpdateGrade(9.5);
    }
}
