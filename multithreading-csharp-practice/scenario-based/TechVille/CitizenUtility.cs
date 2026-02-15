using System;
using System.Collections.Generic;

public class CitizenUtility : ICitizenService
{
    #region Module 10 - Citizen Management
    private Dictionary<int, Citizen> citizenMap;
    #endregion

    #region Module 11 - Service Tracking
    private Dictionary<string, int> serviceFrequency;
    #endregion

    #region Module 13 - Infrastructure
    private InfrastructureNode orgRoot;
    private Dictionary<string, List<string>> roadNetwork;
    #endregion

    #region Module 14 - Sorting & Searching
    private List<Citizen> GetCitizenList()
    {
        return new List<Citizen>(citizenMap.Values);
    }
    #endregion


    public CitizenUtility()
    {
        citizenMap = new Dictionary<int, Citizen>();
        serviceFrequency = new Dictionary<string, int>();
        roadNetwork = new Dictionary<string, List<string>>();
    }

    // ===============================
    // Module 10 - Citizen Management
    // ===============================

    public void AddCitizen(int id, string name, string city, int age, double income)
    {
        if (!citizenMap.ContainsKey(id))
        {
            citizenMap[id] = new Citizen(id, name, city, age, income);
            Console.WriteLine("Citizen added successfully.");
        }
        else
            Console.WriteLine("Citizen ID already exists.");
    }

    public void SearchCitizen(int id)
    {
        if (citizenMap.ContainsKey(id))
            Console.WriteLine(citizenMap[id]);
        else
            Console.WriteLine("Citizen not found.");
    }

    // ===============================
    // Module 11 - Services
    // ===============================

    public void AssignService(int id, string service)
    {
        if (!citizenMap.ContainsKey(id))
        {
            Console.WriteLine("Citizen not found.");
            return;
        }

        citizenMap[id].AddService(service);

        if (!serviceFrequency.ContainsKey(service))
            serviceFrequency[service] = 0;

        serviceFrequency[service]++;

        Console.WriteLine("Service assigned.");
    }

    public void ShowPopularServices()
    {
        foreach (var item in serviceFrequency)
            Console.WriteLine($"{item.Key} - Used {item.Value} times");
    }

    // ===============================
    // Module 13 - Organization Tree
    // ===============================

    public void CreateOrganizationRoot(string name)
    {
        orgRoot = new InfrastructureNode(name);
        Console.WriteLine("Organization root created.");
    }

    public void AddDepartment(string parent, string child)
    {
        InfrastructureNode parentNode = FindNode(orgRoot, parent);

        if (parentNode == null)
        {
            Console.WriteLine("Parent not found.");
            return;
        }

        parentNode.AddChild(new InfrastructureNode(child));
        Console.WriteLine("Department added.");
    }

    public void ShowOrganization()
    {
        PreOrder(orgRoot);
    }

    private void PreOrder(InfrastructureNode node)
    {
        if (node == null) return;

        Console.WriteLine(node.GetName());

        foreach (var child in node.GetChildren())
            PreOrder(child);
    }

    private InfrastructureNode FindNode(InfrastructureNode node, string name)
    {
        if (node == null) return null;

        if (node.GetName().Equals(name))
            return node;

        foreach (var child in node.GetChildren())
        {
            InfrastructureNode found = FindNode(child, name);
            if (found != null)
                return found;
        }

        return null;
    }

    // ===============================
    // Module 13 - Road Graph (BFS)
    // ===============================

    public void AddRoad(string from, string to)
    {
        if (!roadNetwork.ContainsKey(from))
            roadNetwork[from] = new List<string>();

        if (!roadNetwork.ContainsKey(to))
            roadNetwork[to] = new List<string>();

        roadNetwork[from].Add(to);
        roadNetwork[to].Add(from);

        Console.WriteLine("Road added.");
    }

