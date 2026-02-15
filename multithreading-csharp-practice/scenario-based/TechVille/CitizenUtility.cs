using System;

namespace TechVille
{
    public class CitizenUtility : ICitizenService
    {
        // ===== Module 10 Structures =====
        private DoublyLinkedCitizenList citizenList = new DoublyLinkedCitizenList();
        private SinglyLinkedCitizenQueue linkedQueue = new SinglyLinkedCitizenQueue();
        private CircularCitizenList circularList = new CircularCitizenList();

        // ===== Module 11 Structures =====
        private ArrayQueue arrayQueue = new ArrayQueue(10);
        private CircularArrayQueue circularQueue = new CircularArrayQueue(5);
        private PriorityQueue priorityQueue = new PriorityQueue();
        private CitizenStack undoStack = new CitizenStack(10);

        // ===== Services =====
        private HealthcareService healthcareService = new HealthcareService();
        private EducationService educationService = new EducationService();

        // ===============================
        // Add Citizen
        // ===============================
        public void AddCitizen()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter Monthly Income: ");
            double income = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter Residency Years: ");
            int residencyYears = int.Parse(Console.ReadLine() ?? "0");

            Citizen citizen = new Citizen(name, age, income, residencyYears);

            citizenList.Insert(citizen);
            linkedQueue.Enqueue(citizen);
            circularList.Insert(citizen);

            arrayQueue.Enqueue(citizen);
            circularQueue.Enqueue(citizen);

            // Service logic (example)
            if (income > 50000)
                healthcareService.AssignCitizen(citizen);
            else
                educationService.AssignCitizen(citizen);

            Console.WriteLine("Citizen Added Successfully.");
        }


        // ===============================
        // Display Citizens (DLL)
        // ===============================
        public void ShowAllCitizens()
        {
            citizenList.TraverseForward();
        }

        public void ShowReverseCitizens()
        {
            citizenList.TraverseBackward();
        }

        // ===============================
        // Queue Operations
        // ===============================
        public void ProcessLinkedQueue()
        {
            Citizen served = linkedQueue.Dequeue();
            if (served != null)
                Console.WriteLine("Served (LinkedQueue): " + served.Name);
        }

        public void ProcessArrayQueue()
        {
            Citizen served = arrayQueue.Dequeue();
            if (served != null)
                Console.WriteLine("Served (ArrayQueue): " + served.Name);
        }

        public void ProcessCircularQueue()
        {
            Citizen served = circularQueue.Dequeue();
            if (served != null)
                Console.WriteLine("Served (CircularQueue): " + served.Name);
        }

        // ===============================
        // Priority Queue (Emergency)
        // ===============================
        public void AddEmergency()
        {
            Console.Write("Enter Citizen Name: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Enter Priority (1-10): ");
            int priority = int.Parse(Console.ReadLine() ?? "0");

            // Dummy values for required constructor parameters
            Citizen citizen = new Citizen(name, 0, 0, 0);

            priorityQueue.Enqueue(citizen, priority);

            Console.WriteLine("Emergency Added.");
        }


        public void ProcessEmergency()
        {
            Citizen served = priorityQueue.Dequeue();
            if (served != null)
                Console.WriteLine("Emergency Served: " + served.Name);
        }

        // ===============================
        // Stack Undo Example
        // ===============================
        public void EditCitizen()
        {
            Console.Write("Enter name to edit: ");
            string name = Console.ReadLine();

            Citizen found = citizenList.Search(name);

            if (found != null)
            {
                undoStack.Push(found);

                Console.Write("Enter new age: ");
                found.Age = int.Parse(Console.ReadLine());

                Console.WriteLine("Citizen Updated.");
            }
            else
            {
                Console.WriteLine("Citizen not found.");
            }
        }

        public void UndoEdit()
        {
            Citizen previous = undoStack.Pop();

            if (previous != null)
                Console.WriteLine("Undo performed for: " + previous.Name);
        }

        // ===============================
        // Services
        // ===============================
        public void ShowHealthcareCitizens()
        {
            healthcareService.ShowAssignedCitizens();
        }

        public void ShowEducationCitizens()
        {
            educationService.ShowAssignedCitizens();
        }
    }
}
