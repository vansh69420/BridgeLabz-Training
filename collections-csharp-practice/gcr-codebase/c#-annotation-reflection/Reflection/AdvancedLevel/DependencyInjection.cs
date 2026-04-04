using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field)]
class InjectAttribute : Attribute { }

class Service
{
    public void Execute()
    {
        Console.WriteLine("Service Executed");
    }
}

class Client
{
    [Inject]
    public Service service;
}

class DIContainer
{
    public static void InjectDependencies(object obj)
    {
        foreach (var field in obj.GetType().GetFields())
        {
            if (field.GetCustomAttribute<InjectAttribute>() != null)
            {
                object dependency = Activator.CreateInstance(field.FieldType);
                field.SetValue(obj, dependency);
            }
        }
    }
}

class DependencyInjection
{
    static void Main()
    {
        Client client = new Client();
        DIContainer.InjectDependencies(client);
        client.service.Execute();
    }
}
