using System;
class Employee
{
    static string campanyName="Capgemini";
    public readonly int id;
    public string name;
    public string designation;
    static int totalEmployees=0;
    public Employee(int id, string name, string designation)
    {
        this.id=id;
        this.name=name;
        this.designation=designation;
        totalEmployees++;
    }
    public void DisplayInfo()
    {
        Console.WriteLine("Company Name: " + campanyName);
        Console.WriteLine("Employee ID: " + id);
        Console.WriteLine("Employee Name: " + name);
        Console.WriteLine("Employee Designation: " + designation);
    }
    public static void DisplayTotalEmployees()
    {
        Console.WriteLine("Total Employees: " + totalEmployees);
    } 
}
class EmployeeSystem
{
    public static void Main()
    {
        Employee emp1 = new Employee(1, "Bhanu Dagur", "Developer");
        Employee emp2 = new Employee(2, "Devansh ", "Manager");

        if (emp1 is Employee)
        {
            emp1.DisplayInfo();
        }
        if (emp2 is Employee)
        {
            emp2.DisplayInfo();
        }

        Employee.DisplayTotalEmployees();
    }
} 