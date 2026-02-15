using System;

namespace TechVille
{
    public abstract class Service
    {
        private string serviceName;
        private double serviceCost;

        // 🔥 Each service has its own citizen list
        protected DoublyLinkedCitizenList assignedCitizens;

        public Service(string serviceName, double serviceCost)
        {
            this.serviceName = serviceName;
            this.serviceCost = serviceCost;
            assignedCitizens = new DoublyLinkedCitizenList();
        }

        public string ServiceName { get { return serviceName; } }
        public double ServiceCost { get { return serviceCost; } }

        public void AssignCitizen(Citizen citizen)
        {
            assignedCitizens.Insert(citizen);
            Console.WriteLine(citizen.Name + " assigned to " + serviceName);
        }

        public void RemoveCitizen(string name)
        {
            assignedCitizens.Delete(name);
        }

        public void ShowAssignedCitizens()
        {
            Console.WriteLine("\nCitizens under " + serviceName);
            assignedCitizens.TraverseForward();
        }

        public abstract void DisplayServiceDetails();
    }
}
