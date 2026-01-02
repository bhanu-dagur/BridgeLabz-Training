using System;
public class EmployeeDetails{
    private string name;
    private int id;
    private double salary;
    public EmployeeDetails(string name,int id ,double salary){
        this.name=name;
        this.id=id;
        this.salary=salary;
    }
    public void DisplayDetails(){
        Console.WriteLine("Employee Name: "+name);
        Console.WriteLine("Employee ID: "+id);
        Console.WriteLine("Employee Salary: "+salary);
    }

}
public class Employee{
    public static void Main(string[] args){
        EmployeeDetails emp1=new EmployeeDetails("Alice",101,50000);
        EmployeeDetails emp2=new EmployeeDetails("Bob",102,60000);  
        emp1.DisplayDetails();
        Console.WriteLine("===================================");       
        emp2.DisplayDetails();

        Console.WriteLine("ENTER THE NO OF EMPLOYEE");
        int noOfEmployee=Convert.ToInt32(Console.ReadLine());

        EmployeeDetails [] empArray=new EmployeeDetails[noOfEmployee];
        for(int i=0;i<noOfEmployee;i++){
            Console.WriteLine("ENTER THE NAME OF "+(i+1)+" EMPLOYEE");
            string name=Console.ReadLine();

            Console.WriteLine("ENTER THE ID OF "+(i+1)+" EMPLOYEE");
            int id=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ENTER THE SALARY OF "+(i+1)+" EMPLOYEE");
            double salary=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            EmployeeDetails emp=new EmployeeDetails(name,id,salary);
            empArray[i]=emp;
        }
        Console.WriteLine("DISPLAYING EMPLOYEE DETAILS");
        for(int i=0;i<noOfEmployee;i++){
            Console.WriteLine("DETAILS OF EMPLOYEE "+(i+1));
            empArray[i].DisplayDetails();
            Console.WriteLine("===================================");
        }
    }
}