    public void FindShortestPath(string start, string end)
    {
        Queue<string> queue = new Queue<string>();
        HashSet<string> visited = new HashSet<string>();

        queue.Enqueue(start);
        visited.Add(start);

        while (queue.Count > 0)
        {
            string current = queue.Dequeue();
            Console.WriteLine("Visited: " + current);

            if (current == end)
            {
                Console.WriteLine("Destination reached.");
                return;
            }

            foreach (var neighbor in roadNetwork[current])
            {
                if (!visited.Contains(neighbor))
                {
                    visited.Add(neighbor);
                    queue.Enqueue(neighbor);
                }
            }
        }

        Console.WriteLine("No path found.");
    }

    public void BubbleSortByAge()
    {
        var list = GetCitizenList();

        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = 0; j < list.Count - i - 1; j++)
            {
                if (list[j].GetAge() > list[j + 1].GetAge())
                {
                    var temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                }
            }
        }

        PrintList(list);
    }
    public void InsertionSortByAge()
    {
        var list = GetCitizenList();

        for (int i = 1; i < list.Count; i++)
        {
            var key = list[i];
            int j = i - 1;

            while (j >= 0 && list[j].GetAge() > key.GetAge())
            {
                list[j + 1] = list[j];
                j--;
            }

            list[j + 1] = key;
        }

        PrintList(list);
    }
    public void MergeSortByIncome()
    {
        var list = GetCitizenList();
        list = MergeSort(list);
        PrintList(list);
    }

    private List<Citizen> MergeSort(List<Citizen> list)
    {
        if (list.Count <= 1)
            return list;

        int mid = list.Count / 2;

        var left = MergeSort(list.GetRange(0, mid));
        var right = MergeSort(list.GetRange(mid, list.Count - mid));

        return Merge(left, right);
    }

    private List<Citizen> Merge(List<Citizen> left, List<Citizen> right)
    {
        List<Citizen> result = new List<Citizen>();

        while (left.Count > 0 && right.Count > 0)
        {
            if (left[0].GetIncome() < right[0].GetIncome())
            {
                result.Add(left[0]);
                left.RemoveAt(0);
            }
            else
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }
        }

        result.AddRange(left);
        result.AddRange(right);

        return result;
    }

    public void QuickSortByAge()
    {
        var list = GetCitizenList();
        QuickSort(list, 0, list.Count - 1);
        PrintList(list);
    }

    private void QuickSort(List<Citizen> list, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(list, low, high);
            QuickSort(list, low, pi - 1);
            QuickSort(list, pi + 1, high);
        }
    }

    private int Partition(List<Citizen> list, int low, int high)
    {
        int pivot = list[high].GetAge();
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (list[j].GetAge() < pivot)
            {
                i++;
                var temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }

        var swap = list[i + 1];
        list[i + 1] = list[high];
        list[high] = swap;

        return i + 1;
    }

    public void LinearSearchByName(string name)
    {
        foreach (var citizen in citizenMap.Values)
        {
            if (citizen.GetName().Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Found: " + citizen);
                return;
            }
        }

        Console.WriteLine("Citizen not found.");
    }
    public void BinarySearchById(int id)
    {
        var list = GetCitizenList();
        list.Sort((a, b) => a.GetId().CompareTo(b.GetId()));

        int left = 0, right = list.Count - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (list[mid].GetId() == id)
            {
                Console.WriteLine("Found: " + list[mid]);
                return;
            }
            else if (list[mid].GetId() < id)
                left = mid + 1;
            else
                right = mid - 1;
        }

        Console.WriteLine("Citizen not found.");
    }

    public void CompareSortingPerformance(int size)
    {
        List<int> data = new List<int>();
        Random rand = new Random();

        for (int i = 0; i < size; i++)
            data.Add(rand.Next(1, 10000));

        var stopwatch = System.Diagnostics.Stopwatch.StartNew();
        data.Sort();
        stopwatch.Stop();

        Console.WriteLine($"Built-in Sort Time: {stopwatch.ElapsedMilliseconds} ms");
    }
    private void PrintList(List<Citizen> list)
    {
        foreach (var citizen in list)
        {
            Console.WriteLine(citizen);
        }
    }

}
