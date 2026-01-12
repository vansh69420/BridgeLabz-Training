using System;

public class PipeMenu
{
    private IPipeCutting service = new PipeUtilityImpl();

    public void ShowMenu()
    {
        service.InitializePriceChart();
        int choice;

        do
        {
            Console.WriteLine("\n=== Metal Pipe Cutting Menu ===");
            Console.WriteLine("1. Optimized Revenue");
            Console.WriteLine("2. Non-Optimized Revenue");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");

            int.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Optimized Revenue = ₹" +
                        service.GetOptimizeRevenue(8));
                    break;

                case 2:
                    Console.WriteLine("Non-Optimized Revenue = ₹" +
                        service.GetNonOptimizeRevenue(8));
                    break;

                case 3:
                    Console.WriteLine("Exit");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        } while (choice != 3);
    }
}
