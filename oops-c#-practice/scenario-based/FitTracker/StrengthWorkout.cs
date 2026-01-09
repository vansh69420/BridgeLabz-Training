using System;
public class StrengthWorkout: Workout, ITrackable
{
    public override double CalculateCalories()
    {
        calories += duration * 5;
        return calories;
    }
    public void TrackWorkout(UserProfile user)
    {
        user.AddCalories(CalculateCalories());
    }

    public override string ToString()
    {
        return $"[Strength Workout] Duration: {duration} min, Calories Burned: {calories}";
    }
}