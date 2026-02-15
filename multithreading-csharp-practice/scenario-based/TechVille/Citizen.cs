using System.Collections.Generic;

public class Citizen
{
    private int id;
    private string name;
    private string city;
    private int age;
    private double income;

    private List<string> services;

    public Citizen(int id, string name, string city, int age, double income)
    {
        this.id = id;
        this.name = name;
        this.city = city;
        this.age = age;
        this.income = income;
        services = new List<string>();
    }

    public int GetId() => id;
    public string GetName() => name;
    public string GetCity() => city;

    public int GetAge() => age;
    public double GetIncome() => income;
    public List<string> GetServices() => services;

    public void AddService(string service)
    {
        services.Add(service);
    }

    public override string ToString()
    {
        return $"ID: {id}, Name: {name}, City: {city}";
    }
}
