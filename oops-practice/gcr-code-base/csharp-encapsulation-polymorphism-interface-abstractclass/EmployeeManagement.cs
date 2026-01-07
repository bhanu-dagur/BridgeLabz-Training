using System;

// INTERFACE 
interface IDepartment
{
    void AssignDepartment(string department);
    string GetDepartmentDetails();
}

// ABSTRACT CLASS 
abstract class Employee : IDepartment
{
    // Encapsulation (private fields)
    private int employeeId;
    private string name;
    private double baseSalary;
    private string department;

    // Constructor
    public Employee(int employeeId, string name, double baseSalary)
    {
        this.employeeId = employeeId;
        this.name = name;
        this.baseSalary = baseSalary;
    }

    // Properties (read-only where needed)
    public int EmployeeId
    {
        get { return employeeId; }
    }

    public string Name
    {
        get { return name; }
    }

    public double BaseSalary
    {
        get { return baseSalary; }
    }

    // Interface methods implemented here
    public void AssignDepartment(string department)
    {
        this.department = department;
    }

    public string GetDepartmentDetails()
    {
        return department;
    }

    // Abstract method
    public abstract double CalculateSalary();

    // Concrete method
    public void DisplayDetails()
    {
        Console.WriteLine("Employee ID : " + employeeId);
        Console.WriteLine("Name        : " + name);
        Console.WriteLine("Department  : " + department);
        Console.WriteLine("Salary      : " + CalculateSalary());
        Console.WriteLine("-------------------------------");
    }
}

// FULL TIME EMPLOYEE
class FullTimeEmployee : Employee
{
    public FullTimeEmployee(int id, string name, double salary)
        : base(id, name, salary)
    {
    }

    public override double CalculateSalary()
    {
        return BaseSalary; 
    }
}

//PART TIME EMPLOYEE 
class PartTimeEmployee : Employee
{
    private int hoursWorked;
    private double ratePerHour;

    public PartTimeEmployee(int id, string name, int hoursWorked, double ratePerHour)
        : base(id, name, 0)
    {
        this.hoursWorked = hoursWorked;
        this.ratePerHour = ratePerHour;
    }

    public override double CalculateSalary()
    {
        return hoursWorked * ratePerHour;
    }
}

//  MAIN CLASS 
class EmployeeManagement
{
    public static void Main()
    {
        Employee[] employees = new Employee[2];

        employees[0] = new FullTimeEmployee(1, "Bhanu Dagur", 50000);
        employees[0].AssignDepartment("Development");

        employees[1] = new PartTimeEmployee(2, "Rohit", 4, 500);
        employees[1].AssignDepartment("Testing");


        foreach (Employee employee in employees)
        {
            employee.DisplayDetails();
        }
    }
}
