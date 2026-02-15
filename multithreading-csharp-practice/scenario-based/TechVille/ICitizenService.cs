namespace TechVille
{
    public interface ICitizenService
    {
        void AddCitizen();
        void ShowAllCitizens();
        void ShowReverseCitizens();

        void ProcessLinkedQueue();
        void ProcessArrayQueue();
        void ProcessCircularQueue();

        void AddEmergency();
        void ProcessEmergency();

        void EditCitizen();
        void UndoEdit();

        void ShowHealthcareCitizens();
        void ShowEducationCitizens();
    }
}
