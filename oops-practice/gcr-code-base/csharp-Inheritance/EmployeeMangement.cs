using System;
class Employee
{
    string name;
    int id;
    double salary;
    public Employee(string name, int id, double salary)
    {
        this.name=name;
        this.id=id;
        this.salary=salary;
    }
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Employee Name: " + name);
        Console.WriteLine("Employee ID: " + id);
        Console.WriteLine("Employee Salary: " + salary);
    }
}
class Manager : Employee
{
    int teamSize;
    public Manager(string name, int id, double salary, int teamSize) : base(name, id, salary)
    {
        this.teamSize=teamSize;
    }
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Team Size: " + teamSize);
    }
}
class Developer : Employee
{
    string programmingLanguage;
    public Developer(string name, int id, double salary, string programmingLanguage) : base(name, id, salary)
    {
        this.programmingLanguage=programmingLanguage;
    }
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Programming Language: " + programmingLanguage);
    }
}
class Intern : Employee
{
    string internshipDuration;
    public Intern(string name, int id, double salary, string internshipDuration) : base(name, id, salary)
    {
        this.internshipDuration=internshipDuration;
    }
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Internship Duration: " + internshipDuration);
    }
}   
class EmployeeMangement
{
    public static void Main()
    {
        Manager manager = new Manager("Bhanu", 1, 80000.0, 10);
        Developer developer = new Developer("krishna", 2, 60000.0, "C#");
        Intern intern = new Intern("Devansh", 3, 30000.0, "3 months");

        Console.WriteLine("Manager Details:");
        manager.DisplayDetails();
        Console.WriteLine();

        Console.WriteLine("Developer Details:");
        developer.DisplayDetails();
        Console.WriteLine();

        Console.WriteLine("Intern Details:");
        intern.DisplayDetails();
    }
}