using System;

public class BrowserMenu
{
    private IBrowserOperations manager;

    public BrowserMenu()
    {
        manager = new BrowserUtilityImpl();
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("\n=== BrowserBuddy Menu ===");
            Console.WriteLine("1. Visit Page");
            Console.WriteLine("2. Back");
            Console.WriteLine("3. Forward");
            Console.WriteLine("4. Close Tab");
            Console.WriteLine("5. Restore Closed Tab");
            Console.WriteLine("6. Show Current Page");
            Console.WriteLine("7. Exit");
            Console.Write("Enter choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: manager.VisitPage(); break;
                case 2: manager.Back(); break;
                case 3: manager.Forward(); break;
                case 4: manager.CloseTab(); break;
                case 5: manager.RestoreTab(); break;
                case 6: manager.ShowCurrentPage(); break;
                case 7: return;
                default: Console.WriteLine("Invalid choice"); break;
            }
        }
    }
}
