using System;
class FitTrackMenu
{
    private FitTrackUtility utility;
    private UserProfile user;

    public void ShowMenu()
    {
        utility = new FitTrackUtility();
        user = new UserProfile();

        Console.WriteLine("Enter User Id:");
        user.SetUserId(Convert.ToInt32(Console.ReadLine()));

        Console.WriteLine("Enter the Name: ");
        user.SetUserName(Console.ReadLine());

        Console.WriteLine("Enter the Age: ");
        user.SetAge(Convert.ToInt32(Console.ReadLine()));

        int choice;

        do
        {
            Console.WriteLine("\n===== FitTrack Menu =====");
            Console.WriteLine("1. Cardio Workout");
            Console.WriteLine("2. Strength Workout");
            Console.WriteLine("3. Show User Summary");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.Write("Enter Cardio Duration (minutes): ");
                    int cardioTime = Convert.ToInt32(Console.ReadLine());
                    utility.StartCardioWorkout(user, cardioTime);
                    break;
                case 2:
                    Console.Write("Enter Strength Duration (minutes): ");
                    int strengthTime = Convert.ToInt32(Console.ReadLine());
                    utility.StartStrengthWorkout(user, strengthTime);
                    break;
                case 3:
                    Console.WriteLine("\n--- User Summary ---");
                    Console.WriteLine(user);
                    break;

                case 4:
                    Console.WriteLine("Exiting FitTrack...");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }while(choice != 4);
    }
}