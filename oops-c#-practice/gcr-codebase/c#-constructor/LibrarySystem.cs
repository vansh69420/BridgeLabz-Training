using System;

class Book
{
    public string ISBN;
    protected string title;
    private string author;

    public void SetAuthor(string author)
    {
        this.author = author;
    }

    public string GetAuthor()
    {
        return author;
    }

    public void SetTitle(string title)
    {
        this.title = title;
    }
}

class EBook : Book
{
    public void DisplayDetails()
    {
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Title: " + title); // protected
        Console.WriteLine("Author: " + GetAuthor());
    }
}

class Program
{
    static void Main()
    {
        EBook ebook = new EBook();
        ebook.ISBN = "978-0132350884";
        ebook.SetTitle("Clean Code");
        ebook.SetAuthor("Robert C. Martin");

        ebook.DisplayDetails();
    }
}
