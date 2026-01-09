using System;
public class UserProfile
{
    private int UserId;
    private string UserName;
    private int Age;
    private double TotalCalories;

    public void SetUserId(int id)
    {
        UserId = id;
    }

    public int GetUserId()
    {
        return UserId;
    }

    public void SetUserName(string name)
    {
        UserName = name;
    }

    public string GetUserName()
    {
        return UserName;
    }

    public void SetAge(int age)
    {
        Age = age;
    }
    public int GetAge()
    {
        return Age;
    }
    public void AddCalories(double calories)
    {
        TotalCalories += calories;
    }


    public override string ToString()
    {
        return $"User ID: {UserId}, Name: {UserName}, Age: {Age}, Total Calories Burned: {TotalCalories}";
    }
}