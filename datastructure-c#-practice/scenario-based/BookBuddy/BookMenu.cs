using System;

public class BookMenu
{
    private BookUtilityImpl manager;

    public BookMenu()
    {
        manager = new BookUtilityImpl();
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("\n=== BookBuddy Menu ===");
            Console.WriteLine("1. View All Books");
            Console.WriteLine("2. Add Book");
            Console.WriteLine("3. Search Books By Author");
            Console.WriteLine("4. Sort Books Alphabetically");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            string input = Console.ReadLine();
            int choice;

            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Invalid input. Enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    manager.DisplayAllBooks();
                    break;

                case 2:
                    manager.AddBook();   // utility asks user input
                    break;

                case 3:
                    manager.SearchByAuthor();
                    break;

                case 4:
                    manager.SortBooksAlphabetically();
                    break;

                case 5:
                    Console.WriteLine("Exiting BookBuddy...");
                    return;

                default:
                    Console.WriteLine("Please choose between 1 and 5.");
                    break;
            }
        }
    }
}
