using System;

namespace TechVille
{
    public class CitizenUtility : ICitizenService
    {
        private Citizen[] citizens;
        private int count = 0;

        public CitizenUtility()
        {
            citizens = new Citizen[10];
        }

        public void AddCitizen()
        {
            if (count >= citizens.Length)
            {
                Console.WriteLine("Storage Full.");
                return;
            }

            Citizen citizen = RegisterCitizen();

            if (!ValidateCitizen(citizen))
            {
                Console.WriteLine("Invalid Data.");
                return;
            }

            CalculateEligibility(citizen);

            citizens[count] = citizen;
            count++;

            Console.WriteLine("Citizen Registered Successfully.");
        }

        public void DisplayAll()
        {
            if (count == 0)
            {
                Console.WriteLine("No records found.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("\n--- Citizen " + (i + 1) + " ---");
                Console.WriteLine(citizens[i].ToString());
            }
        }

        public void SearchCitizen()
        {
            Console.Write("Enter Name to Search: ");
            string searchName = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (citizens[i].Name.ToLower() == searchName.ToLower())
                {
                    Console.WriteLine("Citizen Found:");
                    Console.WriteLine(citizens[i].ToString());
                    found = true;
                    break;
                }
            }

            if (!found)
                Console.WriteLine("Citizen not found.");
        }

        // ----------------- Private Logic Methods -----------------

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

        private bool ValidateCitizen(Citizen citizen)
        {
            if (citizen.Age < 18)
                return false;

            if (citizen.ResidencyYears < 1)
                return false;

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
