using System;
namespace BankAccountManager{
class BankManager
{
    static Bank bank = new Bank();          // ✅ GLOBAL ACCESS
    static User currentUser;                // ✅ GLOBAL USER

    static void Main()
    {
        User customer = new User("U101", "Vansh", "Customer", "ACC1001");
        User staff = new User("U201", "Admin", "Staff", "");

        Console.WriteLine("Select Role:");
        Console.WriteLine("1. Customer");
        Console.WriteLine("2. Staff");

        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            currentUser = customer;
            CustomerMenu();
        }
        else if (choice == 2)
        {
            currentUser = staff;
            StaffMenu();
        }
    }

    static void CustomerMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("\n--- Customer Menu ---");
            Console.WriteLine("1. View Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    bank.DisplayAccount(currentUser.AccountNumber);
                    break;
                case 2:
                    Console.Write("Amount: ");
                    bank.Deposit(currentUser.AccountNumber, Convert.ToDouble(Console.ReadLine()));
                    break;
                case 3:
                    Console.Write("Amount: ");
                    bank.Withdraw(currentUser.AccountNumber, Convert.ToDouble(Console.ReadLine()));
                    break;
            }
        } while (choice != 4);
    }

    static void StaffMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("\n--- Staff Menu ---");
            Console.WriteLine("1. Add Account");
            Console.WriteLine("2. Remove Account");
            Console.WriteLine("3. View Account");
            Console.WriteLine("4. Exit");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddAccountUI();
                    break;
                case 2:
                    RemoveAccountUI();
                    break;
                case 3:
                    ViewAccountUI();
                    break;
            }
        } while (choice != 4);
    }

    static void AddAccountUI()
    {
        Console.Write("Account No: ");
        string acc = Console.ReadLine();
        Console.Write("Balance: ");
        double bal = Convert.ToDouble(Console.ReadLine());
        Console.Write("Min Balance: ");
        double min = Convert.ToDouble(Console.ReadLine());
        bank.AddAccount(acc, bal, min);
    }

    static void RemoveAccountUI()
    {
        Console.Write("Account No: ");
        bank.RemoveAccount(Console.ReadLine());
    }

    static void ViewAccountUI()
    {
        Console.Write("Account No: ");
        bank.DisplayAccount(Console.ReadLine());
    }
}
}
