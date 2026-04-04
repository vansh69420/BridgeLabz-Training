public class Workout
{
    private int duration;
    private string workoutType;
    private double calories;

    public void SetDuration(int minutes)
    {
        duration = minutes;
    }

    public int GetDuration()
    {
        return duration;
    }

    public void SetWorkoutType(string type)
    {
        workoutType = type;
    }

    public string GetWorkoutType()
    {
        return workoutType;
    }

    public void SetCalories(double cal)
    {
        calories = cal;
    }

    public double GetCalories()
    {
        return calories;
    }

    public override string ToString()
    {
        return $"Workout Type: {workoutType}, Duration: {duration} min, Calories Burned: {calories}";
    }
}
