using System;
using System.Collections.Generic;

namespace Employee
{
    internal class EmployeeUtilityImpl : IEmployee
    {
        private List<Employee> employees = new List<Employee>();
        private Random attendanceCheck = new Random();

        private double wagePerHour = 20;
        private int workingDaysPerMonth = 20;

        // UC0 + UC3 : Add Employee (Full Time / Part Time)
        public void AddEmployee()
        {
            Employee employee = new Employee();

            Console.WriteLine("1. Full Time Employee");
            Console.WriteLine("2. Part Time Employee");
            Console.Write("Enter choice: ");
            int choiceForTime = int.Parse(Console.ReadLine());

            if (choiceForTime == 2)
                employee.IsPartTime = true;

            Console.Write("Enter Employee ID: ");
            employee.EmployeeId = Console.ReadLine();

            Console.Write("Enter Employee Name: ");
            employee.EmployeeName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            employee.EmployeePhoneNumber = long.Parse(Console.ReadLine());

            employees.Add(employee);
            Console.WriteLine("Employee Added Successfully!");
        }

        // UC1 : Employee Attendance Check
        public void AttendanceCheck()
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"\nAttendance for {employee.EmployeeName}");
                long attendanceOtp = attendanceCheck.Next(10000, 99999);
                Console.WriteLine($"Enter the number displayed: {attendanceOtp}");

                long input = long.Parse(Console.ReadLine());

                if (attendanceOtp == input)
                    employee.EmployeeAttendance = "Present";
                else
                    employee.EmployeeAttendance = "Absent";

                Console.WriteLine($"{employee.EmployeeName} is {employee.EmployeeAttendance}");
            }
        }

        // UC2 : Daily Wage Calculation
        public void EmployeeDailyWage()
        {
            foreach (Employee employee in employees)
            {
                if (employee.EmployeeAttendance != "Present")
                {
                    employee.EmployeeDailyWage = 0;
                    Console.WriteLine($"{employee.EmployeeName} is absent. Daily wage = 0");
                    continue;
                }

                Console.Write($"Enter working hours for {employee.EmployeeName} (Max 8): ");
                int hours = int.Parse(Console.ReadLine());

                if (hours > 8)
                {
                    Console.WriteLine("Hours cannot exceed 8. Taking 8 hours.");
                    hours = 8;
                }

                employee.EmployeeDailyWage = wagePerHour * hours;
                Console.WriteLine($"Daily Wage = {employee.EmployeeDailyWage}");
            }
        }

        // UC5 : Monthly Wage Calculation
        public void EmployeeMonthlyWage()
        {
            foreach (Employee employee in employees)
            {
                employee.EmployeeMonthlyWage =
                    employee.EmployeeDailyWage * workingDaysPerMonth;

                Console.WriteLine($"{employee.EmployeeName} Monthly Wage = {employee.EmployeeMonthlyWage}");
            }
        }

        // Display Full Time / Part Time Employees
        public void DisplayEmployee()
        {
            Console.WriteLine("1. Display Full Time Employees");
            Console.WriteLine("2. Display Part Time Employees");
            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());

            foreach (Employee employee in employees)
            {
                if (choice == 1 && !employee.IsPartTime)
                {
                    Console.WriteLine(employee);
                    Console.WriteLine("-----------");
                }
                else if (choice == 2 && employee.IsPartTime)
                {
                    Console.WriteLine(employee);
                    Console.WriteLine("-----------");
                }
            }
        }
    }
}
