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
                Console.WriteLine("\n===== TechVille Citizen Network System =====");
                Console.WriteLine("1. Register Citizen");
                Console.WriteLine("2. View All Citizens");
                Console.WriteLine("3. Search Citizen");
                Console.WriteLine("4. Delete Citizen");
                Console.WriteLine("5. Show Service Queue");
                Console.WriteLine("6. Process Next Citizen");
                Console.WriteLine("7. Navigate Forward");
                Console.WriteLine("8. Navigate Backward");
                Console.WriteLine("9. Show Round Robin");
                Console.WriteLine("10. Show Healthcare Service Citizens");
                Console.WriteLine("11.Show Education Service Citizens");
                Console.WriteLine("12. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: service.AddCitizen(); break;
                    case 2: service.DisplayAll(); break;
                    case 3: service.SearchCitizen(); break;
                    case 4: service.DeleteCitizen(); break;
                    case 5: service.ShowServiceQueue(); break;
                    case 6: service.ProcessNextCitizen(); break;
                    case 7: service.NavigateForward(); break;
                    case 8: service.NavigateBackward(); break;
                    case 9: service.ShowRoundRobin(); break;
                    case 10:service.ShowHealthcareCitizens();break;
                    case 11:service.ShowEducationCitizens();break;
                    case 12: return;

                }
            }
        }
    }
}
