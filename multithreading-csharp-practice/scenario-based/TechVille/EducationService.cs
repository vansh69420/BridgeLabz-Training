using System;

namespace TechVille
{
    public class EducationService : Service
    {
        public EducationService()
            : base("Education Service", 3000)
        {
        }

        public override void DisplayServiceDetails()
        {
            Console.WriteLine("Education Benefits Provided");
            Console.WriteLine("Cost: " + ServiceCost);
        }
    }
}
