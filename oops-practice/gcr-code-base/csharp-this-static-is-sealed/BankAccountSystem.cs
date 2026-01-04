using System;
class BankAccount
{
    static string bankName="State Bank of India ";
    static int totalAcounts=0;
    public readonly string accountNumber;
    public string accountHolderName;
    private double balance;
    public BankAccount(string accountNumber, string accountHolderName, double balance)
    {
        this.accountNumber = accountNumber;
        this.accountHolderName = accountHolderName;
        this.balance = balance;
        totalAcounts++;
    }
    public void DisplayInfo()
    {
        Console.WriteLine("Bank Name: " + bankName);
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Account Holder Name: " + accountHolderName);
        Console.WriteLine("Balance: " + balance);
    }
    public static void GetTotalAccounts()
    {
        Console.WriteLine("Total Accounts: " + totalAcounts);
    }

}
class BankAccountSystem
{
    public static void Main()
    {
        BankAccount account1 = new BankAccount("001", "Bhanu Dagur", 5000.0);
        BankAccount account2 = new BankAccount("002", "Devansh singh", 3000.0);

        if (account1 is BankAccount)
        {
            account1.DisplayInfo();
        }
        if (account2 is BankAccount)
        {
            account2.DisplayInfo();
        }

        BankAccount.GetTotalAccounts();
    }
}