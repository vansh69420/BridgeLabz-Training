namespace TechVille
{
    public interface ICitizenService
    {
        void AddCitizen();
        void DisplayAll();
        void SearchCitizen();
        void DeleteCitizen();

        void ShowServiceQueue();
        void ProcessNextCitizen();
        void NavigateForward();
        void NavigateBackward();
        void ShowRoundRobin();
        void ShowHealthcareCitizens();
        void ShowEducationCitizens();

    }
}
