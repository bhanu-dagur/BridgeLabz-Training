using System;

namespace Employee
{
    internal interface IEmployee
    {
        // UC0 + UC3 : Add Employee (Full Time / Part Time)
        void AddEmployee();

        // Display Employees (Full Time / Part Time)
        void DisplayEmployee();

        // UC1 : Employee Attendance Check
        void AttendanceCheck();

        // UC2 : Daily Wage
        void EmployeeDailyWage();

        // UC5 : Monthly Wage
        void EmployeeMonthlyWage();
    }
}
