using System;
class Employee
{
    public int empId;
    // protected should be accessible in derived classes and within the same class 
    protected string empDepartment;
    // private should be accessible only within the same class
    private double empSalary;

    public Employee(int empId, string empDepartment, double empSalary)
    {
        this.empId = empId;
        this.empDepartment = empDepartment;
        this.empSalary = empSalary;
    }
    public void DisplayInfo() 
    {
        Console.WriteLine("Employee ID: " + empId);
        Console.WriteLine("Employee Department: " + empDepartment);
        Console.WriteLine("Employee Salary: " + empSalary);
        Console.WriteLine("");
    }
    public void ModifySalary(double newSalary)
    {
        empSalary = newSalary;
        Console.WriteLine("Employee Salary modified to: " + empSalary);
    }
}
class Manager : Employee
{
    public Manager(int empId, string empDepartment, double empSalary) : base(empId, empDepartment, empSalary)
    {
        
    }
    public void EmployeeDetails()
    {
        Console.WriteLine("Employee Department: " + empDepartment);
        Console.WriteLine("Employee ID: " + empId);
        Console.WriteLine("");
    } 
    
}
class EmployeeRecords
{
    public static void Main()
    {
        Employee employee=new Employee(1,"Bhanu Dagur",1000.0);
        employee.DisplayInfo();
        employee.ModifySalary(12000.0);

        Manager manager=new Manager(2,"Rohit",2000.0);
        manager.DisplayInfo();
        manager.EmployeeDetails();
    }
}