using System;
class BankAccount
{
    protected string AccountNumber;
    protected double Balance;

    public BankAccount(string accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public void DisplayAccountDetails()
    {
        Console.WriteLine("Account Number : " + AccountNumber);
        Console.WriteLine("Balance        : " + Balance);
    }
}

// Subclass 1: SavingsAccount
class SavingsAccount : BankAccount
{
    private double InterestRate;

    public SavingsAccount(string accountNumber, double balance, double interestRate)
        : base(accountNumber, balance)
    {
        InterestRate = interestRate;
    }

    public void DisplayAccountType()
    {
        Console.WriteLine("Account Type   : Savings Account");
        DisplayAccountDetails();
        Console.WriteLine("Interest Rate : " + InterestRate + "%");
    }
}

// Subclass 2: CheckingAccount
class CheckingAccount : BankAccount
{
    private double WithdrawalLimit;

    public CheckingAccount(string accountNumber, double balance, double withdrawalLimit)
        : base(accountNumber, balance)
    {
        WithdrawalLimit = withdrawalLimit;
    }

    public void DisplayAccountType()
    {
        Console.WriteLine("Account Type     : Checking Account");
        DisplayAccountDetails();
        Console.WriteLine("Withdrawal Limit: " + WithdrawalLimit);
    }
}

// Subclass 3: FixedDepositAccount
class FixedDepositAccount : BankAccount
{
    private int Tenure; // in years

    public FixedDepositAccount(string accountNumber, double balance, int tenure)
        : base(accountNumber, balance)
    {
        Tenure = tenure;
    }

    public void DisplayAccountType()
    {
        Console.WriteLine("Account Type : Fixed Deposit Account");
        DisplayAccountDetails();
        Console.WriteLine("Tenure : " + Tenure + " years");
    }
}

// Main Class
class Program
{
    static void Main()
    {
        SavingsAccount sa = new SavingsAccount("SA101", 50000, 4.5);
        CheckingAccount ca = new CheckingAccount("CA201", 30000, 20000);
        FixedDepositAccount fda = new FixedDepositAccount("FD301", 100000, 5);

        Console.WriteLine("---- Savings Account ----");
        sa.DisplayAccountType();

        Console.WriteLine("\n---- Checking Account ----");
        ca.DisplayAccountType();

        Console.WriteLine("\n---- Fixed Deposit Account ----");
        fda.DisplayAccountType();
    }
}
