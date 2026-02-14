using System;

namespace TechVille
{
    public class CitizenMenu
    {
        private ICitizenService service = new CitizenUtility();

        public void Show()
        {
            Console.WriteLine("===== TechVille Service Eligibility System =====");
            service.StartFamilyRegistration();
        }
    }
}
