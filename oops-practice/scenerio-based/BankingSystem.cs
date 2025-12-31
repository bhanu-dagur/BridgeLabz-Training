using System;
using System.Collections.Generic;

namespace BankingSystem
{
    // ================= TRANSACTION =================
    class Transaction
    {
        public string Type;
        public double Amount;
        public double BalanceAfter;
        public DateTime Date;

        public Transaction(string type, double amount, double balance)
        {
            Type = type;
            Amount = amount;
            BalanceAfter = balance;
            Date = DateTime.Now;
        }
    }

    // ================= BANK ACCOUNT =================
    class BankAccount
    {
        public long AccountNumber;
        public double Balance;
        public List<Transaction> Transactions = new List<Transaction>();

        public BankAccount(long accNo)
        {
            AccountNumber = accNo;
            Balance = 0;
        }

        public void Deposit(double amount)
        {
            Balance = Balance + amount;
            Transactions.Add(new Transaction("Deposit", amount, Balance));
            Console.WriteLine("Deposit successful");
        }

        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance = Balance - amount;
                Transactions.Add(new Transaction("Withdraw", amount, Balance));
                Console.WriteLine("Withdraw successful");
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }
    }

    // ================= CUSTOMER =================
    class Customer
    {
        public int CustomerId;
        public string Name;
        public string Password;
        public BankAccount Account;

        public Customer(int id, string name, string pass, BankAccount acc)
        {
            CustomerId = id;
            Name = name;
            Password = pass;
            Account = acc;
        }

        public void CustomerMenu()
        {
            int choice = 0;

            while (choice != 4)
            {
                Console.WriteLine("\nCustomer Menu");
                Console.WriteLine("1 Deposit");
                Console.WriteLine("2 Withdraw");
                Console.WriteLine("3 Check Balance");
                Console.WriteLine("4 Logout");

                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Enter amount");
                    double amt = Convert.ToDouble(Console.ReadLine());
                    Account.Deposit(amt);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter amount");
                    double amt = Convert.ToDouble(Console.ReadLine());
                    Account.Withdraw(amt);
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Balance is " + Account.Balance);
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Logged out");
                }
            }
        }
    }

    // ================= BANK =================
    class Bank
    {
        public List<Customer> Customers = new List<Customer>();
        private int customerCount = 1;
        public static bankName = "ABC Bank";

        public void AddCustomer()
        {
            Console.WriteLine("Enter customer name");
            string name = Console.ReadLine();

            Console.WriteLine("Set password");
            string pass = Console.ReadLine();

            long accNo = 100000 + customerCount;
            BankAccount acc = new BankAccount(accNo);

            Customer c = new Customer(customerCount, name, pass, acc);
            Customers.Add(c);

            customerCount++;

            Console.WriteLine("Customer added successfully");
            Console.WriteLine("Customer Id " + c.CustomerId);
            Console.WriteLine("Account Number " + accNo);
        }

        public Customer FindCustomer(int id, string pass)
        {
            foreach (Customer c in Customers)
            {
                if (c.CustomerId == id && c.Password == pass)
                    return c;
            }
            return null;
        }

        public Customer FindCustomerById(int id)
        {
            foreach (Customer c in Customers)
            {
                if (c.CustomerId == id)
                    return c;
            }
            return null;
        }
    }

    // ================= MANAGER =================
    class Manager
    {
        private string ManagerId = "admin";
        private string Password = "1234";

        public void ManagerMenu(Bank bank)
        {
            int choice = 0;

            while (choice != 3)
            {
                Console.WriteLine("\nManager Menu");
                Console.WriteLine("1 Add New Customer");
                Console.WriteLine("2 View Customer Details");
                Console.WriteLine("3 Logout");

                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    bank.AddCustomer();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter Customer Id");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Customer c = bank.FindCustomerById(id);
                    if (c != null)
                    {
                        Console.WriteLine("Name " + c.Name);
                        Console.WriteLine("Balance " + c.Account.Balance);
                    }
                    else
                    {
                        Console.WriteLine("Customer not found");
                    }
                }
            }
        }

        public bool Login()
        {
            Console.WriteLine("Enter manager id");
            string id = Console.ReadLine();

            Console.WriteLine("Enter password");
            string pass = Console.ReadLine();

            return id == ManagerId && pass == Password;
        }
    }

    // ================= PROGRAM =================
    class Program
    {
        static void Main()
        {
            Bank bank = new Bank();
            Manager manager = new Manager();

            int choice = 0;

            while (choice != 3)
            {
                Console.WriteLine("\nLogin As");
                Console.WriteLine("1 Manager");
                Console.WriteLine("2 Customer");
                Console.WriteLine("3 Exit");

                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    if (manager.Login())
                        manager.ManagerMenu(bank);
                    else
                        Console.WriteLine("Invalid manager login");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter customer id");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter password");
                    string pass = Console.ReadLine();

                    Customer c = bank.FindCustomer(id, pass);
                    if (c != null)
                        c.CustomerMenu();
                    else
                        Console.WriteLine("Invalid customer login");
                }
            }
        }
    }
}
