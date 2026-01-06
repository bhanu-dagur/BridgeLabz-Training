// Description: Create a hierarchy for a school system where Person is the superclass, and Teacher, Student, and Staff are subclasses.
// Tasks:
// Define a superclass Person with common attributes like Name and Age.
// Define subclasses Teacher, Student, and Staff with specific attributes (e.g., Subject for Teacher and Grade for Student).
// Each subclass should have a method like DisplayRole() that describes the role.
// Goal: Demonstrate hierarchical inheritance by modeling different roles in a school, each with shared and unique characteristics.
using System;
class Person
{
    string name;
    int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }    
    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + this.name);
        Console.WriteLine("Age: " + this.age);
    }
}
class Teacher : Person
{
    string subject;
    public Teacher(string name, int age, string subject) : base(name, age)
    {
        this.subject = subject;
    }
    public void DisplayRole()
    {
        Console.WriteLine("I am a Teacher and I teach " + this.subject);
    }
}
class Student : Person
{
    string grade;
    public Student(string name, int age, string grade) : base(name, age)
    {
        this.grade = grade;
    }
    public void DisplayRole()
    {
        Console.WriteLine("I am a Student and my grade is " + this.grade);
    }
}
class Staff : Person
{
    string role;
    public Staff(string name, int age, string role) : base(name, age)
    {
        this.role = role;
    }
    public void DisplayRole()
    {
        Console.WriteLine("I am a Staff and my role is " + this.role);
    }
}
class SchoolSystem
{
    static void Main(string[] args)
    {
        Person person = new Person("John Doe", 30);
        person.DisplayInfo();    
        Teacher teacher = new Teacher("Jane Smith", 35, "Mathematics");
        teacher.DisplayInfo();
        teacher.DisplayRole();
        Student student = new Student("Alice Johnson", 18, "A");
        student.DisplayInfo();
        student.DisplayRole();
        Staff staff = new Staff("Bob Williams", 40, "Librarian");
        staff.DisplayInfo();
        staff.DisplayRole();
    }
}