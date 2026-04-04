using System;

class Book
{
    public static string LibraryName = "Central Library";

    public readonly string ISBN;
    public string Title;
    public string Author;

    public Book(string isbn, string title, string author)
    {
        this.ISBN = isbn;
        this.Title = title;
        this.Author = author;
    }

    public static void DisplayLibraryName()
    {
        Console.WriteLine("Library: " + LibraryName);
    }

    public void Display(object obj)
    {
        if (obj is Book)
        {
            Console.WriteLine($"{Title} by {Author}, ISBN: {ISBN}");
        }
    }
}

class Program
{
    static void Main()
    {
        Book book = new Book("ISBN123", "Clean Code", "Robert Martin");
        Book.DisplayLibraryName();
        book.Display(book);
    }
}
