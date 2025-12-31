using System;
namespace BankAccountManager{
class User
{
    public string UserId;
    public string Name;
    public string Role;
    public string AccountNumber;

    public User(string userId, string name, string role, string accountNumber)
    {
        UserId = userId;
        Name = name;
        Role = role;
        AccountNumber = accountNumber;
    }
}
}