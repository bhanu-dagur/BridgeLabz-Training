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
        private bool isPartTime = false;     // UC3

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

        // Phone Number
        public long EmployeePhoneNumber
        {
            get { return employeePhoneNumber; }
            set { employeePhoneNumber = value; }
        }

        // UC1: Attendance
        public string EmployeeAttendance
        {
            get { return employeeAttendance; }
            set { employeeAttendance = value; }
        }

        // UC2: Daily Wage
        public double EmployeeDailyWage
        {
            get { return employeeDailyWage; }
            set { employeeDailyWage = value; }
        }

        // UC3: Part-Time or Full-Time
        public bool IsPartTime
        {
            get { return isPartTime; }
            set { isPartTime = value; }
        }

        // Display Employee Details
        public override string ToString()
        {
            string employeeType = isPartTime ? "PART TIME EMPLOYEE" : "FULL TIME EMPLOYEE";

            return $"---- {employeeType} ----" +
                   $"\nEmployee ID        : {employeeId}" +
                   $"\nEmployee Name      : {employeeName}" +
                   $"\nPhone Number       : {employeePhoneNumber}" +
                   $"\nAttendance         : {employeeAttendance}" +
                   $"\nDaily Wage         : {employeeDailyWage}";
        }
    }
}
