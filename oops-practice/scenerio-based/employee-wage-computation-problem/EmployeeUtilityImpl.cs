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

        // UC0 + UC3 : Add Employee
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

            Console.Write("Enter Name: ");
            employee.EmployeeName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            employee.EmployeePhoneNumber = long.Parse(Console.ReadLine());

            employees.Add(employee);
            Console.WriteLine("Employee Added Successfully!");
        }

        // UC1 : Attendance Check
        public void AttendanceCheck()
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"\nAttendance for {employee.EmployeeName}");
                long otp = attendanceCheck.Next(10000, 99999);
                Console.WriteLine($"Enter the number displayed: {otp}");

                long input = long.Parse(Console.ReadLine());

                employee.EmployeeAttendance =
                    (otp == input) ? "Present" : "Absent";

                Console.WriteLine($"{employee.EmployeeName} is {employee.EmployeeAttendance}");
            }
        }

        // UC2 : Daily Wage
        public void EmployeeDailyWage()
        {
            foreach (Employee employee in employees)
            {
                if (employee.EmployeeAttendance != "Present")
                {
                    employee.EmployeeDailyWage = 0;
                    Console.WriteLine($"{employee.EmployeeName} is absent. Daily Wage = 0");
                    continue;
                }

                Console.Write($"Enter working hours for {employee.EmployeeName} (Max 8): ");
                int hours = int.Parse(Console.ReadLine());

                if (hours > 8)
                {
                    Console.WriteLine("Max 8 hours allowed. Taking 8 hours.");
                    hours = 8;
                }

                employee.EmployeeDailyWage = hours * wagePerHour;
                Console.WriteLine($"Daily Wage = {employee.EmployeeDailyWage}");
            }
        }

        // UC5 : Monthly Wage
        public void EmployeeMonthlyWage()
        {
            foreach (Employee employee in employees)
            {
                employee.EmployeeMonthlyWage =
                    employee.EmployeeDailyWage * workingDaysPerMonth;

                Console.WriteLine($"{employee.EmployeeName} Monthly Wage = {employee.EmployeeMonthlyWage}");
            }
        }

        // UC6 : Wage with Max Condition
        public void CalculateWageWithCondition()
        {
            const int MAX_HOURS = 100;
            const int MAX_DAYS = 20;

            foreach (Employee employee in employees)
            {
                int totalHours = 0;
                int totalDays = 0;
                double totalWage = 0;

                Console.WriteLine($"\nCalculating wage for {employee.EmployeeName}");

                while (totalHours < MAX_HOURS && totalDays < MAX_DAYS)
                {
                    Console.Write($"Enter working hours for day {totalDays + 1}: ");
                    int hours = int.Parse(Console.ReadLine());

                    if (hours > 8)
                    {
                        Console.WriteLine("Max 8 hours allowed.");
                        continue;
                    }

                    totalHours += hours;
                    totalDays++;
                    totalWage += hours * wagePerHour;
                }

                employee.EmployeeMonthlyWage = totalWage;

                Console.WriteLine($"Total Days Worked  : {totalDays}");
                Console.WriteLine($"Total Hours Worked : {totalHours}");
                Console.WriteLine($"Final Monthly Wage : {totalWage}");
            }
        }

        // Display Employees
        public void DisplayEmployees()
        {
            Console.WriteLine("1. Display Full Time Employees");
            Console.WriteLine("2. Display Part Time Employees");
            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());

            foreach (Employee employee in employees)
            {
                if (choice == 1 && !employee.IsPartTime ||
                    choice == 2 && employee.IsPartTime)
                {
                    Console.WriteLine(employee);
                    Console.WriteLine("-----------");
                }
            }
        }
    }
}
