using System;

public class FitTrackMenu
{
    private FitTrackUtility utility = new FitTrackUtility();
    private UserProfile user = new UserProfile();

    public void ShowMenu()
    {
        Console.Write("Enter User ID: ");
        user.SetUserId(int.Parse(Console.ReadLine()));

        Console.Write("Enter Name: ");
        user.SetUserName(Console.ReadLine());

        Console.Write("Enter Age: ");
        user.SetAge(int.Parse(Console.ReadLine()));

        int choice;
        do
        {
            Console.WriteLine("\n===== FitTrack Menu =====");
            Console.WriteLine("1. Cardio Workout");
            Console.WriteLine("2. Strength Workout");
            Console.WriteLine("3. Both (Cardio + Strength)");
            Console.WriteLine("4. Show Summary");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            utility.ProcessMenuChoice(choice, user);

        } while (choice != 5);
    }
}
