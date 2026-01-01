using System;

// This class controls the application flow and role-based menus
class CafeteriaApp
{
    // Entry point of the program (execution starts here)
    static void Main(string[] args)
    {
        // Creating Cafeteria object to access menu-related operations
        Cafeteria cafe = new Cafeteria();

        // Role selection
        Console.WriteLine("Select Role:");
        Console.WriteLine("1. Admin");
        Console.WriteLine("2. Student");

        // Reading role choice from user
        int role = Convert.ToInt32(Console.ReadLine());

        // Role-based control using switch
        switch(role)
        {
            case 1:
                // Admin can only view menu
                AdminMenu(cafe);
                break;

            case 2:
                // Student can view menu and order items
                StudentMenu(cafe);
                break;

            default:
                Console.WriteLine("Invalid Role Selected");
                break;
        }
    }

    // Admin menu – limited responsibility (Single Responsibility)
    static void AdminMenu(Cafeteria cafe)
    {
        Console.WriteLine("\n--- Admin Menu ---");

        // Admin can only view menu
        cafe.DisplayMenu();

        Console.WriteLine("Admin can view items only.");
    }

    // Student menu – allows interaction like ordering
    static void StudentMenu(Cafeteria cafe)
    {
        int choice;

        // Loop keeps menu running until user exits
        do
        {
            Console.WriteLine("\n--- Student Menu ---");
            Console.WriteLine("1. View Menu");
            Console.WriteLine("2. Order Item");
            Console.WriteLine("3. Exit");

            // Reading student choice
            choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    // Display menu items
                    cafe.DisplayMenu();
                    break;

                case 2:
                    // Take index input to order item
                    Console.Write("Enter the index: ");
                    int index = Convert.ToInt32(Console.ReadLine());

                    // Fetch item using Cafeteria method
                    string item = cafe.GetItemByIndex(index);
                    Console.WriteLine("You Selected: " + item);
                    break;

                case 3:
                    Console.WriteLine("Thank you for visiting cafeteria");
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
        // Loop exits when choice is 3
        while(choice != 3);
    }
}
