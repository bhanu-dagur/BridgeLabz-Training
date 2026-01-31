using System;
using System.Reflection;

class Student
{
    private string name;

    private int age;

    public Student(string name,int age)
    {
        this.name=name;
        this.age=age;
    }

    public void ShowDetails()
    {
        Console.WriteLine("Name : "+name);
        Console.WriteLine("age : "+age);
    }

}

class CreateObject
{
    public static void Main()
    {
        Type type=typeof(Student);

        object obj=Activator.CreateInstance(
            type,
            new object [] {"Bhanu",23}
        );

        // typecast the object to student
        Student student=(Student)obj;

        student.ShowDetails();

    }
}