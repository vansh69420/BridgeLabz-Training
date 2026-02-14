namespace TechVille
{
    public class Service
    {
        protected string serviceName;
        protected double serviceCost;

        // Constructor
        public Service(string serviceName, double serviceCost)
        {
            this.serviceName = serviceName;
            this.serviceCost = serviceCost;
        }

        public string ServiceName
        {
            get { return serviceName; }
        }

        public double ServiceCost
        {
            get { return serviceCost; }
        }

        public virtual void DisplayServiceDetails()
        {
            System.Console.WriteLine("Service: " + serviceName);
            System.Console.WriteLine("Cost: " + serviceCost);
        }
    }
}
