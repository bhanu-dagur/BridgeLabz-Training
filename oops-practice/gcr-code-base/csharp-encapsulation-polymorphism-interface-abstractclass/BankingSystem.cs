using System;
using System.Collections.Generic;
interface ILoanable
{
    void ApplyForLoan();
    double CalculateLoanEligibility();
}

// ABSTRACT CLASS 
abstract class BankAccount
{
    // Encapsulation: private fields
    private int accountNumber;
    private string holderName;
    protected double balance;

    public BankAccount(int accountNumber, string holderName, double balance)
    {
        this.accountNumber = accountNumber;
        this.holderName = holderName;
        this.balance = balance;
    }

    // Read-only access
    public int AccountNumber
    {
        get { return accountNumber; }
    }

    public string HolderName
    {
        get { return holderName; }
    }

    public double Balance
    {
        get { return balance; }
    }

    // Common methods
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine("Deposited: " + amount);
        }
        else
        {
            Console.WriteLine("Invalid deposit amount");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient balance");
        }
    }

    // Abstract method
    public abstract double CalculateInterest();

    public void DisplayAccount()
    {
        Console.WriteLine("Account Number : " + accountNumber);
        Console.WriteLine("Holder Name    : " + holderName);
        Console.WriteLine("Balance        : " + balance);
    }
}

// SAVINGS ACCOUNT 
class SavingsAccount : BankAccount, ILoanable
{
    private const double interestRate = 0.04; // 4%

    public SavingsAccount(int accNo, string name, double balance)
        : base(accNo, name, balance) { }

    public override double CalculateInterest()
    {
        return balance * interestRate;
    }

    public void ApplyForLoan()
    {
        Console.WriteLine("Loan applied for Savings Account");
    }

    public double CalculateLoanEligibility()
    {
        return balance * 5; 
    }
}

// CURRENT ACCOUNT 
class CurrentAccount : BankAccount
{
    public CurrentAccount(int accNo, string name, double balance)
        : base(accNo, name, balance) { }

    public override double CalculateInterest()
    {
        return 0; // No interest
    }
}

//  MAIN CLASS 
class BankingSystem
{
    static void Main()
    {
        // Polymorphism: base class reference
        List<BankAccount> accounts = new List<BankAccount>
        {
            new SavingsAccount(101, "Bhanu Dagur", 50000),
            new CurrentAccount(102, "Rohit Sharma", 80000)
        };

        foreach (BankAccount account in accounts)
        {
            account.DisplayAccount();

            // Deposit & Withdraw (common logic)
            account.Deposit(5000);
            account.Withdraw(2000);

            // Polymorphic interest calculation
            double interest = account.CalculateInterest();
            Console.WriteLine("Interest Earned: " + interest);

            // Loan logic using interface
            if (account is ILoanable)
            {
                ILoanable loanAccount = (ILoanable)account;
                loanAccount.ApplyForLoan();
                Console.WriteLine("Loan Eligibility: " +loanAccount.CalculateLoanEligibility());
            }
            else
            {
                Console.WriteLine("Loan facility not available");
            }

            Console.WriteLine("----------------------------------");
        }
    }
}
