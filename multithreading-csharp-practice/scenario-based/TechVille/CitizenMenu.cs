using System;

namespace TechVille
{
    public class CitizenMenu
    {
        private ICitizenService service = new CitizenUtility();

        public void Show()
        {
            int choice;

            do
            {
                Console.WriteLine("\n===== TechVille Citizen Network System - V11 =====");
                Console.WriteLine("1. Add Citizen");
                Console.WriteLine("2. Show All Citizens (Forward)");
                Console.WriteLine("3. Show All Citizens (Reverse)");
                Console.WriteLine("4. Process Linked Queue (FIFO - LinkedList)");
                Console.WriteLine("5. Process Array Queue (FIFO - Array)");
                Console.WriteLine("6. Process Circular Queue");
                Console.WriteLine("7. Add Emergency (Priority Queue)");
                Console.WriteLine("8. Process Emergency");
                Console.WriteLine("9. Edit Citizen");
                Console.WriteLine("10. Undo Edit");
                Console.WriteLine("11. Show Healthcare Service Citizens");
                Console.WriteLine("12. Show Education Service Citizens");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        service.AddCitizen();
                        break;

                    case 2:
                        service.ShowAllCitizens();
                        break;

                    case 3:
                        service.ShowReverseCitizens();
                        break;

                    case 4:
                        service.ProcessLinkedQueue();
                        break;

                    case 5:
                        service.ProcessArrayQueue();
                        break;

                    case 6:
                        service.ProcessCircularQueue();
                        break;

                    case 7:
                        service.AddEmergency();
                        break;

                    case 8:
                        service.ProcessEmergency();
                        break;

                    case 9:
                        service.EditCitizen();
                        break;

                    case 10:
                        service.UndoEdit();
                        break;

                    case 11:
                        service.ShowHealthcareCitizens();
                        break;

                    case 12:
                        service.ShowEducationCitizens();
                        break;

                    case 0:
                        Console.WriteLine("Exiting System...");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }

            } while (choice != 0);
        }
    }
}
