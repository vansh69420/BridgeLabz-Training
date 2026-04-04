using System;

[AttributeUsage(AttributeTargets.Field)]
class MaxLengthAttribute : Attribute
{
    public int Length;
    public MaxLengthAttribute(int length) => Length = length;
}

class User
{
    [MaxLength(8)]
    public string Username;

    public User(string username)
    {
        if (username.Length > 8)
            throw new ArgumentException("Username too long");

        Username = username;
    }
}

class MaxLength
{
    static void Main()
    {
        User u = new User("Vansh");
        Console.WriteLine("User created: " + u.Username);
    }
}
