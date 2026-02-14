using System;

namespace TechVille
{
    public class Citizen
    {
        // Private fields (Data Hiding)
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
        }

        // Public Properties (Controlled Access)
        public string Name
        {
            get { return name; }
        }

        public int Age
        {
            get { return age; }
        }

        public double Income
        {
            get { return income; }
        }

        public int ResidencyYears
        {
            get { return residencyYears; }
        }

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



        // ToString() Method
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
