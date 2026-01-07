using System;

namespace Employee
{
    internal class Employee
    {
        // Private Fields (Encapsulation)
        private string employeeId;
        private string employeeName;
        private long employeePhoneNumber;
        private string employeeAttendance;   // UC1
        private double employeeDailyWage;    // UC2

        // Employee ID
        public string EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        // Employee Name
        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        // Employee Phone Number
        public long EmployeePhoneNumber
        {
            get { return employeePhoneNumber; }
            set { employeePhoneNumber = value; }
        }

        // UC1: Employee Attendance
        public string EmployeeAttendance
        {
            get { return employeeAttendance; }
            set { employeeAttendance = value; }
        }

        // UC2: Employee Daily Wage
        public double EmployeeDailyWage
        {
            get { return employeeDailyWage; }
            set { employeeDailyWage = value; }
        }

        // Display Employee Details
        public override string ToString()
        {
            return "Employee ID       : " + employeeId +
                   "\nEmployee Name     : " + employeeName +
                   "\nPhone Number      : " + employeePhoneNumber +
                   "\nAttendance        : " + employeeAttendance +
                   "\nDaily Wage        : " + employeeDailyWage;
        }
    }
}
