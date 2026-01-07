using System;
using System.Collections.Generic;

namespace Employee
{
    internal class EmployeeUtilityImpl : IEmployee
    {
        private List<Employee> employees = new List<Employee>();
        private Random attendanceCheck = new Random();
        private double wagePerHour = 20;

        // UC0: Add Employee
        public Employee AddEmployee()
        {
            Employee employee = new Employee();

            Console.Write("Enter Employee ID: ");
            employee.EmployeeId = Console.ReadLine();

            Console.Write("Enter Employee Name: ");
            employee.EmployeeName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            employee.EmployeePhoneNumber = long.Parse(Console.ReadLine());

            employees.Add(employee);
            Console.WriteLine("Employee Added Successfully!");
            return employee;
        }

        // UC1: Employee Attendance Check
        public void AttendanceCheck()
        {
            int i = 1;

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"\nEmployee {i} Attendance Verification");
                long attendanceOtp = attendanceCheck.Next(10000, 99999);
                Console.WriteLine($"Enter the number displayed: {attendanceOtp}");

                long employeeInput = long.Parse(Console.ReadLine());

                if (attendanceOtp == employeeInput)
                    employee.EmployeeAttendance = "Present";
                else
                    employee.EmployeeAttendance = "Absent";

                Console.WriteLine($"{employee.EmployeeName} is {employee.EmployeeAttendance}");
                i++;
            }
        }

        // UC2: Calculate Daily Employee Wage
        public void EmployeeDailyWage()
        {
            foreach (Employee employee in employees)
            {
                if (employee.EmployeeAttendance != "Present")
                {
                    employee.EmployeeDailyWage = 0;
                    Console.WriteLine($"{employee.EmployeeName} is absent. Wage = 0");
                    continue;
                }

                Console.Write($"How many hours {employee.EmployeeName} worked? (Max 8): ");
                int hours = int.Parse(Console.ReadLine());

                if (hours > 8)
                {
                    Console.WriteLine("Hours cannot exceed 8. Taking 8 hours.");
                    hours = 8;
                }

                employee.EmployeeDailyWage = wagePerHour * hours;
                Console.WriteLine($"Daily Wage of {employee.EmployeeName} = {employee.EmployeeDailyWage}");
            }
        }

        // Display Employee Details
        public void DisplayEmployee()
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
                Console.WriteLine("----------------");
            }
        }
    }
}
