using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class)]
class AuthorAttribute : Attribute
{
    public string Name;
    public AuthorAttribute(string name) { Name = name; }
}

[Author("Vansh Tyagi")]
class Book { }

class CustomAttribute
{
    static void Main()
    {
        Type t = typeof(Book);
        AuthorAttribute attr = (AuthorAttribute)Attribute.GetCustomAttribute(t, typeof(AuthorAttribute));

        Console.WriteLine("Author: " + attr.Name);
    }
}
