using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class TodoAttribute : Attribute
{
    public string Task;
    public string AssignedTo;
    public string Priority;

    public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

class Project
{
    [Todo("Add login", "Aman")]
    public void Login() { }

    [Todo("Optimize DB", "Vansh", "HIGH")]
    public void Database() { }
}

class TodoAttribute
{
    static void Main()
    {
        foreach (MethodInfo m in typeof(Project).GetMethods())
        {
            TodoAttribute attr = m.GetCustomAttribute<TodoAttribute>();
            if (attr != null)
            {
                Console.WriteLine($"{m.Name} → {attr.Task}, {attr.AssignedTo}, {attr.Priority}");
            }
        }
    }
}
