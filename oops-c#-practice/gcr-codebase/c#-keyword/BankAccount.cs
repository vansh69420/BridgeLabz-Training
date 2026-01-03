using System;

class BankAccount
{
    public static string BankName = "HDFC";
    private static int totalAccounts = 0;

    public readonly int AccountNumber;
    public string AccountHolderName;

    public BankAccount(int accountNumber, string accountHolderName)
    {
        this.AccountNumber = accountNumber;   // this keyword
        this.AccountHolderName = accountHolderName;
        totalAccounts++;
    }

    public static void GetTotalAccounts()
    {
        Console.WriteLine("Total Accounts: " + totalAccounts);
    }

    public void DisplayDetails(object obj)
    {
        if (obj is BankAccount)   // is operator
        {
            Console.WriteLine($"Bank: {BankName}");
            Console.WriteLine($"Account No: {AccountNumber}");
            Console.WriteLine($"Holder: {AccountHolderName}");
        }
    }
}

class Program
{
    static void Main()
    {
        BankAccount acc1 = new BankAccount(101, "Vansh");
        BankAccount acc2 = new BankAccount(102, "Hemant");
        acc1.DisplayDetails(acc1);
        acc2.DisplayDetails(acc2);
        BankAccount.GetTotalAccounts();
    }
}
