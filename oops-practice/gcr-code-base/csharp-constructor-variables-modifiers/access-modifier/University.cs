using System;
class Student
{
    public int rollNumb;
    // protected should be accessible in derived classes and within the same class 
    protected string name;
    // priavate should be accessible only within the same class
    private double cgpa;

    public Student(int rollNumb, string name, double cgpa)
    {
        this.rollNumb = rollNumb;
        this.name = name;
        this.cgpa = cgpa;
    }
    public void DisplayInfo()
    {
        Console.WriteLine("Roll Number: " + rollNumb);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("CGPA: " + cgpa);
    }
    public void ModifyCgpa(double newCgpa)
    {
        cgpa = newCgpa;
        Console.WriteLine("CGPA modified to: " + cgpa);
    }

}
class Postgraduated : Student
{
    public Postgraduated(int rollNumb, string name, double cgpa) : base(rollNumb, name, cgpa)
    {
        
    }
    public void ModifyName(string newName)
    {
        name = newName;
        Console.WriteLine("Name modified to: " + name);
    }
    
}
class University
{
    static void Main(string[] args)
    {
        Student student = new Student(101, "Alice", 3.8);
        student.DisplayInfo();
        student.ModifyCgpa(3.9);

        Postgraduated pgStudent = new Postgraduated(201, "Bob", 3.7);
        pgStudent.DisplayInfo();
        pgStudent.ModifyName("Robert");
        pgStudent.ModifyCgpa(3.8);
    }
}