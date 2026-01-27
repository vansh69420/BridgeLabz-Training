using System;
using System.Collections.Generic;
using System.Reflection;

class User
{
    public string Name;
    public int Age;
}

class ObjectMapper
{
    static void Main()
    {
        Dictionary<string, object> data = new Dictionary<string, object>
        {
            { "Name", "Aman" },
            { "Age", 22 }
        };

        User user = ToObject<User>(typeof(User), data);
        Console.WriteLine(user.Name + " " + user.Age);
    }

    static T ToObject<T>(Type type, Dictionary<string, object> values)
    {
        object obj = Activator.CreateInstance(type);

        foreach (var item in values)
        {
            FieldInfo field = type.GetField(item.Key);
            field.SetValue(obj, item.Value);
        }
        return (T)obj;
    }
}
