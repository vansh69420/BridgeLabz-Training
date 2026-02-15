public interface ICitizenService
{
    // Module 10
    void AddCitizen(int id, string name, string city, int age, double income);
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

    // Module 14 - Sorting & Searching
    void BubbleSortByAge();
    void InsertionSortByAge();
    void MergeSortByIncome();
    void QuickSortByAge();

    void LinearSearchByName(string name);
    void BinarySearchById(int id);

    void CompareSortingPerformance(int size);

    // Module 15 - Performance
    void BenchmarkSearch(int iterations);
    void BenchmarkSorting(int size);


}
