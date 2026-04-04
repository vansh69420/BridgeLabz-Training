using System;

class BankAccount
{
    public int accountNumber;
    protected string accountHolder;
    private double balance;

    public void SetBalance(double amount)
    {
        balance = amount;
    }

    public double GetBalance()
    {
        return balance;
    }

    public void SetAccountHolder(string name)
    {
        accountHolder = name;
    }
}

class SavingsAccount : BankAccount
{
    public void DisplayAccountDetails()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Account Holder: " + accountHolder);
        Console.WriteLine("Balance: ₹" + GetBalance());
    }
}

class Program
{
    static void Main()
    {
        SavingsAccount sa = new SavingsAccount();
        sa.accountNumber = 12345;
        sa.SetAccountHolder("Vansh");
        sa.SetBalance(50000);

        sa.DisplayAccountDetails();
    }
}
