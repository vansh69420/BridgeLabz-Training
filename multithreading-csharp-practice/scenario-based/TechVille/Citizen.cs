using System;

namespace TechVille
{
    public class Citizen
    {
        private string name;
        private int age;
        private double income;
        private int residencyYears;
        private double eligibilityScore;
        private string? servicePackage;


        public Citizen(string name, int age, double income, int residencyYears)
        {
            this.name = name;
            this.age = age;
            this.income = income;
            this.residencyYears = residencyYears;
        }

        public string Name { get; set; } = "";

        public double Income { get; set; }
        public int ResidencyYears { get; set; }

        public int Age { get; set; }

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
            return $"Name: {Name}\nAge: {Age}\nIncome: {Income}\nResidency Years: {ResidencyYears}\nEligibility Score: {EligibilityScore}\nService Package: {ServicePackage}";
        }
    }
}
