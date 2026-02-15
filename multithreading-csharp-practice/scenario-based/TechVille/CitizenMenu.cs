using System;

public class CitizenMenu
{
    private ICitizenService citizenSystem = new CitizenUtility();

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("\n--- Citizen Hybrid System ---");
            Console.WriteLine("1. Add Citizen");
            Console.WriteLine("2. Search Citizen");
            Console.WriteLine("3. Assign Service");
            Console.WriteLine("4. View Citizen History");
            Console.WriteLine("5. Show Popular Services");
            Console.WriteLine("6. Exit");

            Console.Write("Enter Choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddCitizenUI();
                    break;
                case 2:
                    SearchCitizenUI();
                    break;
                case 3:
                    AssignServiceUI();
                    break;
                case 4:
                    ViewHistoryUI();
                    break;
                case 5:
                    citizenSystem.ShowServiceFrequency();
                    break;
                case 6:
                    return;
            }
        }
    }

    private void AddCitizenUI()
    {
        Console.Write("Enter ID: ");
        string id = Console.ReadLine();

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine());

        citizenSystem.AddCitizen(new Citizen(id, name, age));
    }

    private void SearchCitizenUI()
    {
        Console.Write("Enter ID: ");
        string id = Console.ReadLine();

        Citizen citizen = citizenSystem.SearchCitizen(id);

        if (citizen != null)
            Console.WriteLine("\n" + citizen.ToString());
        else
            Console.WriteLine("Citizen not found.");
    }

    private void AssignServiceUI()
    {
        Console.Write("Enter Citizen ID: ");
        string id = Console.ReadLine();

        Console.Write("Enter Service Name: ");
        string service = Console.ReadLine();

        citizenSystem.AssignService(id, service);
    }

    private void ViewHistoryUI()
    {
        Console.Write("Enter Citizen ID: ");
        string id = Console.ReadLine();

        citizenSystem.ShowCitizenHistory(id);
    }
}
