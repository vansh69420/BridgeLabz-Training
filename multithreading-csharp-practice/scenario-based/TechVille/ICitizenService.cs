public interface ICitizenService
{
    void AddCitizen(Citizen citizen);
    Citizen SearchCitizen(string citizenId);
    void AssignService(string citizenId, string serviceName);
    void ShowCitizenHistory(string citizenId);
    void ShowServiceFrequency();
}
