using System;
using System.Reflection;

class Employee
{
    public int Id = 1;
    public string Name = "Raj";
}

class ObjectToJson
{
    static void Main()
    {
        Employee emp = new Employee();
        Type t = emp.GetType();

        Console.Write("{ ");
        foreach (var f in t.GetFields())
        {
            Console.Write($"\"{f.Name}\": \"{f.GetValue(emp)}\" ");
        }
        Console.Write("}");
    }
}
