using System;

public class CitizenMenu
{
    private ICitizenService citizenSystem = new CitizenUtility();

    public void Start()
    {
        int choice;

        do
        {
            Console.WriteLine("\n=====================================");
            Console.WriteLine("      CITY MANAGEMENT SYSTEM");
            Console.WriteLine("=====================================");

            Console.WriteLine("\n--- Module 10: Citizen Management ---");
            Console.WriteLine("1. Add Citizen");
            Console.WriteLine("2. Search Citizen");

            Console.WriteLine("\n--- Module 11: Service Management ---");
            Console.WriteLine("3. Assign Service");
            Console.WriteLine("4. Show Popular Services");

            Console.WriteLine("\n--- Module 13: Organization (Tree) ---");
            Console.WriteLine("5. Create Organization Root");
            Console.WriteLine("6. Add Department");
            Console.WriteLine("7. Show Organization (PreOrder)");

            Console.WriteLine("\n--- Module 13: Road Network (Graph) ---");
            Console.WriteLine("8. Add Road");
            Console.WriteLine("9. Find Shortest Path (BFS)");

            Console.WriteLine("\n--- Module 14: Sorting ---");
            Console.WriteLine("10. Bubble Sort by Age (Small Dataset)");
            Console.WriteLine("11. Insertion Sort by Age (Nearly Sorted)");
            Console.WriteLine("12. Merge Sort by Income (Large Dataset)");
            Console.WriteLine("13. Quick Sort by Age (General Purpose)");

            Console.WriteLine("\n--- Module 14: Searching ---");
            Console.WriteLine("14. Linear Search by Name");
            Console.WriteLine("15. Binary Search by ID");

            Console.WriteLine("\n--- Module 14: Performance ---");
            Console.WriteLine("16. Compare Sorting Performance");

            Console.WriteLine("\n--- Module 15: Performance Benchmarking ---");
            Console.WriteLine("17. Benchmark Citizen Search");
            Console.WriteLine("18. Benchmark Sorting");


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

                case 10:
                    citizenSystem.BubbleSortByAge();
                    break;

                case 11:
                    citizenSystem.InsertionSortByAge();
                    break;

                case 12:
                    citizenSystem.MergeSortByIncome();
                    break;

                case 13:
                    citizenSystem.QuickSortByAge();
                    break;

                case 14:
                    LinearSearchMenu();
                    break;

                case 15:
                    BinarySearchMenu();
                    break;

                case 16:
                    ComparePerformanceMenu();
                    break;

                case 17:
                    BenchmarkSearchMenu();
                    break;

                case 18:
                    BenchmarkSortingMenu();
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

        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Income: ");
        double income = Convert.ToDouble(Console.ReadLine());

        citizenSystem.AddCitizen(id, name, city, age, income); // assuming updated constructor handled internally
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

    private void LinearSearchMenu()
    {
        Console.Write("Enter Name to Search: ");
        string name = Console.ReadLine();
        citizenSystem.LinearSearchByName(name);
    }

    private void BinarySearchMenu()
    {
        Console.Write("Enter ID to Search: ");
        int id = Convert.ToInt32(Console.ReadLine());
        citizenSystem.BinarySearchById(id);
    }

    private void ComparePerformanceMenu()
    {
        Console.Write("Enter Dataset Size: ");
        int size = Convert.ToInt32(Console.ReadLine());
        citizenSystem.CompareSortingPerformance(size);
    }

    private void BenchmarkSearchMenu()
    {
        Console.Write("Enter number of iterations: ");
        int iterations = Convert.ToInt32(Console.ReadLine());
        citizenSystem.BenchmarkSearch(iterations);
    }
    private void BenchmarkSortingMenu()
    {
        Console.Write("Enter dataset size: ");
        int size = Convert.ToInt32(Console.ReadLine());
        citizenSystem.BenchmarkSorting(size);
    }

}
