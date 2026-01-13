using System;

public class MovieMenu
{
    private IMovieManager manager;

    public MovieMenu()
    {
        manager = new CinemaUtilityImpl();
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("\n=== CinemaTime Menu ===");
            Console.WriteLine("1. View Movies");
            Console.WriteLine("2. Add Movie");
            Console.WriteLine("3. Search Movie");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            string input = Console.ReadLine() ?? "";

            // Safe parsing
            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine("Invalid input. Please enter a number from 1 to 4.");
                continue; // back to menu
            }

                switch (choice)
                {
                    case 1:
                        manager.DisplayAllMovies();
                        break;

                    case 2:
                        AddMovieUI();
                        break;

                    case 3:
                        SearchMovieUI();
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
        }
    }


    private void AddMovieUI()
    {
        Console.Write("Enter Movie Title: ");
        string title = Console.ReadLine() ?? "";

        Console.Write("Enter Show Time (HH:MM): ");
        string time = Console.ReadLine() ?? "";

        manager.AddMovie(title, time);
    }

    private void SearchMovieUI()
    {
        Console.Write("Enter search keyword: ");
        string key = Console.ReadLine() ?? "";
        manager.SearchMovie(key);
    }
}
