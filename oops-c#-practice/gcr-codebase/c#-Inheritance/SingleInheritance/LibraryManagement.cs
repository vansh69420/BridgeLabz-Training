using System;

class Book
{
    public string Title;
    public int Year;

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"{Title} - {Year}");
    }
}

class Author : Book
{
    public string Name;

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Author: " + Name);
    }
}

class Program
{
    static void Main()
    {
        Author a = new Author
        {
            Title = "Clean Code",
            Year = 2008,
            Name = "Robert Martin"
        };

        a.DisplayInfo();
    }
}
