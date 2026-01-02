using System;

class Book
{
    public string title;
    public string author;
    public double price;

    public void DisplayBookDetails()
    {
        Console.WriteLine("Book Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: ₹" + price);
    }
}

class Program
{
    static void Main()
    {
        Book b = new Book();

        b.title = "Clean Code";
        b.author = "Robert C. Martin";
        b.price = 599;

        b.DisplayBookDetails();
    }
}
