using System;

public class FitTrackUtility : ITrackable
{
    public void ProcessMenuChoice(int choice, UserProfile user)
    {
        switch (choice)
        {
            case 1:
                HandleSingleWorkout(user, "Cardio");
                break;

            case 2:
                HandleSingleWorkout(user, "Strength");
                break;

            case 3:
                HandleBothWorkouts(user);
                break;

            case 4:
                Console.WriteLine(user);
                break;

            case 5:
                Console.WriteLine("Exiting...");
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }

    private void HandleSingleWorkout(UserProfile user, string type)
    {
        Workout workout = new Workout();

        Console.Write($"Enter {type} duration (minutes): ");
        workout.SetDuration(int.Parse(Console.ReadLine()));
        workout.SetWorkoutType(type);

        TrackWorkout(user, workout);
    }

    private void HandleBothWorkouts(UserProfile user)
    {
        Workout cardio = new Workout();
        Workout strength = new Workout();

        Console.Write("Enter Cardio duration (minutes): ");
        cardio.SetDuration(int.Parse(Console.ReadLine()));
        cardio.SetWorkoutType("Cardio");

        Console.Write("Enter Strength duration (minutes): ");
        strength.SetDuration(int.Parse(Console.ReadLine()));
        strength.SetWorkoutType("Strength");

        TrackWorkout(user, cardio);
        TrackWorkout(user, strength);
    }

    public void TrackWorkout(UserProfile user, Workout workout)
    {
        double calories = 0;

        switch (workout.GetWorkoutType())
        {
            case "Cardio":
                calories = workout.GetDuration() * 8;
                break;

            case "Strength":
                calories = workout.GetDuration() * 5;
                break;
        }

        workout.SetCalories(calories);
        user.AddCalories(calories);

        Console.WriteLine(workout);
    }
}
