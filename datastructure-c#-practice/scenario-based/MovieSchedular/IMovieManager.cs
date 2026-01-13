using System;
public interface IMovieManager
{
    void AddMovie(string title, string time);
    void SearchMovie(string keyword);
    void DisplayAllMovies();
}