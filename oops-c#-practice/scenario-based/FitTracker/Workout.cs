using System;
public abstract class Workout
{
    protected int duration;
    protected double calories;

    public void SetDuration(int minutes)
    {
        duration = minutes;
    }

    public abstract double CalculateCalories();

    public override string ToString()
    {
        return $"Workout Duration: {duration} minutes, Calories Burned: {calories}";
    }
}