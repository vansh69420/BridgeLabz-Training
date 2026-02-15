using System.Collections.Generic;

public class Citizen
{
    private string citizenId;
    private string name;
    private int age;

    // LinkedList for service history
    private LinkedList<string> serviceHistory;

    public Citizen(string citizenId, string name, int age)
    {
        this.citizenId = citizenId;
        this.name = name;
        this.age = age;
        this.serviceHistory = new LinkedList<string>();
    }

    // Getters & Setters
    public string GetCitizenId()
    {
        return citizenId;
    }

    public void SetCitizenId(string citizenId)
    {
        this.citizenId = citizenId;
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public int GetAge()
    {
        return age;
    }

    public void SetAge(int age)
    {
        this.age = age;
    }

    public LinkedList<string> GetServiceHistory()
    {
        return serviceHistory;
    }

    public void AddService(string serviceName)
    {
        serviceHistory.AddLast(serviceName);
    }

    public override string ToString()
    {
        return "Citizen ID: " + citizenId +
               "\nName: " + name +
               "\nAge: " + age +
               "\nTotal Services: " + serviceHistory.Count;
    }
}
