using System;
namespace BankAccountManager{
class Bank
{
    // AccountNo, Balance, CreatedDateTime, MinBalance
    private string[,] accounts =
    {
        { "ACC1001", "5000", "2024-10-01 10:30", "1000" },
        { "ACC1002", "12000", "2024-10-02 11:15", "2000" },
        { "ACC1003", "8000", "2024-10-03 09:45", "1500" }
    };

    private int accountCount = 3;

    public void DisplayAccount(string accNo)
    {
        int index = FindAccount(accNo);

        if (index == -1)
        {
            Console.WriteLine("Account not found.");
            return;
        }

        Console.WriteLine("\nAccount Number: " + accounts[index, 0]);
        Console.WriteLine("Balance: ₹" + accounts[index, 1]);
        Console.WriteLine("Minimum Balance: ₹" + accounts[index, 3]);
        Console.WriteLine("Created On: " + accounts[index, 2]);
    }

    public void Deposit(string accNo, double amount)
    {
        int index = FindAccount(accNo);

        if (index == -1)
        {
            Console.WriteLine("Account not found");
            return;
        }

        double balance = Convert.ToDouble(accounts[index, 1]);
        balance += amount;
        accounts[index, 1] = balance.ToString(); // ✅ FIX
        Console.WriteLine("Deposit successful.");
    }

    public void Withdraw(string accNo, double amount)
    {
        int index = FindAccount(accNo);

        if (index == -1)
        {
            Console.WriteLine("Account not found.");
            return;
        }

        double balance = Convert.ToDouble(accounts[index, 1]);
        double minBalance = Convert.ToDouble(accounts[index, 3]);

        if (balance - amount < minBalance)
        {
            Console.WriteLine("Minimum balance rule violated.");
            return;
        }

        balance -= amount;
        accounts[index, 1] = balance.ToString();
        Console.WriteLine("Withdrawal successful.");
    }

    public void AddAccount(string accNo, double balance, double minBalance)
    {
        string[,] newAccounts = new string[accountCount + 1, 4];

        for (int i = 0; i < accountCount; i++)
            for (int j = 0; j < 4; j++)
                newAccounts[i, j] = accounts[i, j];

        newAccounts[accountCount, 0] = accNo;
        newAccounts[accountCount, 1] = balance.ToString();
        newAccounts[accountCount, 2] = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
        newAccounts[accountCount, 3] = minBalance.ToString();

        accounts = newAccounts;
        accountCount++;

        Console.WriteLine("Account created successfully.");
    }

    public void RemoveAccount(string accNo)
    {
        int index = FindAccount(accNo);
        if (index == -1)
        {
            Console.WriteLine("Account not found.");
            return;
        }

        for (int i = index; i < accountCount - 1; i++)
            for (int j = 0; j < 4; j++)
                accounts[i, j] = accounts[i + 1, j];

        accountCount--;
        Console.WriteLine("Account removed successfully.");
    }

    private int FindAccount(string accNo)
    {
        for (int i = 0; i < accountCount; i++)
            if (accounts[i, 0] == accNo)
                return i;
        return -1;
    }
}
}
