using System;

namespace TechVille
{
    public class CitizenMenu
    {
        private ICitizenService service = new CitizenUtility();

        public void Show()
        {
            while (true)
            {
                Console.WriteLine("\n===== TechVille Service Eligibility System =====");
                Console.WriteLine("1. Register Family Member");
                Console.WriteLine("2. View All Members");
                Console.WriteLine("3. Search by Name");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        service.AddCitizen();
                        break;

                    case 2:
                        service.DisplayAll();
                        break;

                    case 3:
                        service.SearchCitizen();
                        break;

                    case 4:
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
