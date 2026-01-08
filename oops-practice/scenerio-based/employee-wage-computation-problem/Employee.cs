using System;

namespace Employee
{
    internal class Employee
    {
        private string employeeid;
        private string employeename;
        private double employeedailywage;     // UC2 Daily Wage
        private double employeemonthlywage;   // UC5 Monthly Wage
        private long employeephonenumber;
        private string employeeattendance;    // UC1 Attendance
        private bool isparttime = false;       // UC3 Part-Time

        // Employee ID
        public string EmployeeId
        {
            get { return employeeid; }
            set { employeeid = value; }
        }

        // Employee Name
        public string EmployeeName
        {
            get { return employeename; }
            set { employeename = value; }
        }

        // Daily Wage
        public double EmployeeDailyWage
        {
            get { return employeedailywage; }
            set { employeedailywage = value; }
        }

        // Monthly Wage
        public double EmployeeMonthlyWage
        {
            get { return employeemonthlywage; }
            set { employeemonthlywage = value; }
        }

        // Phone Number
        public long EmployeePhoneNumber
        {
            get { return employeephonenumber; }
            set { employeephonenumber = value; }
        }

        // Attendance
        public string EmployeeAttendance
        {
            get { return employeeattendance; }
            set { employeeattendance = value; }
        }

        // Part-Time / Full-Time
        public bool IsPartTime
        {
            get { return isparttime; }
            set { isparttime = value; }
        }

        // Display Employee Details
        public override string ToString()
        {
            string employeeType = isparttime ? "PART TIME EMPLOYEE" : "FULL TIME EMPLOYEE";

            return $"---- {employeeType} ----" +
                   $"\nEmployee ID          : {employeeid}" +
                   $"\nEmployee Name        : {employeename}" +
                   $"\nDaily Wage           : {employeedailywage}" +
                   $"\nMonthly Wage         : {employeemonthlywage}" +
                   $"\nPhone Number         : {employeephonenumber}" +
                   $"\nAttendance           : {employeeattendance}";
        }
    }
}
