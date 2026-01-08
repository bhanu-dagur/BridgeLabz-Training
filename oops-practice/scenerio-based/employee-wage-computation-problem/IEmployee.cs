using System;

namespace Employee
{
    internal interface IEmployee
    {
        // UC0 + UC3
        void AddEmployee();

        // UC1
        void AttendanceCheck();

        // UC2
        void EmployeeDailyWage();

        // UC5
        void EmployeeMonthlyWage();

        // UC6
        void CalculateWageWithCondition();

        // Display
        void DisplayEmployees();
    }
}
