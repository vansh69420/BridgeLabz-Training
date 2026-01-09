using System;
public class FitTrackUtility
{
    public void StartCardioWorkout(UserProfile user, int duration)
    {
        ITrackable workout = new CardioWorkout();
        ((Workout)workout).SetDuration(duration);
        workout.TrackWorkout(user);

        Console.WriteLine(workout);
    }

    public void StartStrengthWorkout(UserProfile user, int duration)
    {
        ITrackable workout = new StrengthWorkout();
        ((Workout)workout).SetDuration(duration);
        workout.TrackWorkout(user);

        Console.WriteLine(workout);
    }
}