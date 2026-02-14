using System;

namespace TechVille
{
    public class CitizenUtility : ICitizenService
    {
        public void StartFamilyRegistration()
        {
            while (true)
            {
                Console.WriteLine("\n1. Register Family Member");
                Console.WriteLine("2. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 2)
                    break;   // break usage

                Citizen citizen = RegisterCitizen();

                if (!ValidateCitizen(citizen))
                {
                    Console.WriteLine("Invalid Data. Skipping...");
                    continue;   // continue usage
                }

                CalculateEligibility(citizen);

                Console.WriteLine("Override Service Package? (yes/no)");
                string overrideChoice = Console.ReadLine();

                if (overrideChoice.ToLower() == "yes")
                {
                    Console.WriteLine("1. Basic");
                    Console.WriteLine("2. Silver");
                    Console.WriteLine("3. Gold");
                    Console.WriteLine("4. Platinum");

                    int packageChoice = int.Parse(Console.ReadLine());

                    switch (packageChoice)   // switch usage
                    {
                        case 1:
                            citizen.ServicePackage = "Basic";
                            break;
                        case 2:
                            citizen.ServicePackage = "Silver";
                            break;
                        case 3:
                            citizen.ServicePackage = "Gold";
                            break;
                        case 4:
                            citizen.ServicePackage = "Platinum";
                            break;
                        default:
                            Console.WriteLine("Invalid selection.");
                            break;
                    }
                }

                DisplayCitizen(citizen);
            }
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

        private bool ValidateCitizen(Citizen citizen)
        {
            if (citizen.Age < 18)
            {
                Console.WriteLine("Citizen must be 18+.");
                return false;
            }

            if (citizen.ResidencyYears < 1)
            {
                Console.WriteLine("Residency must be at least 1 year.");
                return false;
            }

            return true;
        }

        private void CalculateEligibility(Citizen citizen)
        {
            double score = 0;

            score += citizen.Age * 0.5;
            score += citizen.ResidencyYears * 2;
            score += citizen.Income / 10000;

            citizen.EligibilityScore = score;

            AssignServicePackage(citizen);
        }

        private void AssignServicePackage(Citizen citizen)
        {
            double score = citizen.EligibilityScore;

            // Nested if-else
            if (score < 30)
                citizen.ServicePackage = "Basic";
            else if (score <= 50)
                citizen.ServicePackage = "Silver";
            else if (score <= 75)
                citizen.ServicePackage = "Gold";
            else
                citizen.ServicePackage = "Platinum";
        }

        private void DisplayCitizen(Citizen citizen)
        {
            string status = citizen.EligibilityScore > 50 ?
                            "Premium Eligible" :
                            "Standard Eligible";   // ternary

            Console.WriteLine("\n--- Citizen Details ---");
            Console.WriteLine(citizen.ToString());
            Console.WriteLine("Status: " + status);
        }
    }
}
