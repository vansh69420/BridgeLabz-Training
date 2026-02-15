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

    public CitizenUtility()
    {
        citizenMap = new Dictionary<int, Citizen>();
        serviceFrequency = new Dictionary<string, int>();
        roadNetwork = new Dictionary<string, List<string>>();
    }

    // ===============================
    // Module 10 - Citizen Management
    // ===============================

    public void AddCitizen(int id, string name, string city)
    {
        if (!citizenMap.ContainsKey(id))
        {
            citizenMap[id] = new Citizen(id, name, city);
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
}
