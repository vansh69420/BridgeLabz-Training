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

            string errorMessage;

            if (!ValidateCitizen(citizen, out errorMessage))
            {
                Console.WriteLine(errorMessage);
                return;
            }

            CalculateEligibility(citizen);

            citizens[count] = citizen;
            count++;

            Console.WriteLine("Citizen Registered Successfully.");

            // Demonstrating Object Creation
            Service healthcare = new HealthcareService();
            Service education = new EducationService();

            Console.WriteLine("\nAvailable Services for Citizen:");
            healthcare.DisplayServiceDetails();
            education.DisplayServiceDetails();

            Console.WriteLine("\nTotal Citizens Registered: " + Citizen.GetTotalCitizens());
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
            string name = Console.ReadLine();

            Citizen citizen = FindCitizen(name);

            if (citizen == null)
                Console.WriteLine("Citizen not found.");
            else
                Console.WriteLine(citizen.ToString());
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

            ApplyIncomeBonus(ref score, citizen.Income);

            citizen.EligibilityScore = score;

            AssignServicePackage(score, citizen);
        }
        private void ApplyIncomeBonus(ref double score, double income)
        {
            if (income > 100000)
                score += 10;
        }
        private void AssignServicePackage(double score, Citizen citizen)
        {
            if (score < 30)
                citizen.ServicePackage = "Basic";
            else if (score <= 50)
                citizen.ServicePackage = "Silver";
            else if (score <= 75)
                citizen.ServicePackage = "Gold";
            else
                citizen.ServicePackage = "Platinum";
        }
        private void AssignServicePackage(Citizen citizen, string packageName)
        {
            citizen.ServicePackage = packageName;
        }

        private Citizen FindCitizen(string name)
        {
            for (int i = 0; i < count; i++)
            {
                if (citizens[i].Name.ToLower() == name.ToLower())
                    return citizens[i];
            }

            return null;
        }

    }
}
