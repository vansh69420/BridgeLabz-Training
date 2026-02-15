using System;

public class CitizenMenu
{
    private ICitizenService citizenSystem = new CitizenUtility();

    public void Start()
    {
        int choice;

        do
        {
            Console.WriteLine("\n===============================");
            Console.WriteLine("      CITY MANAGEMENT SYSTEM");
            Console.WriteLine("===============================");

            Console.WriteLine("\n--- Citizen Management ---");
            Console.WriteLine("1. Add Citizen");
            Console.WriteLine("2. Search Citizen");

            Console.WriteLine("\n--- Service Management ---");
            Console.WriteLine("3. Assign Service");
            Console.WriteLine("4. Show Popular Services");

            Console.WriteLine("\n--- Organization Management (Tree) ---");
            Console.WriteLine("5. Create Organization Root");
            Console.WriteLine("6. Add Department");
            Console.WriteLine("7. Show Organization (PreOrder)");

            Console.WriteLine("\n--- Road Network (Graph) ---");
            Console.WriteLine("8. Add Road");
            Console.WriteLine("9. Find Shortest Path (BFS)");

            Console.WriteLine("\n0. Exit");

            Console.Write("\nEnter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddCitizenMenu();
                    break;

                case 2:
                    SearchCitizenMenu();
                    break;

                case 3:
                    AssignServiceMenu();
                    break;

                case 4:
                    citizenSystem.ShowPopularServices();
                    break;

                case 5:
                    CreateRootMenu();
                    break;

                case 6:
                    AddDepartmentMenu();
                    break;

                case 7:
                    citizenSystem.ShowOrganization();
                    break;

                case 8:
                    AddRoadMenu();
                    break;

                case 9:
                    ShortestPathMenu();
                    break;

                case 0:
                    Console.WriteLine("Exiting system...");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 0);
    }

    private void AddCitizenMenu()
    {
        Console.Write("Enter ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter City: ");
        string city = Console.ReadLine();

        citizenSystem.AddCitizen(id, name, city);
    }

    private void SearchCitizenMenu()
    {
        Console.Write("Enter ID to search: ");
        int id = Convert.ToInt32(Console.ReadLine());

        citizenSystem.SearchCitizen(id);
    }

    private void AssignServiceMenu()
    {
        Console.Write("Enter Citizen ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Service Name: ");
        string service = Console.ReadLine();

        citizenSystem.AssignService(id, service);
    }

    private void CreateRootMenu()
    {
        Console.Write("Enter Organization Root Name: ");
        string root = Console.ReadLine();

        citizenSystem.CreateOrganizationRoot(root);
    }

    private void AddDepartmentMenu()
    {
        Console.Write("Enter Parent Department Name: ");
        string parent = Console.ReadLine();

        Console.Write("Enter New Department Name: ");
        string child = Console.ReadLine();

        citizenSystem.AddDepartment(parent, child);
    }

    private void AddRoadMenu()
    {
        Console.Write("Enter Starting Location: ");
        string from = Console.ReadLine();

        Console.Write("Enter Destination Location: ");
        string to = Console.ReadLine();

        citizenSystem.AddRoad(from, to);
    }

    private void ShortestPathMenu()
    {
        Console.Write("Enter Start Location: ");
        string start = Console.ReadLine();

        Console.Write("Enter End Location: ");
        string end = Console.ReadLine();

        citizenSystem.FindShortestPath(start, end);
    }
}
