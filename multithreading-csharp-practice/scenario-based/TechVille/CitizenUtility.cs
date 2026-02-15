using System;
using System.Collections.Generic;

public class CitizenUtility : ICitizenService
{
    // Primary HashMap
    private Dictionary<string, LinkedList<Citizen>> citizenMap;

    // Frequency counter
    private Dictionary<string, int> serviceFrequency;

    public CitizenUtility()
    {
        citizenMap = new Dictionary<string, LinkedList<Citizen>>();
        serviceFrequency = new Dictionary<string, int>();
    }

    // Add Citizen (Collision handled by chaining)
    public void AddCitizen(Citizen citizen)
    {
        string id = citizen.GetCitizenId();

        if (!citizenMap.ContainsKey(id))
        {
            citizenMap[id] = new LinkedList<Citizen>();
        }

        citizenMap[id].AddLast(citizen);

        Console.WriteLine("Citizen added successfully.");
    }

    // O(1) Lookup
    public Citizen SearchCitizen(string citizenId)
    {
        if (citizenMap.ContainsKey(citizenId))
        {
            foreach (var citizen in citizenMap[citizenId])
            {
                return citizen;
            }
        }

        return null;
    }

    // Assign Service
    public void AssignService(string citizenId, string serviceName)
    {
        Citizen citizen = SearchCitizen(citizenId);

        if (citizen == null)
        {
            Console.WriteLine("Citizen not found.");
            return;
        }

        citizen.AddService(serviceName);

        if (!serviceFrequency.ContainsKey(serviceName))
            serviceFrequency[serviceName] = 0;

        serviceFrequency[serviceName]++;

        Console.WriteLine("Service assigned successfully.");
    }

    public void ShowCitizenHistory(string citizenId)
    {
        Citizen citizen = SearchCitizen(citizenId);

        if (citizen == null)
        {
            Console.WriteLine("Citizen not found.");
            return;
        }

        Console.WriteLine("\n" + citizen.ToString());
        Console.WriteLine("Service History:");

        foreach (var service in citizen.GetServiceHistory())
        {
            Console.WriteLine("- " + service);
        }
    }

    public void ShowServiceFrequency()
    {
        Console.WriteLine("\nService Usage Report:");

        foreach (var service in serviceFrequency)
        {
            Console.WriteLine(service.Key + " : " + service.Value);
        }
    }
}
