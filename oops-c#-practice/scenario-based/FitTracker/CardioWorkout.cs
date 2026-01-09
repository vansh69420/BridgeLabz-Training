using System;
public class CardioWorkout : Workout, ITrackable
{
    public override double CalculateCalories()
    {
        calories += duration * 8;
        return calories;
    }

    public void TrackWorkout(UserProfile user)
    {
        user.AddCalories(CalculateCalories());

    }

    public override string ToString()
    {
        return $"[Cardio Workout] Duration: {duration} min, Calories Burned: {calories}";
    }
}