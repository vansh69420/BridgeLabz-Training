using System;
using System.Dynamic;
public class Movie
{
    private string Title;
    private string ShowTime;

    public void SetMovie(string title, string time)
    {
        this.Title = title;
        this.ShowTime = time;
    }
    public string GetTitle()
    {
        return Title;
    }
    public string GetShowTime()
    {
        return ShowTime;
    }
    public override string ToString()
    {
        return $"Movie : {Title}, Time : {ShowTime}";
    }
}

