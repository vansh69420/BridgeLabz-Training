using System;

namespace TechVille
{
    public class HealthcareService : Service
    {
        public HealthcareService() : base("Healthcare Service", 5000)
        {
        }

        public override void DisplayServiceDetails()
        {
            Console.WriteLine("Healthcare Benefits Provided.");
            base.DisplayServiceDetails();
        }
    }
}
