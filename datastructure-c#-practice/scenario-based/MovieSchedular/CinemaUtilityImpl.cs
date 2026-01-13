using System;
public class CinemaUtilityImpl : IMovieManager
{
    private UniversalLinkedList movieList;

    public CinemaUtilityImpl()
    {
        movieList = new UniversalLinkedList();
        AddPredefinedMovie("Inception", "18:30");
        AddPredefinedMovie("Interstellar", "21:15");
        AddPredefinedMovie("Avatar", "16:45");
    }
    private void AddPredefinedMovie(string title, string time)
    {
        Movie movie = new Movie();
        movie.SetMovie(title, time);
        movieList.AddLast(movie);
    }

    public void AddMovie(string title, string time)
    {
        if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(time))
            return;

        Movie movie = new Movie();
        movie.SetMovie(title, time);
        movieList.AddLast(movie);
    }

    public void DisplayAllMovies()
    {
        UniversalLinkedList.Node temp = movieList.GetHead();

        while (temp != null)
        {
            Movie movie = (Movie)temp.GetData();
            Console.WriteLine(movie);
            temp = temp.GetNext();
        }
    }

    public void SearchMovie(string keyword)
    {
        if (string.IsNullOrEmpty(keyword))
        {
            Console.WriteLine("Search keyword cannot be empty");
            return;
        }

        bool found = false;
        UniversalLinkedList.Node temp = movieList.GetHead();

        while (temp != null)
        {
            Movie movie = (Movie)temp.GetData();

            if (movie.GetTitle().IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                Console.WriteLine(movie);
                found = true;
            }

            temp = temp.GetNext();
        }

        if (!found)
        {
            Console.WriteLine("No movie found with given keyword");
        }
    }
}