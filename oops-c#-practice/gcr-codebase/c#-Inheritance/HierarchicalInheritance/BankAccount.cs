using System;

class BankAccount
{
    public int AccountNumber;
}

class SavingsAccount : BankAccount
{
    public void DisplayAccountType()
    {
        Console.WriteLine("Savings Account");
    }
}

class CheckingAccount : BankAccount
{
    public void DisplayAccountType()
    {
        Console.WriteLine("Checking Account");
    }
}

class Program
{
    static void Main()
    {
        SavingsAccount sa = new SavingsAccount();
        CheckingAccount ca = new CheckingAccount();

        sa.DisplayAccountType();
        ca.DisplayAccountType();
    }
}
