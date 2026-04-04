using System;
class LibraryManagementSystem
{
    string[,] books =
{
    { "The Alchemist", "Paulo Coelho", "Available" },
    { "Clean Code", "Robert Martin", "Available" },
    { "The Pragmatic Programmer", "Andrew Hunt", "Available" },
    { "Introduction to Algorithms", "Thomas Cormen", "Available" },
    { "C Sharp Programming", "Microsoft", "Available" },

    { "Design Patterns", "Erich Gamma", "Available" },
    { "Refactoring", "Martin Fowler", "Available" },
    { "Head First Java", "Kathy Sierra", "Available" },
    { "Artificial Intelligence", "Stuart Russell", "Available" },
    { "Machine Learning", "Tom Mitchell", "Available" },

    { "Deep Learning", "Ian Goodfellow", "Available" },
    { "Operating System Concepts", "Silberschatz", "Available" },
    { "Computer Networks", "Andrew Tanenbaum", "Available" },
    { "Database System Concepts", "Abraham Silberschatz", "Available" },
    { "Software Engineering", "Ian Sommerville", "Available" }
};

    public static void Main(string[] args)
    {
        LibraryManagementSystem library = new LibraryManagementSystem();
        library.Start();
    }

    void Start()
    {
        Console.WriteLine("Select Role:");
        Console.WriteLine("1. Librarian");
        Console.WriteLine("2. Member");

        int role = Convert.ToInt32(Console.ReadLine());

        switch(role)
        {
            case 1:
                LibrarianMenu();
                break;
            case 2:
                MemberMenu();
                break;
            default:
                Console.WriteLine("Invalid Input.");
                break;
        }
    }

    void LibrarianMenu()
    {
        int choice;

        do
        {
            Console.WriteLine("\n--- Librarian Menu ---");
            Console.WriteLine("1. View All Books");
            Console.WriteLine("2. Search Book");
            Console.WriteLine("3. Checkout Book");
            Console.WriteLine("4. Return Book");
            Console.WriteLine("5. Add Book");
            Console.WriteLine("6. Remove Book");
            Console.WriteLine("7. Exit");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: DisplayAllBooks(); break;
                case 2: SearchAndDisplay(); break;
                case 3: ChangeBookStatus("Checked Out"); break;
                case 4: ChangeBookStatus("Available"); break;
                case 5: AddBook(); break;
                case 6: RemoveBook(); break;
                case 7: Console.WriteLine("Exiting Librarian Menu..."); break;
                default: Console.WriteLine("Invalid choice."); break;
            }

        }while(choice != 7);
    }

    void MemberMenu()
    {
        int choice;

        do
        {
            Console.WriteLine("\n--- Member Menu ---");
            Console.WriteLine("1. Search Book");
            Console.WriteLine("2. Checkout Book");
            Console.WriteLine("3. Exit");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: SearchAndDisplay(); break;
                case 2: ChangeBookStatus("Checked Out"); break;
                case 3: Console.WriteLine("Exiting Member Menu..."); break;
                default: Console.WriteLine("Invalid choice."); break;
            }

        } while (choice != 3);
    }

    void DisplayAllBooks()
    {
        Console.WriteLine("\n--- Book List ---");

        for (int i = 0; i < books.GetLength(0); i++)
        {
            Console.WriteLine(
                (i + 1) + ". " +
                books[i, 0] + " | " +
                books[i, 1] + " | " +
                books[i, 2]);
        }
    }

    void SearchAndDisplay()
    {
        Console.WriteLine("Enter partial book title:");
        string search = Console.ReadLine();

        int index = SearchBook(search);

        if (index == -1)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        DisplayBook(index);
    }

    int SearchBook(string text)
    {
        for(int i = 0; i < books.GetLength(0); i++)
        {
            if (ContainIgnoreCase(books[i, 0], text))
            {
                return i;
            }
        }
        return -1;
    }

    void DisplayBook(int index)
    {
        Console.WriteLine("Book Detail");
        Console.WriteLine("Title:" + books[index, 0]);
        Console.WriteLine("Author: " + books[index, 1]);
        Console.WriteLine("Status: " + books[index, 2]);
    }

    

    static bool ContainIgnoreCase(string title, string search)
    {
        title = ToLower(title);
        search = ToLower(search);

        return title.Contains(search);
    }

    static string ToLower(string text)
    {
        if(text == null)
        {
            return "";
        }
        string result = "";

        for(int i = 0; i < text.Length; i++)
        {
            char c = text[i];

            if(c >= 'A' && c <= 'Z')
            {
                result += (char)(c + 32);
            }
        }
        return result;
    }

    void ChangeBookStatus(string newStatus)
    {
        Console.WriteLine("Enter the partial book title: ");
        string search = Console.ReadLine();

        int index = SearchBook(search);

        if(index == -1)
        {
            Console.WriteLine("Book not found");
            return;
        }
        if(books[index, 2] == newStatus)
        {
            Console.WriteLine("Book is Already: " + books[index, 2]);
        }
        else
        {
            books[index, 2] = newStatus;
            Console.WriteLine("Book status updated to : " + books[index, 2]);
        }
    }

    void AddBook()
    {
        Console.WriteLine("Enter Book Title: ");
        string title = Console.ReadLine();

        Console.WriteLine("Enter author of the book: ");
        string author = Console.ReadLine();

        int rows = books.GetLength(0);
        string[,] newBooks = new string[rows + 1, 3];

        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                newBooks[i, j] = books[i, j];
            }
        }
        newBooks[rows, 0] = title;
        newBooks[rows, 1] = author;
        newBooks[rows, 2] = "Available";

        books = newBooks;

        Console.WriteLine("Book Added Successfully");
    }

    void RemoveBook()
    {
        Console.WriteLine("Enter title of book.");
        string title = Console.ReadLine();

        int index = SearchBook(title);

        if(index == -1)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        int rows = books.GetLength(0);
        string[,] newBooks = new string[rows - 1, 3];

        int newRow = 0;

        for(int i = 0; i < rows; i++)
        {
            if(i == index)
            {
                continue;
            }
            for(int j = 0; j < 3; j++)
            {
                newBooks[newRow, j] = books[i, j];
            }
            newRow++;
        }

        books = newBooks;

        Console.WriteLine("Books Removed Successfully.");


    }


}