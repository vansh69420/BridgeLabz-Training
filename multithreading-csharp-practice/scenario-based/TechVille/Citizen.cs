using System;

namespace TechVille
{
    public class Citizen
    {
        // Static variable (Class Variable)
        private static int totalCitizens = 0;

        // Private fields (Instance Variables)
        private string name;
        private int age;
        private double income;
        private int residencyYears;
        private double eligibilityScore;
        private string servicePackage;

        // Constructor
        public Citizen(string name, int age, double income, int residencyYears)
        {
            this.name = name;
            this.age = age;
            this.income = income;
            this.residencyYears = residencyYears;

            totalCitizens++; // Count object creation
        }

        // Static Method
        public static int GetTotalCitizens()
        {
            return totalCitizens;
        }

        // Public Properties
        public string Name { get { return name; } }
        public int Age { get { return age; } }
        public double Income { get { return income; } }
        public int ResidencyYears { get { return residencyYears; } }

        public double EligibilityScore
        {
            get { return eligibilityScore; }
            set { eligibilityScore = value; }
        }

        public string ServicePackage
        {
            get { return servicePackage; }
            set { servicePackage = value; }
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"Age: {Age}\n" +
                   $"Income: {Income}\n" +
                   $"Residency Years: {ResidencyYears}\n" +
                   $"Eligibility Score: {EligibilityScore}\n" +
                   $"Service Package: {ServicePackage}";
        }
    }
}
