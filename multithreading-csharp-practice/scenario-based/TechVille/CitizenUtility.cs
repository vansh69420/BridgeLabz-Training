using System;

namespace TechVille
{
    public class CitizenUtility : ICitizenService
    {
        private DoublyLinkedCitizenList citizenList = new DoublyLinkedCitizenList();
        private SinglyLinkedCitizenQueue serviceQueue = new SinglyLinkedCitizenQueue();
        private CircularCitizenList circularList = new CircularCitizenList();
        private HealthcareService healthcareService = new HealthcareService();
        private EducationService educationService = new EducationService();


        public void AddCitizen()
        {
            Citizen citizen = RegisterCitizen();

            string errorMessage;

            if (!ValidateCitizen(citizen, out errorMessage))
            {
                Console.WriteLine(errorMessage);
                return;
            }

            CalculateEligibility(citizen);

            citizenList.Insert(citizen);
            serviceQueue.Enqueue(citizen);
            circularList.Insert(citizen);

            Console.WriteLine("Citizen Registered Successfully.");

            // Assign service based on eligibility
            if (citizen.ServicePackage == "Gold" || citizen.ServicePackage == "Platinum")
            {
                healthcareService.AssignCitizen(citizen);
            }
            else
            {
                educationService.AssignCitizen(citizen);
            }

        }

        public void ShowHealthcareCitizens()
        {
            healthcareService.ShowAssignedCitizens();
        }

        public void ShowEducationCitizens()
        {
            educationService.ShowAssignedCitizens();
        }


        public void DisplayAll()
        {
            citizenList.TraverseForward();
        }

        public void SearchCitizen()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Citizen citizen = citizenList.Find(name);

            if (citizen == null)
                Console.WriteLine("Citizen not found.");
            else
                Console.WriteLine(citizen.ToString());
        }

        public void DeleteCitizen()
        {
            Console.Write("Enter Name to Delete: ");
            string name = Console.ReadLine();

            citizenList.Delete(name);
        }

        public void ShowServiceQueue()
        {
            serviceQueue.Display();
        }

        public void ProcessNextCitizen()
        {
            serviceQueue.Dequeue();
        }

        public void NavigateForward()
        {
            citizenList.TraverseForward();
        }

        public void NavigateBackward()
        {
            citizenList.TraverseBackward();
        }

        public void ShowRoundRobin()
        {
            circularList.Display();
        }

        private Citizen RegisterCitizen()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Income: ");
            double income = double.Parse(Console.ReadLine());

            Console.Write("Enter Residency Years: ");
            int residencyYears = int.Parse(Console.ReadLine());

            return new Citizen(name, age, income, residencyYears);
        }

        private bool ValidateCitizen(Citizen citizen, out string errorMessage)
        {
            if (citizen.Age < 18)
            {
                errorMessage = "Citizen must be 18+.";
                return false;
            }

            if (citizen.ResidencyYears < 1)
            {
                errorMessage = "Residency must be at least 1 year.";
                return false;
            }

            errorMessage = "";
            return true;
        }

        private void CalculateEligibility(Citizen citizen)
        {
            double score = 0;

            score += citizen.Age * 0.5;
            score += citizen.ResidencyYears * 2;
            score += citizen.Income / 10000;

            citizen.EligibilityScore = score;

            if (score < 30)
                citizen.ServicePackage = "Basic";
            else if (score <= 50)
                citizen.ServicePackage = "Silver";
            else if (score <= 75)
                citizen.ServicePackage = "Gold";
            else
                citizen.ServicePackage = "Platinum";
        }
    }
}
