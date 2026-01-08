using System;

namespace Employee
{
    internal interface IEmployee
    {
        // UC0 + UC3
        void AddEmployee();

        // Display Full Time / Part Time Employees
        void DisplayEmployee();

        // UC1
        void AttendanceCheck();

        // UC2
        void EmployeeDailyWage();
    }
}
