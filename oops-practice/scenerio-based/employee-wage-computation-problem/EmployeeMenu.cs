using System;

namespace Employee
{
    sealed class EmployeeMenu
    {
        private IEmployee _employeeChoice;

        public void Menu()
        {
            _employeeChoice = new EmployeeUtilityImpl();

            while (true)
            {
                Console.WriteLine("\n===== Employee Wage Computation Menu =====");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Display Employee");
                Console.WriteLine("3. Attendance Check");   // UC1
                Console.WriteLine("4. Calculate Wage");     // UC2
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        _employeeChoice.AddEmployee();
                        break;

                    case 2:
                        _employeeChoice.DisplayEmployee();
                        break;

                    case 3:
                        _employeeChoice.AttendanceCheck();
                        break;

                    case 4:
                        _employeeChoice.EmployeeDailyWage();
                        break;

                    case 5:
                        Console.WriteLine("Program exited successfully.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            }
        }
    }
}
