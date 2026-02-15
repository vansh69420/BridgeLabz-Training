public interface ICitizenService
{
    // Module 10
    void AddCitizen(int id, string name, string city);
    void SearchCitizen(int id);

    // Module 11
    void AssignService(int id, string service);
    void ShowPopularServices();

    // Module 13 - Infrastructure
    void CreateOrganizationRoot(string name);
    void AddDepartment(string parent, string child);
    void ShowOrganization();

    void AddRoad(string from, string to);
    void FindShortestPath(string start, string end);
}
