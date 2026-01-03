using System;
class BankAccount
{
    public string accountNumber;
    protected string accountHolderName;
    private double balance;
    public BankAccount(string accountNumber, string accountHolderName, double balance)
    {
        this.accountNumber = accountNumber;
        this.accountHolderName = accountHolderName;
        this.balance = balance;
    }
    public void DisplayInfo()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Account Holder Name: " + accountHolderName);
        Console.WriteLine("Balance: " + balance);
    }
    public void Modifiedbalance(double newBalance)
    {
        balance = newBalance;
        Console.WriteLine("Balance modified to: " + balance);
    }
}
class SavingsAccount : BankAccount
{
    public SavingsAccount(string accountNumber, string accountHolderName, double balance) : base(accountNumber, accountHolderName, balance)
    {
        
    }
    public void AccountHolderDetail()
    {
        Console.WriteLine("Account Holder Name modified to: " + accountHolderName);
        Console.WriteLine("Account Number: " + accountNumber);
    }
    
}
class BankSystem
{
    public static void Main()
    {
        BankAccount bankAccount = new BankAccount("1", "Bhanu Dagur", 1000.0);
        bankAccount.DisplayInfo(); 
        bankAccount.Modifiedbalance(1200.0);
        SavingsAccount savingsAccount = new SavingsAccount("2", "Rohit", 2000.0);
        savingsAccount.DisplayInfo();
        savingsAccount.AccountHolderDetail();

    }
}